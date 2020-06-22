using BeerTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BeerTracker.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
      

        DbSet<BeerItem> BeerItems { get; set; }
        DbSet<BreweryItem> BreweryItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
