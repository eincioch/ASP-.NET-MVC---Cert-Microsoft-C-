using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeliveryOnline.Models
{
    public class DeliveryOnLineContext : DbContext 
    {
        public DeliveryOnLineContext(): base("DeliveryOnlineContext")
        {

        }

        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Persona> Usuarios { get; set; }

        public DbSet<Repartidor> Repartidores { get; set; }

        public DbSet<Producto> Productos { get; set; }
                
        public DbSet<TiendaProducto> TiendaProductos { get; set; }
    }
}