using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository.DbContext
{
    public class ApplicationDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empledaos { get; set; }

        public ApplicationDBContext(DbContextOptions options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
