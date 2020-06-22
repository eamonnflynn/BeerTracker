using System.Threading;
using System.Threading.Tasks;
using BeerTracker.Application.Common.Exceptions;
using BeerTracker.Application.Common.Interfaces;
using BeerTracker.Domain.Entities;
using MediatR;

namespace BeerTracker.Application.BreweryItems.Commands.Delete
{
    public class DeleteBreweryItemCommand : IRequest
    {
        public int Id { get; set; }

        public class DeleteBreweryItemCommandHandler : IRequestHandler<DeleteBreweryItemCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteBreweryItemCommandHandler(IApplicationDbContext context)
            {

                _context = context;
            }


            public async Task<Unit> Handle(DeleteBreweryItemCommand request, CancellationToken cancellationToken)
            {
                 var entity = await _context.BreweryItems.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(BreweryItem), request.Id);
                }

                _context.BreweryItems.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
