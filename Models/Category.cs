using System.ComponentModel.DataAnnotations;

namespace To_DoList_AspMVC.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        public string Uid { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<MyTask>? TodoTasks { get; set; }
    }
}
