using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication16.Models;
using WebApplication16.Repositories;
using WebApplication16.Services;

namespace WebApplication16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     [Authorize]
    public class ProductsApiController : ControllerBase
    {
        public IProductService _service;
        public ProductsApiController(IProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_service.GetAllProducts());
        }


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _service.GetProductById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested Product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpGet ("{Category}/Category")]
        public IActionResult ProductsFromCategory(string Category)
        {
            List<Product> obj= _service.ProductsFromCategory(Category);
            return Ok(obj);

        }


        [HttpGet("GetOutOfStockProducts")]
        public IActionResult GetOutOfStockProducts()
        {
            List<Product> obj = _service.GetOutOfStockProducts();
            return Ok(obj);

        }

        [HttpGet("{low},{high}")]
        public IActionResult ProductsInRange(int low, int high)
        {
            List<Product> obj = _service.ProductsInRange(low,high);
            return Ok(obj);

        }


        [HttpPost]
        public IActionResult CreateProduct(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "Product Details added to db" });
        }


        [HttpPut]
        public IActionResult UpdateStudent(Product obj)
        {
            _service.UpdateProduct(obj);
            return Ok(new { result = "Student details Updated Successfully" });

        }

        [HttpGet("{category}/category")]
        public IActionResult GetCategory(string category)
        {
            List<Product> products = _service.GetCategory(category);
            return Ok(products);
        }

        [HttpGet("UniqueCategories")]
        public IActionResult UniqueCategories()
        {
            List<string> products = _service.UniqueCategories();
            return Ok(products);
        }

        [HttpDelete]
        public void DeleteProduct(int id) { 
        
        _service.DeleteProduct(id); 
        
        }





    }
}









