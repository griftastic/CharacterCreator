using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreator
{
    public class CharacterCreatorDbContext : DbContext
    {
        public CharacterCreatorDbContext(DbContextOptions<CharacterCreatorDbContext> options) : base(options) {}
    }
}