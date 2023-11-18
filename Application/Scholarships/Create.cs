using Domain;
using MediatR;
using Persistence;

namespace Application.Scholarships;

public class Create
{
    public class Command: IRequest
    {
        public Studentbasic Studentbasic { get; set; }
        public Advising Advising { get ; set; }
        public Studentdetail Studentdetail {get; set;}

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
            await _context.Studentbasics.AddAsync(request.Studentbasic);
            await _context.SaveChangesAsync();
            await _context.Advisings.AddAsync(request.Advising);
            await _context.SaveChangesAsync();
            await _context.Studentdetails.AddAsync(request.Studentdetail);
            await _context.SaveChangesAsync();
 
            //add new handler
        }
    }
}
