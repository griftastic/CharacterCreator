using CharacterCreator.Models;
using Microsoft.AspNetCore.Mvc;
using CharacterCreator.Data;

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
            Support = model.Defence
        };
        _context.Characters.Add(character);
        await _context.SaveChangesAsync();
        return Ok();
        }
    }
}