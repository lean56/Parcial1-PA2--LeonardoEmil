using Microsoft.EntityFrameworkCore;
using Parcial1_PA2.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_PA2.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=EMIL56\SQLEXPRESS; Database=Parcial1DB; trusted_connection=true");
        }
        public DbSet<Producto> Productos { get; set; }
    }
}
