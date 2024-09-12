using WebApplication16.Models;
using WebApplication16.Repositories;

namespace WebApplication16.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void AddProduct(Product obj)
        {
            _repository.AddProduct(obj);
        }

        public void UpdateProduct(Product obj) {

            _repository.UpdateProduct(obj);
        }

        public List<Product> ProductsFromCategory(string category) {

          return  _repository.ProductsFromCategory(category);
        }


        public List<Product> GetOutOfStockProducts() {
            return _repository.GetOutOfStockProducts();
                }

        public List<Product> ProductsInRange(int low, int high)
        {
            return _repository.ProductsInRange(low, high);
        }

        public List<Product> GetCategory(string category) { 
        
           return _repository.GetCategories(category);
        }

        public List<string> UniqueCategories() {
            return _repository.UniqueCategories();
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }
    }
}
