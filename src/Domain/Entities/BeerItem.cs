using BeerTracker.Domain.Common;
using BeerTracker.Domain.Enums;

namespace BeerTracker.Domain.Entities
{
    public class BeerItem : AuditableEntity
    {
        public int Id { get; set; }

        public int BreweryId { get; set; }

        public string Title { get; set; }

        public decimal Abv { get; set; }

        public BeerStyle Style { get; set; }
    }
}
