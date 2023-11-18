using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Advisings;

public class List
{
    public class Query : IRequest<List<Advising>>{}
    public class Handler : IRequestHandler<Query, List<Advising>>
    {   
        private readonly Persistence.DataContext _context;
        public Handler(Persistence.DataContext context){
            _context = context;
        }
        public async Task<List<Advising>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Advisings.ToListAsync();
        }
    }
}