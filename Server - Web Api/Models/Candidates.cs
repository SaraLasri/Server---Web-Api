namespace Server___Web_Api.Models
{
    public class Candidates
    {
        public int id { get; set; }
        public string  name { get; set; }
        public string beginYear { get; set; }
        public string lastUpdateDate { get; set; }
        public Languages Languages { get; set; }
        //public ICollection<Languages> Languages { get; set; }
    }
}
