using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Http;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ShoppingManager
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BusinessController : Controller
    {
        public ProductContext db;
        public BusinessController(ProductContext context)
        {
            db = context;
        }

        [HttpGet]
        public List<Product> Get() //получение (Read)
        {
            var list = db.Products.ToList();
            return list;
        }

        //запись (Create)
        [HttpPost]
        public IActionResult Create([FromBody]Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) //удаление (Delete)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Remove(product);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Product entity) //изменение (Update)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Update(entity);
            db.SaveChanges();
            return Ok();
        }
    }
}
