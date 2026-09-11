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
                }
            };

            return View(answers);
        }
    }
}