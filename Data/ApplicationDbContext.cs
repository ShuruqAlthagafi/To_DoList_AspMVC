using Microsoft.EntityFrameworkCore;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       public DbSet<MyTask> TodoTasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Nationality> Nationalities { get; set; }

    }
}
