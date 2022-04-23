using Microsoft.AspNetCore.Mvc;

namespace CharacterCreator.Controllers
{
    public class CharacterCreatorController
    {
        public class TheCharacterCreatorController: Controller
        {
            private CharacterCreatorDbContext _context;
            public TheCharacterCreatorController(CharacterCreatorDbContext context)
            {
                _context = context;
            }
        }
    }
}