using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class GoView
    {
        public int Id { get; set; }
        public List<Go> Go { get; set; }
        public List<Pokemon> Pokemon { get; set; }
        public List<PokeType> PokeType { get; set; }
        public List<PokemonType> PokemonType { get; set; }
        public List<Gender> Gender { get; set; }
        public List<Color> Color { get; set; }
    }
}
