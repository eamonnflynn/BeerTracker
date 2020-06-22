using BeerTracker.Application.Common.Interfaces;
using BeerTracker.Domain.Entities;
using BeerTracker.Domain.Enums;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BeerTracker.Application.BeerItems.Commands.Create
{
    public class CreateBeerItemCommand : IRequest<int>
    {
        public int BreweryId { get; set; }

        public string Title { get; set; }

        public decimal Abv { get; set; }

        public BeerStyle Style { get; set; }

        public class CreateBeerItemCommandHandler : IRequestHandler<CreateBeerItemCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public CreateBeerItemCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateBeerItemCommand request, CancellationToken cancellationToken)
            {
                var entity = new BeerItem
                {
                    BreweryId = request.BreweryId,
                    Title = request.Title,
                    Abv = request.Abv,
                    Style = request.Style
                  
                };

                await _context.BeerItems.AddAsync(entity,cancellationToken);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
