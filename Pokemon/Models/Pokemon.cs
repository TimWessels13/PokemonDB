using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Display(Name = "#")]
        public int Number { get; set; }
        public string url { get; set; }
        public string Name { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int Generation { get; set; }

        [Display(Name = "Pokedex Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int HP { get; set; }
        public int Attack { get; set; }

        [Display(Name = "Sp. Attack")]
        public int Special_Attack { get; set; }
        public int Defense { get; set; }

        [Display(Name = "Sp. Defense")]
        public int Special_Defense { get; set; }
        public int Speed { get; set; }

        public ICollection<PokemonType> PokemonType { get; set; }
    }
}
