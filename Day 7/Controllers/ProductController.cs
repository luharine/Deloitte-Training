using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        ProductDbContext _context;
        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            List<Product> Products = _context.Products.ToList();
            return Ok(Products);


        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {

            Product obj = _context.Products.Find(id);
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult PostProduct(Product obj)
        {
            if (obj != null)
            {
                _context.Products.Add(obj);
                _context.SaveChanges();
                return Ok(new { result = "Record inserted successfully" });
            }
            else
            {

                return NotFound(new { result = "Error in inserting the record" });
            }
        }

        [HttpPut]
        public IActionResult EditProduct(Product obj)
        {


            _context.Products.Update(obj);
            _context.SaveChanges();

            return Ok(new { result = "Updated Sucessfully" });

        }




    }
}
