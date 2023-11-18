using MediatR;
using Domain;
using Persistence;
namespace Application.Advisings;

public class Detail
{
    public class Query : IRequest<Studentbasic>
    {
        public string PrepId  {get; set; }
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
            return await _context.Studentbasics.FindAsync(request.PrepId);
        }
    }

}
