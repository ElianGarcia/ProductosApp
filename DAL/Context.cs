using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductosApp.BLL;
using ProductosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosApp.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = ProductosDB; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Productos>().HasData(new Productos
            {
                Codigo = 1,
                Descripcion = "Zapato",
                Precio = Convert.ToDecimal(150.00),
                Inventario = 25
            });

            model.Entity<Productos>().HasData(new Productos
            {
                Codigo = 2,
                Descripcion = "Toallas",
                Precio = Convert.ToDecimal(165.00),
                Inventario = 25
            });

            model.Entity<Productos>().HasData(new Productos
            {
                Codigo = 3,
                Descripcion = "Celular",
                Precio = Convert.ToDecimal(8900.00),
                Inventario = 25
            });

            model.Entity<Productos>().HasData(new Productos
            {
                Codigo = 4,
                Descripcion = "Computadora",
                Precio = Convert.ToDecimal(18900.00),
                Inventario = 25
            });

            model.Entity<Productos>().HasData(new Productos
            {
                Codigo = 5,
                Descripcion = "Control Remoto",
                Precio = Convert.ToDecimal(80.00),
                Inventario = 25
            });
        }

        public DbSet<Productos> Productos { get; set; }
    }
}
