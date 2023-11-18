using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Scholarships;

public class List
{
    public class Query : IRequest<List<Studentbasic>>{}
    public class Handler : IRequestHandler<Query, List<Studentbasic>>
    {   
        private readonly Persistence.DataContext _context;
        public Handler(Persistence.DataContext context){
            _context = context;
        }
        public async Task<List<Studentbasic>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Studentbasics.ToListAsync();
        }
    }
}
