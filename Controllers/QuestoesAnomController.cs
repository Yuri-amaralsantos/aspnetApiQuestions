using Microsoft.AspNetCore.Mvc;
using question_api.Model;

namespace question_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestoesAnomController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuestoesAnomController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/items
        [HttpGet]
        public IActionResult GetItems()
        {

        }








        // POST: api/items
        [HttpPost]
        public IActionResult AddItem([FromBody] Questoes newItem)
        {
            if (newItem == null)
                return BadRequest("Invalid item data.");

            newItem.Id = Guid.NewGuid(); // Generate a new ID
            _context.QuestoesAnonimas.Add(newItem);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetItems), new { id = newItem.Id }, newItem);
        }

        // PUT: api/items/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateItem(Guid id, [FromBody] Questoes updatedItem)
        {
            if (id != updatedItem.Id)
                return BadRequest("ID mismatch.");

            var existingItem = _context.QuestoesAnonimas.Find(id);
            if (existingItem == null)
                return NotFound();

            // Update the item's properties
            existingItem.Question = updatedItem.Question;
            existingItem.Option1 = updatedItem.Option1;
            existingItem.Option2 = updatedItem.Option2;
            existingItem.Option3 = updatedItem.Option3;
            existingItem.Option4 = updatedItem.Option4;
            existingItem.Option5 = updatedItem.Option5;
            existingItem.CorrectAnswer = updatedItem.CorrectAnswer;

            _context.QuestoesAnonimas.Update(existingItem);
            _context.SaveChanges();

            return NoContent();
        }

        // PATCH: api/items/{id}
        [HttpPatch("{id}")]
        public IActionResult PartialUpdateItem(Guid id, [FromBody] Questoes partialUpdate)
        {
            var existingItem = _context.QuestoesAnonimas.Find(id);
            if (existingItem == null)
                return NotFound();

            // Update only non-null properties
            if (!string.IsNullOrEmpty(partialUpdate.Question))
                existingItem.Question = partialUpdate.Question;
            if (!string.IsNullOrEmpty(partialUpdate.Option1))
                existingItem.Option1 = partialUpdate.Option1;
            if (!string.IsNullOrEmpty(partialUpdate.Option2))
                existingItem.Option2 = partialUpdate.Option2;
            if (!string.IsNullOrEmpty(partialUpdate.Option3))
                existingItem.Option3 = partialUpdate.Option3;
            if (!string.IsNullOrEmpty(partialUpdate.Option4))
                existingItem.Option4 = partialUpdate.Option4;
            if (!string.IsNullOrEmpty(partialUpdate.Option5))
                existingItem.Option5 = partialUpdate.Option5;
            if (partialUpdate.CorrectAnswer != 0)
                existingItem.CorrectAnswer = partialUpdate.CorrectAnswer;

            _context.QuestoesAnonimas.Update(existingItem);
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/items/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteItem(Guid id)
        {
            var existingItem = _context.QuestoesAnonimas.Find(id);
            if (existingItem == null)
                return NotFound();

            _context.QuestoesAnonimas.Remove(existingItem);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
