using PokemonApp.Models;

namespace dotnet_agarson_webapp
{
    public interface IPokemonRepository
    {
        ICollection <Pokemon> GetPokemons { get; }
    }
}
                