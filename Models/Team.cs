using System;
using System.Collections.Generic;

namespace CharacterCreator.Models
{
    public partial class Team
    {
        public int Id { get; set; }
        public string? TeamName { get; set; }
        public int? TeamSize { get; set; }
        public int? TeamRating { get; set; }

        public virtual Character IdNavigation { get; set; } = null!;
    }
}
