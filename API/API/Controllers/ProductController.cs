using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace Ders2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class ProductController : ControllerBase
    {

        private readonly ApiDbContext _context;
        public ProductController(ApiDbContext context)
        {
            _context = context;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetProducts() {

            return Ok(await _context.ProductTable.ToListAsync());
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<List<ProductModel>>> GetProducts(int id)
        {
            var product = _context.ProductTable.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductModel>> Create(ProductModel product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductModel>> Update(int id, ProductModel product)
        {
            if(id!=product.ProductId)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product= await _context.ProductTable.FindAsync(id);
            if (product == null)
            {
                return NotFound("incorrect customer id");
            }
            _context.ProductTable.Remove( product);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
