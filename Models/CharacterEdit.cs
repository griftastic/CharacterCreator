using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class CharacterEdit
    {
        public string Name { get; set; } = null!;
        public string Ability { get; set; } = null!;
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Support { get; set; }

    }
}