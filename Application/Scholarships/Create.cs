using Domain;
using MediatR;
using Persistence;

namespace Application.Scholarships;

public class Create
{
    public class Command: IRequest<Unit>
    {
        public Studentbasic Studentbasic { get; set; } = null!;
        public List<Advising> Advisings { get ; set; } = null!;
        public Studentdetail Studentdetail {get; set;} = null!;

    }

    public class Handler : IRequestHandler<Command, Unit>
    {
        private readonly DataContext _context;
    
        public Handler(DataContext context)
        {
            _context = context;
        }

        // public async Task Handle(Command request, CancellationToken cancellationToken)
        // {
        //     await _context.Studentbasics.AddAsync(request.Studentbasic);
        //     await _context.SaveChangesAsync();
 
        //     //add new handler
        // }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
    {
        // add Studentbasic entity
        var studentbasic = request.Studentbasic;
        await _context.Studentbasics.AddAsync(studentbasic, cancellationToken);

        // Iterate over Advising collections
        foreach (var advising in request.Advisings) 
        {
            advising.StudentbasicStudentId = studentbasic.StudentId; 
            _context.Advisings.Add(advising);
        }

        // save all changes
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
    }
}
