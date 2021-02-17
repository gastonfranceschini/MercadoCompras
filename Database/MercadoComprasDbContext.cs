using MercadoCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace MercadoCompras.Database
{
    public class MercadoComprasDbContext : DbContext
    {
        public MercadoComprasDbContext(DbContextOptions<MercadoComprasDbContext> options) 
            : base(options)
        {
        }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<CarritoItem> CarritoItems { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
