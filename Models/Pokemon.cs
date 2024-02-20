namespace PokemonApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Review> Reviews{get;set; }
        public ICollection<PockemonOwner> PockemonOwners{get;set;}
        public ICollection<PockemonCategory> PockemonCategories { get; set; }
    }
}

