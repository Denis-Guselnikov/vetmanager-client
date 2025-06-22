using System.Collections.Generic;

namespace lesson.response
{
    internal class PetTypeResponseData
    {
        public bool success { get; set; }
        public string message { get; set; }
        public PetTypeData data { get; set; }
    }

    public class PetTypeData
    {
        public int totalCount { get; set; }
        public List<PetType> petType { get; set; }
    }

    public class PetType
    {
        public int id { get; set; }
        public string title { get; set; }
        public string picture { get; set; }
        public string type { get; set; }
        public List<Breed> breeds { get; set; }
    }

    public class Breed
    {
        public int id { get; set; }
        public string title { get; set; }
        public int pet_type_id { get; set; }
    }
}
