using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }


    public class ProductDbContext : DbContext
    {
        // This property refer the databse table 
        // Multiple tables required multiple properties
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
         : base(options)
        {

        }


    }
}
