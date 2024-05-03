using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolment.Controllers
{
    public class DepartmentCoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
