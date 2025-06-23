using lesson.helpers;
using lesson.request;
using lesson.response;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson
{
    public partial class PetForm : Form
    {
        private AppSettings settings;
        private List<PetType> petTypes;
        private readonly HttpClient client = new HttpClient();
        private int ownerId;
        private Pet pet;

        public PetForm(int ownerId): this(ownerId, null)
        {

        }

        public PetForm(int ownerId, Pet pet)
        {
            InitializeComponent();
            this.ownerId = ownerId;
            this.pet = pet;
            this.Text = (pet != null) ? "Редактирование питомца" : "Добавление питомца";
        }

        private async void PetForm_Load(object sender, EventArgs e)
        {
            settings = new AppSettings().LoadSettingFromXml();
            await LoadPetType();
            PrepareFieldsForAddNewPet();

            if (pet != null)
            {
                PrepareFieldsForEditPet();
            }
        }        

        private void comboPetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPetType.SelectedItem is PetType selectedType)
            {
                comboBreed.DataSource = null;
                comboBreed.Items.Clear();

                if (selectedType.breeds != null)
                {
                    comboBreed.DataSource = selectedType.breeds;
                    comboBreed.DisplayMember = "title";
                    comboBreed.ValueMember = "id";
                }
            }
        }

        private async Task LoadPetType()
        {
            try
            {
                var client = CreateClient(settings);
                string url = $"https://{settings.Domain}.vetmanager2.ru/rest/api/petType";

                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();
                var petTypeResponse = JsonSerializer.Deserialize<PetTypeResponseData>(result);

                if (petTypeResponse.success == true)
                {
                    petTypes = petTypeResponse.data.petType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private HttpClient CreateClient(AppSettings settings)
        {
            client.DefaultRequestHeaders.Add("X-APP-NAME", settings.Service);
            client.DefaultRequestHeaders.Add("X-USER-TOKEN", settings.Token);
            return client;
        }

        private void PrepareFieldsForEditPet()
        {
            aliasInput.Text = pet.alias;
            comboPetType.SelectedValue = pet?.pet_type_id ?? -1;

            var breedItems = comboBreed.Items.Cast<Breed>().ToList();
            var selectedBreed = breedItems.FirstOrDefault(breed => breed.title == pet.breed);
            comboBreed.SelectedValue = selectedBreed?.id ?? -1;

            var sexItems = comboSex.Items.Cast<SexItem>().ToList();
            var selectedSex = sexItems.FirstOrDefault(s => s.value == pet.sex);
            comboSex.SelectedValue = selectedSex?.id ?? -1;

            DateTime.TryParseExact(pet.birthday, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthday);

            if (birthday != DateTime.MinValue)
            {
                petBirthdayInput.Value = birthday;
            }
        }

        private void PrepareFieldsForAddNewPet()
        {
            comboSex.DataSource = new List<SexItem>
            {
                new SexItem{name = "Самец", id = 1, value = "male"},
                new SexItem{name = "Самка", id = 2, value = "female"},
                new SexItem{name = "Неизвестно", id = 5, value = "unknown"}
            };
            comboSex.DisplayMember = "name";
            comboSex.ValueMember = "id";
            comboSex.SelectedIndex = -1;

            comboPetType.DataSource = petTypes;
            comboPetType.DisplayMember = "title";
            comboPetType.ValueMember = "id";
            comboPetType.SelectedIndex = -1;

            comboBreed.SelectedIndex = -1;
        }

        private async void btnPetSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string alias, out PetType petType, out Breed breed))
                return;

            var selectedSex = comboSex.SelectedItem as SexItem;
            string birthday = petBirthdayInput.Value.ToString("yyyy-MM-dd");

            CreatePetRequest request = new CreatePetRequest
            {
                owner_id = this.ownerId,
                alias = alias,
                type_id = petType.id,
                breed_id = breed.id,
                sex = selectedSex?.id,
                birthday = birthday
            };

            var result = await CreatePetAsync(request);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAddPetClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput(out string alias, out PetType petType, out Breed breed)
        {
            alias = aliasInput.Text.Trim();
            petType = comboPetType.SelectedItem as PetType;
            breed = comboBreed.SelectedItem as Breed;

            if (string.IsNullOrWhiteSpace(alias))
            {
                MessageBox.Show("Поле 'Кличка' обязательно для заполнения.", "Ошибка");
                return false;
            }

            if (petType == null)
            {
                MessageBox.Show("Выберите вид животного.", "Ошибка");
                return false;
            }

            if (breed == null)
            {
                MessageBox.Show("Выберите породу животного.", "Ошибка");
                return false;
            }

            return true;
        }

        private async Task<bool> CreatePetAsync(CreatePetRequest request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = (pet?.pet_id > 0)
                ? $"https://{settings.Domain}.vetmanager2.ru/rest/api/pet/{pet.pet_id}"
                : $"https://{settings.Domain}.vetmanager2.ru/rest/api/pet";

            try
            {
                HttpResponseMessage response = (pet?.pet_id > 0)
                    ? await client.PutAsync(url, content)
                    : await client.PostAsync(url, content);

            } catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }

            return true;
        }
    }
}
