namespace lesson.request
{
    internal class CreatePetRequest
    {
        public int owner_id { get; set; }
        public int breed_id { get; set; }
        public int type_id { get; set; }
        public string alias { get; set; }
        public int? sex {  get; set; }
        public string birthday { get; set; }
    }

    public class SexItem
    {
        public string name { get; set; }
        public int id { get; set; }
        public string value { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
