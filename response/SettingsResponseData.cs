namespace lesson.response
{
    internal class SettingsResponseData
    {
        public int status { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public AuthData data { get; set; }
    }

    public class AuthData
    {
        public string service { get; set; }
        public string token { get; set; }
        public string user_id { get; set; }
    }
}
