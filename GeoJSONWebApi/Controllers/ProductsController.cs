using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeoJSONWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeoJSONWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            new Product { Id = 4, Name = "Sweater", Category = "Clothes", Price = 16.99M },
            new Product { Id = 5, Name = "Wrench", Category = "Tools", Price = 16.99M },
            new Product { Id = 6, Name = "Beer", Category = "Drinks", Price = 16.99M },
            new Product { Id = 7, Name = "Bolt", Category = "Parts", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }



        [HttpGet("{id}")]
        public ActionResult<string> GetProduct(int id)
        {
            //return "value";

            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        //public IHttpActionResult GetProduct(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}


    }
}