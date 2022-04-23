using System;
using System.Collections.Generic;

namespace CharacterCreator.Models
{
    public partial class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Ability { get; set; } = null!;
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Support { get; set; }

        public virtual Team Team { get; set; } = null!;
    }
}
