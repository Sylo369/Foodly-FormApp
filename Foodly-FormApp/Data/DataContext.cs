using Foodly_FormApp.Model;
using Microsoft.EntityFrameworkCore;


namespace Foodly_FormApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
                
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TableModel> Tables { get; set; }
        public DbSet<MenuItemModel> MenuItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QMK9CKO\\SQLEXPRESS;Database=FoodlyDB;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }


      
           
      

    }
}
