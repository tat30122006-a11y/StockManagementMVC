using Microsoft.EntityFrameworkCore;

namespace StockManagementMVC.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
