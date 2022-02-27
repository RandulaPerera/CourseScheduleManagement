using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
                HttpContext.Session.SetString("Student",JsonConvert.SerializeObject(user));
                return RedirectToAction("Index", "StudentView");

            }
            else if (loginUser.UserType =="Staff")
            {

                User user = _loginMethods.GetStaffDetailsByEmail(loginUser.Email);
                HttpContext.Session.SetString("Staff", JsonConvert.SerializeObject(user));
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
