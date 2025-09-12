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

    }
}
