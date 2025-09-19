namespace To_DoList_AspMVC.Models
{
    public class Nationality
    {

        public int Id { get; set; }
        public string Name_ar { get; set; }
        public string Name_en { get; set; }
        public string Country_code { get; set; }

        public ICollection<Client>? Clients { get; set; }
    }
}
