using Microsoft.AspNetCore.Mvc;
using question_api.Data;
using question_api.Models;

namespace question_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/items
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _context.Items.ToList(); // Retorna todos os itens no banco
            return Ok(items);
        }
    }
}
