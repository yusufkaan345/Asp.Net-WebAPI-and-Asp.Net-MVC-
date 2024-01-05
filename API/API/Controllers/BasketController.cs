using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]

    public class BasketController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public BasketController(ApiDbContext context)
        {
            _context = context;

        }
        // GET: api/<BasketController>
        [HttpGet]
        public async Task<ActionResult<List<BasketModel>>> GetBasketItems()
        {
            var liste = _context.BasketTable.ToList();
            return Ok(liste);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _context.BasketTable.FindAsync(id);
            if (product == null)
            {
                return NotFound("incorrect customer id");
            }
            _context.BasketTable.Remove(product);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<ProductModel>> AddDatabase(BasketModel product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }
}
