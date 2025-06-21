using lesson.response;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lesson.helpers
{
    internal class AppSettings
    {
        public string Domain { get; set; }
        public string Service { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }

        public AppSettings LoadSettingFromXml()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");

            if (!File.Exists(filePath))
            {
                return null;
            }

            XElement root = XElement.Load(filePath);

            return new AppSettings
            {
                Domain = root.Element("Domain")?.Value,
                Service = root.Element("Service")?.Value,
                Token = root.Element("Token")?.Value,
                UserId = root.Element("UserId")?.Value
            };
        }

        public void SaveSettingsToXml(AuthData data, string domain)
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
