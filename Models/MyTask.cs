using System.ComponentModel.DataAnnotations;

namespace To_DoList_AspMVC.Models
{
    public class MyTask
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? DueDate { get; set; }

        [Range(1, 3)]
        public int Priority { get; set; }

    }
}
