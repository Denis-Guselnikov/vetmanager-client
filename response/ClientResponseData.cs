using System.Collections.Generic;

namespace lesson.response
{
    internal class ClientResponseData
    {
        public Data data { get; set; }
        public bool success { get; set; }
    }

    public class Data
    {
        public List<Client> client { get; set; }
    }

    public class Client
    {
        public int client_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int in_blacklist { get; set; }
        public string description { get; set; }
        public string balance { get; set; }
        public string type { get; set; }
        public string cell_phone { get; set; }
        public string status { get; set; }
        public string apartment { get; set; }
        public string phone_prefix { get; set; }
        public int city_id { get; set; }
        public string city_title { get; set; }
        public int city_type_id { get; set; }
        public object street_id { get; set; }
        public object street_title { get; set; }
        public object street_type { get; set; }
        public string clinic_phone_prefix { get; set; }
        public List<Pet> pets { get; set; }
    }

    public class Pet
    {
        public int pet_id { get; set; }
        public string alias { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public int owner_id { get; set; }
        public string pet_type { get; set; }
        public string breed { get; set; }
        public string pet_type_title { get; set; }
        public int pet_type_id { get; set; }
    }
}
