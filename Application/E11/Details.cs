using MediatR;
using Domain;
using Persistence;

namespace Application.E11;

public class Details
{
    public class Query : IRequest<Studentbasic>
    {
        public String StudentId {get; set;} = null!;
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
            var studentbasic = await _context.Studentbasics.FindAsync(request.StudentId);
            if (studentbasic == null)
            {
                throw new KeyNotFoundException("Could not find student");
            }
            return studentbasic;
        }
    }
}
