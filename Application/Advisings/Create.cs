using Domain;
using MediatR;
using Persistence;
namespace Application.Advisings;

public class Create
{
    public class Command: IRequest
    {
        public Advising Advising { get ; set; }
    }
    
    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            await _context.Advisings.AddAsync(request.Advising);
            await _context.SaveChangesAsync();
        }

    }
}
