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
            };

            return View(answers);
        }
    }
}