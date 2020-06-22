using System.Threading;
using System.Threading.Tasks;
using BeerTracker.Application.Common.Interfaces;
using BeerTracker.Application.TodoItems.Commands.CreateTodoItem;
using BeerTracker.Domain.Entities;
using MediatR;

namespace BeerTracker.Application.BreweryItems.Commands.Create
{
    public class CreateBreweryItemCommand : IRequest<int>
    {
        public string Title { get; set; }
        public AddressItem Address { get; set; }

        public class CreateBreweryItemCommandHandler : IRequestHandler<CreateBreweryItemCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public CreateBreweryItemCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateBreweryItemCommand request, CancellationToken cancellationToken)
            {



                var entity = new BreweryItem
                {
                    Title = request.Title,
                    Address = request.Address
                    
                };

                _context.BreweryItems.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
