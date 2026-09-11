using IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Mescallado_Judiel_Meguiel.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Mescallado_Judiel_Meguiel.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var answers = new List<ExamItem>
            {
                new ExamItem
                {
                    Number = 1,
                    Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                    OptionA = "A. It makes C# code shorter",
                    OptionB = "B. It prevents the application from restarting",
                    OptionC = "C. It allows data to persist after the application stops",
                    OptionD = "D. It removes the need for MVC",
                    CorrectAnswer = "C",
                    Explanation = "Database data remains even when app closes; in-memory data is lost."
                },
                  new ExamItem
                {
                    Number = 2,
                    Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    OptionA = "A. Code-First",
                    OptionB = "B. Database-First",
                    OptionC = "C. Model-First",
                    OptionD = "D. Controller-First",
                    CorrectAnswer = "B",
                    Explanation = "Database-First approach generates entity classes from an existing database."
                },
                   new ExamItem
                {
                    Number = 3,
                    Question = "What is the primary purpose of Entity Framework Core?",
                    OptionA = "A. To create HTML pages automatically",
                    OptionB = "B. To replace the MVC Controller",
                    OptionC = "C. To map objects in code to relational database data",
                    OptionD = "D. To replace the C# compiler",
                    CorrectAnswer = "C",
                    Explanation = "EF Core is an Object-Relational Mapper that maps C# objects to database tables."
                },
                   new ExamItem
                {
                    Number = 4,
                    Question = "Which EF Core component is primarily responsible for communicating with the database?",
                    OptionA = "A. DbContext",
                    OptionB = "B. DbSetView",
                    OptionC = "C. ControllerContext",
                    OptionD = "D. RazorContext",
                    CorrectAnswer = "A",
                    Explanation = "DbContext manages database connections, entity tracking, and queries."
                },
                   new ExamItem
                {
                    Number = 5,
                    Question = "What does the following command primarily do? dotnet ef dbcontext scaffold",
                    OptionA = "A. Deletes the database",
                    OptionB = "B. Creates a new MVC project",
                    OptionC = "C. Generates EF Core models and a DbContext from an existing database",
                    OptionD = "D. Starts the MVC application",
                    CorrectAnswer = "C",
                    Explanation = "The scaffold command reverse-engineers an existing database into entity classes and DbContext."
                },
                   new ExamItem
                {
                    Number = 6,
                    Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    OptionA = "A. Program.cs only",
                    OptionB = "B. appsettings.json",
                    OptionC = "C. Index.cshtml",
                    OptionD = "D. Student.cs",
                    CorrectAnswer = "B",
                    Explanation = "Application configuration such as connection strings is stored in appsettings.json."
                },
                   new ExamItem
                {
                    Number = 7,
                    Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    OptionA = "A. One-to-One",
                    OptionB = "B. One-to-Many",
                    OptionC = "C. Many-to-Many",
                    OptionD = "D. Many-to-One only",
                    CorrectAnswer = "B",
                    Explanation = "One Section can have many Students = One-to-Many relationship."
                },
                   new ExamItem
                {
                    Number = 8,
                    Question = "In the following example, what is SectionId? public int SectionId { get; set; }",
                    OptionA = "A. Primary key of Student",
                    OptionB = "B. Foreign key referencing Section",
                    OptionC = "C. Navigation property",
                    OptionD = "D. Database connection string",
                    CorrectAnswer = "B",
                    Explanation = "SectionId stores the Primary Key of the linked Section = Foreign Key."
                },
                   new ExamItem
                {
                    Number = 9,
                    Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    OptionA = "A. It stores the database password",
                    OptionB = "B. It represents a relationship to another entity",
                    OptionC = "C. It creates a new database",
                    OptionD = "D. It validates the student's name",
                    CorrectAnswer = "B",
                    Explanation = "Navigation properties allow traversing relationships between entities."
                },
                   new ExamItem
                {
                    Number = 10,
                    Question = "What does .Include() generally allow EF Core to do?",
                    OptionA = "A. Delete the Section table",
                    OptionB = "B. Load related Section data together with Students",
                    OptionC = "C. Create a new Student",
                    OptionD = "D. Validate Student input",
                    CorrectAnswer = "B",
                    Explanation = ".Include() performs eager loading — fetches related data along with the main entity."
                },
                   new ExamItem
                {
                    Number = 11,
                    Question = "Why might a ViewModel be used when displaying Student and Section information?",
                    OptionA = "A. To replace the database",
                    OptionB = "B. To combine or shape the data specifically needed by the view",
                    OptionC = "C. To automatically create database tables",
                    OptionD = "D. To prevent controllers from using LINQ",
                    CorrectAnswer = "B",
                    Explanation = "ViewModel combines and shapes data exactly as required by the View."
                },
                   new ExamItem
                {
                    Number = 12,
                    Question = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); Main benefit of Include()?",
                    OptionA = "A. It loads the related Section navigation property",
                    OptionB = "B. It creates a Section object manually",
                    OptionC = "C. It removes the foreign key",
                    OptionD = "D. It prevents the query from accessing the database",
                    CorrectAnswer = "A",
                    Explanation = "Include() loads the related navigation property along with the main entity in a single query."
                },
                  new ExamItem
                {
                    Number = 13,
                    Question = "Which type of validation occurs in the browser before a request is sent to the server?",
                    OptionA = "A. Database-level validation",
                    OptionB = "B. Client-side validation",
                    OptionC = "C. Server-side validation",
                    OptionD = "D. EF Core migration validation",
                    CorrectAnswer = "B",
                    Explanation = "Client-side validation runs in the user's browser before data is submitted."
                },
                   new ExamItem
                {
                    Number = 14,
                    Question = "Why is server-side validation still necessary if client-side validation exists?",
                    OptionA = "A. Client-side validation can be bypassed",
                    OptionB = "B. Client-side validation automatically modifies the database",
                    OptionC = "C. Server-side validation only works with SQLite",
                    OptionD = "D. Client-side validation cannot display messages",
                    CorrectAnswer = "A",
                    Explanation = "Client-side validation can be disabled or bypassed by the user — server-side is the final safeguard."
                },
                  new ExamItem
                {
                    Number = 15,
                    Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    OptionA = "A. Student Number should always be nullable",
                    OptionB = "B. Student Number should be unique",
                    OptionC = "C. Student Number should always be the same",
                    OptionD = "D. Student Number should contain only spaces",
                    CorrectAnswer = "B",
                    Explanation = "Business rule mandates that no two students may share the same Student Number."
                },
                  new ExamItem
                {
                    Number = 16,
                    Question = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                    OptionA = "A. It protects data integrity even if application-level validation is bypassed",
                    OptionB = "B. It makes Razor Views render faster",
                    OptionC = "C. It removes the need for a Controller",
                    OptionD = "D. It automatically creates a ViewModel",
                    CorrectAnswer = "A",
                    Explanation = "Database-level constraints are enforced regardless of application validation — they cannot be bypassed."
                },
                  new ExamItem
                {
                    Number = 17,
                    Question = "What is the purpose of a try...catch block in a controller?",
                    OptionA = "A. To create navigation properties",
                    OptionB = "B. To catch and handle exceptions that may occur during execution",
                    OptionC = "C. To generate database tables",
                    OptionD = "D. To perform client-side validation",
                    CorrectAnswer = "B",
                    Explanation = "try...catch prevents the application from crashing by handling errors gracefully."
                },
                   new ExamItem
                {
                    Number = 18,
                    Question = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                    OptionA = "A. UseDatabase()",
                    OptionB = "B. UseExceptionHandler()",
                    OptionC = "C. UseValidationHandler()",
                    OptionD = "D. UseMvcDatabase()",
                    CorrectAnswer = "B",
                    Explanation = "UseExceptionHandler() catches unhandled exceptions centrally and redirects to an error page."
                },
                   new ExamItem
                {
                    Number = 19,
                    Question = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                    OptionA = "A. Display the student's information anyway",
                    OptionB = "B. Display a Not Found (404) response/page",
                    OptionC = "C. Delete Student 999",
                    OptionD = "D. Create Student 999 automatically",
                    CorrectAnswer = "B",
                    Explanation = "Standard HTTP response — return 404 when the requested resource does not exist."
                },
                   new ExamItem
                {
                    Number = 20,
                    Question = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                    OptionA = "A. Data integrity",
                    OptionB = "B. HTML formatting",
                    OptionC = "C. CSS inheritance",
                    OptionD = "D. Razor syntax",
                    CorrectAnswer = "A",
                    Explanation = "Preventing duplicate or redundant entries preserves data integrity within the system."
                }
            };

            return View(answers);
        }
    }
}