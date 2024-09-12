using Microsoft.EntityFrameworkCore;
using WebApplication16.Models;

namespace WebApplication16.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductsDbContext _context;
        public ProductRepository(ProductsDbContext context) {
            _context = context; 
        }

        public List<Product> GetAllProducts()
        {
            List<Product> prods = _context.Products.ToList();
            return prods;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product obj)
        {
            _context.Products.Add(obj);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product obj) {

             _context.Products.Update(obj);
            _context.SaveChanges();
          }

       public void DeleteProduct(int id) {

            Product obj = _context.Products.Find(id);

            _context.Products.Remove(obj);
            _context.SaveChanges();
        
        }


        public List<Product> ProductsFromCategory(string category)
        {
            List<Product> products = _context.Products.Where(p=> p.Category == category).ToList();
            return products;
        }

        public List<Product> GetOutOfStockProducts()
        {
            List<Product> products = _context.Products.Where(p=>p.Quantity==0).ToList();
            return products;
           
        }

        public List<Product> ProductsInRange(int low, int high)
        {
            List<Product> products = _context.Products.Where(p => p.UnitPrice>=low && p.UnitPrice <=high).ToList(); 

            return products;
        }

        public List<Product> GetCategories(string category) { 
            List<Product> products = _context.Products.Where(p=>p.Category==category).ToList();
            return products;
        }

       public List<string> UniqueCategories()
        {
            List<string> categories = _context.Products.Select(p => (p.Category)).Distinct().ToList();
            return categories;
        }
    }
}
