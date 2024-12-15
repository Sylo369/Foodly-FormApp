using Foodly_FormApp.Model;
using Foodly_FormApp.Utils;
using Microsoft.EntityFrameworkCore;


namespace Foodly_FormApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TableModel> Tables { get; set; }
        public DbSet<MenuItemModel> MenuItems { get; set; }


        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            optionsBuilder.UseSqlServer(DbConfiguration.ConnectionString);
            return new DataContext(optionsBuilder.Options);
        }

     
    }
}
