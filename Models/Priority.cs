namespace To_DoList_AspMVC.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public string Uid { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
    }
}
