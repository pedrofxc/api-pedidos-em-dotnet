using Microsoft.EntityFrameworkCore;
using ApiPedidos.Models;

namespace ApiPedidos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Pedido> Pedidos => Set<Pedido>();
}
