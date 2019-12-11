using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class Go
    {
        public int Id { get; set; }

        [Display(Name = "Pokemon")]
        public int PokemonsId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int Seen { get; set; }
        public int Caught { get; set; }
        public bool Lucky { get; set; }
        public bool Shiny { get; set; }
        public bool Shadow { get; set; }
    }
}
