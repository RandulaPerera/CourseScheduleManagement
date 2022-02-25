using Microsoft.AspNetCore.Mvc;

namespace CourseSheduleManagement.Controllers
{
    public class LecturerViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
