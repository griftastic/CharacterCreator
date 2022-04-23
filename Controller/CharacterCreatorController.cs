using CharacterCreator.Models;
using Microsoft.AspNetCore.Mvc;
using CharacterCreator.Data;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterCreatorController : Controller
    {
        private CharacterCreatorContext _context;
        public CharacterCreatorController(CharacterCreatorContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCharacter([FromForm] CharacterEdit model)
    {
        Character character = new Character() {
            Name = model.Name,
            Ability = model.Ability,
            Attack = model.Attack,
            Defence = model.Defence,
            Support = model.Support
        };
        _context.Characters.Add(character);
        await _context.SaveChangesAsync();
        return Ok();
        }
        
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCharacter([FromRoute] int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if( character == null)
            {
                return NotFound();
            }
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return Ok();
        }
        
    [HttpGet]
    public async Task<IActionResult> GetCharacters()
    {
        var character = await _context.Characters.ToListAsync();
        return Ok(character);
    }
    }
}