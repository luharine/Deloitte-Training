using Microsoft.EntityFrameworkCore;

namespace WebApplication16.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public string Description { get; set; }
    }


    public class ProductsDbContext : DbContext
    {
        // This property refer the databse table 
        // Multiple tables required multiple properties
        public DbSet<Product> Products { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
         : base(options)
        {

        }


    }
}
