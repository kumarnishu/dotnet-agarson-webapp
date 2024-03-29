﻿using PokemonApp.Data;
using PokemonApp.Models;

namespace dotnet_agarson_webapp.Repositories
{
    public class PokemonRepository:IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context=context;
            
        }
        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

    }
}
