using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static S3_P4.Models.Estudiante;

namespace S3_P4.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}