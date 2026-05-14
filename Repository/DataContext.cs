using Microsoft.EntityFrameworkCore;
using StockManagementMVC.Models;

namespace StockManagementMVC.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; }
    }
}
