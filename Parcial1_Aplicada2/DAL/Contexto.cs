using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial1_Aplicada2.Models;

namespace Parcial1_Aplicada2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\luisd\OneDrive\Escritorio\Universidad\Programacion Aplicada 2\Base_de_Datos_de_Blazor\Parcial1DB\Parcial1.db");
        }
    }
}
