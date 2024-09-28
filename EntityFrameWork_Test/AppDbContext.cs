using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork_Test
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connection.ConnectionString);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Cours> Courses { get; set; }

        public DbSet<StudentCours> StudentsCourses { get; set; }




    }
}
