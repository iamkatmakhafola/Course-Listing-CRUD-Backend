using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using u21503193_HW01_API.Models;

namespace u21503193_HW01_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var SeedData = new Course[]
            {
                new Course
                {
                    CourseId = 1,
                    Name = "AIM101",
                    Duration = "Semester",
                    Description = "Year 1, Semester 1. Academic Information Management"
                },
                new Course
                {
                    CourseId = 2,
                    Name = "ALL121",
                    Duration = "Semester",
                    Description = "Year 1, Semester 2. Academic Literacy for IT"
                },
                new Course
                {
                    CourseId = 3,
                    Name = "INF171",
                    Duration = "Year",
                    Description = "Year 1. Systems Analysis and Design"
                },
                new Course
                {
                    CourseId = 4,
                    Name = "INF271",
                    Duration = "Year",
                    Description = "Year 2. Systems Analysis and Design"
                },
                new Course
                {
                    CourseId = 5,
                    Name = "INF272",
                    Duration = "Year",
                    Description = "Year 2. Programming"
                },
                new Course
                {
                    CourseId = 6,
                    Name = "INF214",
                    Duration = "Semester",
                    Description = "Year 2, Semester 1. Databases"
                },
                new Course
                {
                    CourseId = 7,
                    Name = "INF315",
                    Duration = "Semester",
                    Description = "Year 3, Semester 1. Programming Management"
                },
                new Course
                {
                    CourseId = 8,
                    Name = "INF324",
                    Duration = "Semester",
                    Description = "Year 3, Semester 2. IT Trends"
                },
                new Course
                {
                    CourseId = 9,
                    Name = "INF354",
                    Duration = "Semester",
                    Description = "Year 3, Semester 1. Programming"
                },
                new Course
                {
                    CourseId = 10,
                    Name = "INF370",
                    Duration = "Year",
                    Description = "Year 3. Project"
                }
            };
            modelBuilder.Entity<Course>().HasData(SeedData);
        }


    }
}
