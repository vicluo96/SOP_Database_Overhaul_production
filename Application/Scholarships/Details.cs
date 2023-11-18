using MediatR;
using Domain;
using Persistence;

namespace Application.Scholarships;

public class Details
{
    public class Query : IRequest<Studentbasic>
    {
        public String StudentId {get; set; }
    }

    public class Handler : IRequestHandler<Query, Studentbasic>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Studentbasic> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Studentbasics.FindAsync(request.StudentId);
        }
    }
}
