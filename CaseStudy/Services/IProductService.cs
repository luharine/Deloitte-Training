using WebApplication16.Models;

namespace WebApplication16.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product obj);

        void UpdateProduct(Product obj);

        public List<Product> ProductsFromCategory(string category);
        public List<Product> GetOutOfStockProducts();
        public List<Product> ProductsInRange(int low, int high);

        public List<Product> GetCategory(string category);
        public List<string> UniqueCategories();
        public void DeleteProduct(int id);


    }
}
