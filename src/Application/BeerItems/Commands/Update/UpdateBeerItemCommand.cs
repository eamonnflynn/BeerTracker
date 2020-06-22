using BeerTracker.Application.Common.Exceptions;
using BeerTracker.Application.Common.Interfaces;
using BeerTracker.Domain.Entities;
using BeerTracker.Domain.Enums;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BeerTracker.Application.BeerItems.Commands.Update
{
    public class UpdateBeerItemCommand : IRequest
    {
        public int Id { get; set; }

        public int BreweryId { get; set; }

        public string Title { get; set; }

        public decimal Abv { get; set; }

        public BeerStyle Style { get; set; }

        public class UpdateBeerItemCommandHandler : IRequestHandler<UpdateBeerItemCommand>
        {
            
            private readonly IApplicationDbContext _context;

            public UpdateBeerItemCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateBeerItemCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.BeerItems.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(TodoItem), request.Id);
                }

                entity.Title = request.Title;
                entity.BreweryId = request.BreweryId;
                entity.Abv = request.Abv;
                entity.Style = request.Style;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
