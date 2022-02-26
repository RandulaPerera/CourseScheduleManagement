using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseSheduleManagement.Controllers
{
    public class LoginController : Controller
    {
        LoginMethods _loginMethods = new LoginMethods();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(User loginUser)
        {

            if (loginUser.UserType == "Student")
            {

                User user=_loginMethods.GetStudentDetailsByEmail(loginUser.Email);
               // Session["Student"] = user;
                return RedirectToAction("Index", "StudentView");

            }
            else if (loginUser.UserType =="Staff")
            {

                User user = _loginMethods.GetStaffDetailsByEmail(loginUser.Email);

                if (user.RoleName == "Lecturer")
                {
                    return RedirectToAction("Index", "LecturerView");

                }
                else
                {
                    return RedirectToAction("Index", "Admin");


                }


            }


            return View();
        }
    }
}
