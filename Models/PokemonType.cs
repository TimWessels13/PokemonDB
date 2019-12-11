using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class PokemonType
    {
        public int Id { get; set; }

        [Display(Name = "Pokemon")]
        public int PokemonsId { get; set; }
        public Pokemon Pokemon { get; set; }

        [Display(Name = "Type")]
        public int PokeTypeId { get; set; }
        public PokeType PokeType { get; set; }
    }
}
