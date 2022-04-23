using System;
using System.Collections.Generic;

namespace CharacterCreator.Models
{
    public partial class Ability
    {
        public int AbilityId { get; set; }
        public string AbilityName { get; set; } = null!;
        public int AbilityRating { get; set; }
    }
}
