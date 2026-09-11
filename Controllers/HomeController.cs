using IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Mescallado_Judiel_Meguiel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Mescallado_Judiel_Meguiel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
