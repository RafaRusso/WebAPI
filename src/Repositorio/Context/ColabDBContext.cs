using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Domain;

namespace Data.Context
{
    public class ColabDBContext : DbContext
    {
        public ColabDBContext(DbContextOptions<ColabDBContext> options) : base(options) 
        {

        }

        public DbSet<Colab> Colabs { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>()
                .HasMany(p => p.Colaboradores)
                .WithMany(p =>p.Departamentos)
                .UsingEntity(j => j.ToTable("ColabDepartamento"));
            modelBuilder.Entity<Grupo>()
                .HasMany(p => p.Colaboradores)
                .WithMany(p => p.Grupos)
                .UsingEntity(j => j.ToTable("ColabGrupo"));
        }
    }
}
