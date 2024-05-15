using Microsoft.EntityFrameworkCore;
using Trabalho.get.MVC.Models;

namespace Trabalho.get.MVC.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        { 

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
