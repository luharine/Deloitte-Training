using WebApplication16.Models;

namespace WebApplication16.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product obj);
        void UpdateProduct(Product obj);
        void DeleteProduct(int id);

        List<Product> ProductsFromCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> ProductsInRange(int low, int high);
        List<Product> GetCategories(string category);
        List<string> UniqueCategories();

    }
}
