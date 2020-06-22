using System.Threading;
using System.Threading.Tasks;
using BeerTracker.Application.Common.Exceptions;
using BeerTracker.Application.Common.Interfaces;
using BeerTracker.Domain.Entities;
using MediatR;

namespace BeerTracker.Application.BeerItems.Commands.Delete
{
    public class DeleteBeerItemCommand : IRequest
    {
        public int Id { get; set; }

        public class DeleteBeerItemCommandHandler : IRequestHandler<DeleteBeerItemCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteBeerItemCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }


            public async Task<Unit> Handle(DeleteBeerItemCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.BeerItems.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(BeerItem), request.Id);
                }

                _context.BeerItems.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }



    
}
