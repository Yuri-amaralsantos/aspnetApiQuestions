using Microsoft.AspNetCore.Mvc;
using question_api.Interfaces;

namespace question_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestoesAnomController : ControllerBase
    {
        private readonly IQuestionServices _questionServices;

        public QuestoesAnomController(IQuestionServices questionServices)
        {
            _questionServices = questionServices;
        }

        // GET: api/items
        [HttpGet]
        public async  Task<IActionResult> GetItems()
        {
            var questions = await _questionServices.GetRandomQuestionsAsync();

            return Ok(questions);
        }





        //Comentei todos os outros metodos para não dar conflito e focar no GET, se for trabalhar nos outros metodos pode descomentar.

        // Eu tirei o context daqui, eu acho melhor acessar o banco a partir dos Services, no caso a classe QuestionService. Se precisar trabalhar nos outros
        //metodos, move a lógica de acesso a dados pra lá pros services e cria um metodo pra eles, assim como fiz com o GET.









        /*



        // POST: api/items
        [HttpPost]
        public IActionResult AddItem([FromBody] Question newItem)
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
        public IActionResult UpdateItem(Guid id, [FromBody] Question updatedItem)
        {
            if (id != updatedItem.Id)
                return BadRequest("ID mismatch.");

            var existingItem = _context.QuestoesAnonimas.Find(id);
            if (existingItem == null)
                return NotFound();

            // Update the item's properties
            existingItem.Prompt = updatedItem.Prompt;
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
        public IActionResult PartialUpdateItem(Guid id, [FromBody] Question partialUpdate)
        {
            var existingItem = _context.QuestoesAnonimas.Find(id);
            if (existingItem == null)
                return NotFound();

            // Update only non-null properties
            if (!string.IsNullOrEmpty(partialUpdate.Prompt))
                existingItem.Prompt = partialUpdate.Prompt;
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



        */
    }
}
