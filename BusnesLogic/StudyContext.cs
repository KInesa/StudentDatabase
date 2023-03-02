using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgzamDatabase.Model;

namespace StudentDatabase.BusnesLogic
{
    public class StudyContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Departament> Departament { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
            => option.UseSqlServer($"Server = localhost,Database = StudentsInfoDatabase, Trusted_Connection = true, Encrypt = False");
    }
}
