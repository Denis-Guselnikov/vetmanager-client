using System.Collections.Generic;

namespace lesson.response
{
    internal class ClientResponseData
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int totalCount { get; set; }
        public List<Client> client { get; set; }
    }

    public class Client
    {
        public int id { get; set; }
        public string address { get; set; }
        public string home_phone { get; set; }
        public string work_phone { get; set; }
        public string note { get; set; }
        public int? type_id { get; set; }
        public int? how_find { get; set; }
        public string balance { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public int? city_id { get; set; }
        public string date_register { get; set; }
        public string cell_phone { get; set; }
        public string zip { get; set; }
        public object registration_index { get; set; }
        public int vip { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string status { get; set; }
        public int discount { get; set; }
        public string passport_series { get; set; }
        public string lab_number { get; set; }
        public int street_id { get; set; }
        public string apartment { get; set; }
        public int unsubscribe { get; set; }
        public int in_blacklist { get; set; }
        public string last_visit_date { get; set; }
        public string number_of_journal { get; set; }
        public string phone_prefix { get; set; }
        public CityData city_data { get; set; }
        public ClientTypeData client_type_data { get; set; }
        public StreetData street_data { get; set; }
    }

    public class CityData
    {
        public int id { get; set; }
        public string title { get; set; }
        public int type_id { get; set; }
    }

    public class ClientTypeData
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class StreetData
    {
        public int id { get; set; }
        public string title { get; set; }
        public int city_id { get; set; }
        public string type { get; set; }
    }
}
