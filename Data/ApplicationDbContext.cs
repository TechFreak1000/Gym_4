using Gym.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace Gym.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //DbSet<> refers to mapping The respective table 
        //<Customer> is DataType which is the class model of customer 
        //CustomerDetails is the objectname which is nothing but the table name in the Db
        public DbSet<Customer> CustomerDetail { get; set; }
        public DbSet<Exercise> ExerciseDetail { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

            
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 1,
                MuscleGroup = "Chest",
                ExerciseName = "Benchpress"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {   Id = 1,
                Name = "Akshay",
                UserName = "ak2003",
                DateOfResgistration = DateOnly.FromDateTime(DateTime.Now),
                DOB = new DateOnly(2003,6,13),
                Email = "dandwateakshay77@gmail.com",
                PIN = 2003,
                PhoneNumber = "9158559339",
                Gender = "Male",
                BMI = 22,
            },
            new Customer
            {
                Id = 2,
                Name = "Shubham Joshi",
                UserName = "ShubhamJoshi32",
                DateOfResgistration = DateOnly.FromDateTime(DateTime.Now),
                DOB = new DateOnly(2003, 6, 13),
                Email = "shubhamjoshi@gmail.com",
                PIN = 2002,
                PhoneNumber = "9370110732",
                Gender = "Male",
                BMI = 22,
            });
        }
    }
}
