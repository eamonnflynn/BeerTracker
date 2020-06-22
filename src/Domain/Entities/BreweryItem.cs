namespace BeerTracker.Domain.Entities
{
    public class BreweryItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public AddressItem Address { get; set; }
    }
}
