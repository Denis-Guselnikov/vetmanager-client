using lesson.helpers;
using lesson.request;
using lesson.response;
using System;
using System.Collections.Generic;
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

        public PetForm(int ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

        private async void PetForm_Load(object sender, EventArgs e)
        {
            settings = new AppSettings().LoadSettingFromXml();
            await LoadPetType();

            comboSex.DataSource = new List<SexItem>
            {
                new SexItem{name = "Самец", id = 1},
                new SexItem{name = "Самка", id = 2},
                new SexItem{name = "Неизвестно", id = 5}
            };

            comboPetType.DataSource = petTypes;
            comboPetType.DisplayMember = "title";
            comboPetType.ValueMember = "id";
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

        private async void btnAddPetSave_Click(object sender, EventArgs e)
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
            string url = $"https://{settings.Domain}.vetmanager2.ru/rest/api/pet";

            HttpResponseMessage response = await client.PostAsync(url, content);



            return true;
        }
    }
}
