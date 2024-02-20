using dotnet_agarson_webapp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonApp.Models;

namespace dotnet_agarson_webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pockemonRepository;
        public PokemonController(IPokemonRepository pockemonRepository)
        {
            _pockemonRepository= pockemonRepository;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(Enumerable<Pokemon>))];
        public IActionResult GetPokemons()
        {
            var pokemons = _pockemonRepository.GetPokemons();
            if(!ModelState.IsValid)
            
                return BadRequest(ModelState);
            return Ok(pokemons);
        }
    }
}
