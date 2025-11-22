using Microsoft.EntityFrameworkCore;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
         public DbSet<MyTask> TodoTasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Nationality> Nationalities { get; set; }

        public DbSet<Priority> Priorities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Work", Description = "Tasks related to your job or career" },
                new Category { Id = 2, Name = "Personal", Description = "Personal goals and errands" },
                new Category { Id = 3, Name = "Health", Description = "Fitness, exercise, and wellness tasks" },
                new Category { Id = 4, Name = "Study", Description = "Assignments, courses, and study plans" },
                new Category { Id = 5, Name = "Shopping", Description = "Grocery or online shopping lists" }
            );


            modelBuilder.Entity<Nationality>().HasData(
               new Nationality { Id = 1, Name_ar = "السعودية", Name_en = "Saudi Arabia", Country_code = "SA" },
               new Nationality { Id = 2, Name_ar = "مصر", Name_en = "Egypt", Country_code = "EG" },
               new Nationality { Id = 3, Name_ar = "الأردن", Name_en = "Jordan", Country_code = "JO" },
               new Nationality { Id = 4, Name_ar = "الكويت", Name_en = "Kuwait", Country_code = "KW" },
               new Nationality { Id = 5, Name_ar = "الإمارات", Name_en = "United Arab Emirates", Country_code = "AE" },
               new Nationality { Id = 6, Name_ar = "البحرين", Name_en = "Bahrain", Country_code = "BH" },
               new Nationality { Id = 7, Name_ar = "قطر", Name_en = "Qatar", Country_code = "QA" },
               new Nationality { Id = 8, Name_ar = "عمان", Name_en = "Oman", Country_code = "OM" }
           );



            modelBuilder.Entity<Client>().HasData(
    new Client
    {
        Id = 1,
        Name = "Shuruq Althagafi",
        Email = "shuruq@example.com",
        Password = "123456",
        Phone = "0501234567",
        Gender = "Female",
        NationalityId = 1 // Saudi Arabia
    },
    new Client
    {
        Id = 2,
        Name = "Omar Hassan",
        Email = "omar@example.com",
        Password = "omarpass",
        Phone = "0109876543",
        Gender = "Male",
        NationalityId = 2 // Egypt
    },
    new Client
    {
        Id = 3,
        Name = "Laila Al-Kuwaiti",
        Email = "laila@example.com",
        Password = "laila2025",
        Phone = "96550011223",
        Gender = "Female",
        NationalityId = 4 // Kuwait
    },
    new Client
    {
        Id = 4,
        Name = "Ahmed Al Ameri",
        Email = "ahmed@example.com",
        Password = "ahmed@123",
        Phone = "97150111222",
        Gender = "Male",
        NationalityId = 5 // UAE
    }
);



            modelBuilder.Entity<Priority>().HasData(
                new Priority { Id = 1, Name = "Low" },
                new Priority { Id = 2, Name = "Medium" },
                new Priority { Id = 3, Name = "High" }
            );










        }
    }
}
