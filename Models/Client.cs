using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_DoList_AspMVC.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Uid { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Phone { get; set; }

        public string Gender { get; set; }

        [ForeignKey("Nationality")]
        public int? NationalityId { get; set; }
        public Nationality? Nationality { get; set; }


        public ICollection<MyTask>? MyTasks { get; set; }





    }
}

    
