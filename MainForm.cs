using lesson.helpers;
using lesson.response;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace lesson
{
    public partial class MainForm : Form
    {
        private List<Client> clients;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var settings = new AppSettings().LoadSettingFromXml();

            if (settings != null)
            {
                await LoadClientsAsync(settings);
            }          
        }

        private async void btnSettingsApi_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные сохранены");

                AppSettings settigs = new AppSettings().LoadSettingFromXml();
                await LoadClientsAsync(settigs);               
            }
        }        

        private async Task LoadClientsAsync(AppSettings settings)
        {
            try
            {
                string url = $"https://{settings.Domain}.vetmanager2.ru/rest/api/client/clientsSearchData";

                var client = CreateClient(settings);

                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ошибка получения клиентов!", "Ошибка");
                    return;
                }

                var clientResponse = JsonSerializer.Deserialize<ClientResponseData>(result);

                if (clientResponse.data.client != null)
                {
                    clients = clientResponse.data.client;
                    comboClients.Items.Clear();

                    foreach (var row in clients)
                    {
                        comboClients.Items.Add(new ComboBoxClient
                        {
                            text = $"{row.last_name} {row.first_name} {row.middle_name}".Trim(),
                            value = row.client_id
                        });
                    }

                    comboClients.DisplayMember = "text";
                    comboClients.ValueMember = "value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private HttpClient CreateClient(AppSettings settings)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-APP-NAME", settings.Service);
            client.DefaultRequestHeaders.Add("X-USER-TOKEN", settings.Token);
            return client;
        }

        private void comboClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDataGridView.Rows.Clear();

            if (comboClients.SelectedItem is ComboBoxClient selectedClient)
            {
                int clientId = selectedClient.value;
                var selected = clients.FirstOrDefault(clients => clients.client_id == clientId);

                if (selected != null && selected.pets != null)
                {
                    foreach (var pet in selected.pets)
                    {
                        mainDataGridView.Rows.Add(
                            pet.pet_id,
                            pet.alias,
                            pet.pet_type_title,
                            pet.breed,
                            pet.sex,
                            pet.birthday
                            );
                    }

                    btnAddPet.Enabled = true;
                }
            }
        }

        private void ComboClientsTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboClients.Text))
            {
                mainDataGridView.Rows.Clear();
                btnAddPet.Enabled = false;
            }
        }
    }

    class ComboBoxClient
    {
        public string text { get; set; }
        public int value { get; set; }
    }
}
