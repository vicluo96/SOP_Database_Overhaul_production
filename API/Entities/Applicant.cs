namespace API.Entities;

public class Applicant
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
    //The entity type 'List<string>' requires a primary key to be defined. 
    //If you intended to use a keyless entity type, call 'HasNoKey' in 'OnModelCreating'. 
    //For more information on keyless entity types, see https://go.microsoft.com/fwlink/?linkid=2141943.
    
    // public List<string> CommonResponse { get; set; }

    // public List<string> Scholarships { get; set; }
    // public List<string> Response { get; set; }
}
