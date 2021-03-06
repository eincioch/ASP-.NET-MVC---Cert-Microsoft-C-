﻿using System;
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

        public DbSet<TipoCliente> TipoClientes { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Persona> Usuarios { get; set; }
        public DbSet<Repartidor> Repartidores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TiposMenu> TipoMenus { get; set; }
        public DbSet<TiendaProducto> TiendaProductos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<AsignarRepPedido> AsignarRepPedidos { get; set; }
        public DbSet<TipoDocuVenta> TipoDocuVentas { get; set; }
        public DbSet<DocuVentaCorrelativo> DocuVentaCorrelativos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiendaProducto>()
                    .Property(p => p.dFechaEfectiva)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);


            //Duda como aplica On-Memory a un Tabla
            //modelBuilder.Entity<Tienda>().ForSqlServerIsMemoryOptimized();
        }


    }
}