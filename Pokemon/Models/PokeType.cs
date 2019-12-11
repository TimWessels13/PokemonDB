﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class PokeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ImageFileName { get; set; }

        public ICollection<PokemonType> PokemonType { get; set; }
    }
}
