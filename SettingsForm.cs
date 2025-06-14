using lesson.response;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lesson
{
    public partial class SettingsForm : Form
    {
        private readonly HttpClient client = new HttpClient();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string domain, out string login, out string password))
                return;

            string url = $"https://{domain}.vetmanager2.ru/token_auth.php";
            var formData = CreateFormData(login, password);

            try
            {
                HttpResponseMessage response = await client.PostAsync(url, formData);
                string result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Авторизация не удалась!", "Ошибка");
                    return;
                }

                var authResult = JsonSerializer.Deserialize<SettingsResponseData>(result);

                if (authResult != null)
                {
                    SaveSettingsToXml(authResult.data, domain);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateInput(out string domain, out string login, out string password)
        {
            domain = DomainInput.Text.Trim();
            login = LoginInput.Text.Trim();
            password = PasswordInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(domain) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return false;
            }

            return true;
        }

        private MultipartFormDataContent CreateFormData(string login, string password)
        {
            var data = new MultipartFormDataContent();
            data.Add(new StringContent(LoginInput.Text), "login");
            data.Add(new StringContent(PasswordInput.Text), "password");
            data.Add(new StringContent("my_service"), "app_name");
            return data;
        }

        private void SaveSettingsToXml(AuthData data, string domain)
        {
            try
            {
                var settings = new XElement("Settings",
                    new XElement("Domain", domain),
                    new XElement("Service", data.service),
                    new XElement("Token", data.token),
                    new XElement("UserId", data.user_id)
                );

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");
                settings.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }
    }
}
