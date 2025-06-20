using lesson.helpers;
using lesson.response;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson
{
    public partial class MainForm : Form
    {
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
                string filter = Uri.EscapeDataString("[{\"property\":\"status\",\"value\":\"ACTIVE\",\"operator\":\"==\"}]");
                string url = $"https://{settings.Domain}.vetmanager2.ru/rest/api/client?filter={filter}";

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
                    comboClients.Items.Clear();

                    foreach (var row in clientResponse.data.client)
                    {
                        comboClients.Items.Add(new ComboBoxClient
                        {
                            text = $"{row.last_name} {row.first_name} {row.middle_name}".Trim(),
                            value = row.id
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
            MessageBox.Show("qweqwe");
        }
    }

    class ComboBoxClient
    {
        public string text { get; set; }
        public int value { get; set; }
    }
}
