using Domain;
using MediatR;
using Persistence;

namespace Application.Scholarships;

public class Create
{
    public class Command: IRequest<Unit>
    {
        public Studentbasic Studentbasic { get; set; } = null!;
        public Studentdetail Studentdetail {get; set;} = null!;
        public List<Advising>? Advisings { get ; set; }
        public List<College>? Colleges { get ; set; }
        public List<Major>? Majors { get ; set; }
        public List<Minor>? Minors { get ; set; }
        public List<Question>? Questions { get ; set; }
        public List<string>? QuestionResponses { get ; set; }
        public List<Recommender>? Recommenders { get ; set; }
        public List<Result>? Results { get ; set; }
        public List<Scholarship>? Scholarships { get ; set; }
        public List<bool> SelectedScholarship { get; set; }
    }

    public class Handler : IRequestHandler<Command, Unit>
    {
        private readonly DataContext _context;
    
        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            // add Studentbasic entity
            var studentbasic = request.Studentbasic;
            studentbasic.StudentId = System.Guid.NewGuid().ToString();

            foreach (var (value, i) in request.SelectedScholarship.Select((value, i) => ( value, i )))
            {
                // Access `value` and `i` directly here.
                if (value){
                    var scholarship = await _context.Scholarships.FindAsync(i+1);
                    if (scholarship != null)
                    {
                        studentbasic.ScholarshipsSchols.Add(scholarship);
                    }
                }
            }
            await _context.Studentbasics.AddAsync(studentbasic, cancellationToken);       
            

            // add Studentdetail entity
            var studentdetail = request.Studentdetail; 
            studentdetail.DetailId = System.Guid.NewGuid().ToString();
            studentdetail.StudentbasicStudentId = studentbasic.StudentId;
            await _context.Studentdetails.AddAsync(studentdetail, cancellationToken);

            // Iterate over Advising collections
            if (request.Advisings != null) {
                foreach (var advising in request.Advisings) 
                {
                    advising.StudentbasicStudentId = studentbasic.StudentId; 
                    advising.PrepId = System.Guid.NewGuid().ToString();
                    _context.Advisings.Add(advising);
                }
            }
        
            // Iterate over College collections 
            if (request.Colleges != null) {
                foreach (var college in request.Colleges) 
                {
                    college.StudentbasicStudentId = studentbasic.StudentId; 
                    college.CollegeId = System.Guid.NewGuid().ToString();
                    _context.Colleges.Add(college);
                }
            }

            // Iterate over Major collections
            if (request.Majors != null) {
                foreach (var major in request.Majors) 
                {
                    major.StudentbasicStudentId = studentbasic.StudentId; 
                    major.MajorId = System.Guid.NewGuid().ToString();
                    _context.Majors.Add(major);
                }
            }

            // Iterate over Minor collections
            if (request.Minors != null) {
                foreach (var minor in request.Minors) 
                {
                    minor.StudentbasicStudentId = studentbasic.StudentId; 
                    minor.MinorId = System.Guid.NewGuid().ToString();
                    _context.Minors.Add(minor);
                }

            }

            // Iterate over QuestionResponse collections
            if (request.QuestionResponses != null)
            {
                int questionId = 1; 
                foreach (var responseText in request.QuestionResponses) 
                {
                    var questionResponse = new QuestionResponse
                    {
                        StudentbasicStudentId = studentbasic.StudentId,
                        QuestionsQuestionId = questionId++, 
                        ResponseText = responseText // Assign the string directly to ResponseText
                    };

                    _context.QuestionResponses.Add(questionResponse);
                }

                await _context.SaveChangesAsync(cancellationToken);
            }

            // Iterate over Recommender collections
            if (request.Recommenders != null) {
                foreach (var recommender in request.Recommenders) 
                {
                    recommender.StudentbasicStudentId = studentbasic.StudentId; 
                    recommender.RecomId = System.Guid.NewGuid().ToString();
                    _context.Recommenders.Add(recommender);
                }
            }

            // save all changes
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
