using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dominio.Models;

namespace Repositorio.Data
{
    public class ColabDBContext : DbContext
    {
        public ColabDBContext(DbContextOptions<ColabDBContext> options) : base(options) 
        {

        }

        public DbSet<Colab> Colabs { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }


    }
}
