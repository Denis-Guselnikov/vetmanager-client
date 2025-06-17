using lesson.helpers;
using lesson.response;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace lesson
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainDataGridView.Rows.Add(4);
        }

        private async void btnSettingsApi_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные сохранены");

                AppSettings settigs = new AppSettings().LoadSettingFromXml();

                string url = $"https://{settigs.Domain}.vetmanager2.ru/rest/api/client";
                var client = CreateClient(settigs);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    string result = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Ошибка получения клиентов!", "Ошибка");
                        return;
                    }

                    var clientResponse = JsonSerializer.Deserialize<ClientResponseData>(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private HttpClient CreateClient(AppSettings settings)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-APP-NAME", settings.Service);
            client.DefaultRequestHeaders.Add("X-USER-TOKEN", settings.Token);
            return client;
        }
    }
}
