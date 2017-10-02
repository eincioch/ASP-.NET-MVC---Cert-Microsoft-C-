using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DbSet<TiposMenu> TipoMenus { get; set; }
        public DbSet<TiendaProducto> TiendaProductos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<DetallePedido> DetallePedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiendaProducto>()
                    .Property(p => p.dFechaEfectiva)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}