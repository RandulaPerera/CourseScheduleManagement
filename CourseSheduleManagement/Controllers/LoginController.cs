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

                User user = _loginMethods.GetStudentDetailsByEmail(loginUser.Email);
                HttpContext.Session.SetString("Student", JsonConvert.SerializeObject(user));

                if (loginUser.Email==user.Email && loginUser.Password==user.Password)
                {
                    return RedirectToAction("Index", "StudentView");

                }
                else
                {
                    ViewBag.Message = string.Format("Wrong Email or Password");
                    return View();
                }

            }
            else if (loginUser.UserType =="Staff")
            {

                User user = _loginMethods.GetStaffDetailsByEmail(loginUser.Email);
                HttpContext.Session.SetString("Staff", JsonConvert.SerializeObject(user));
                if (user.RoleName == "Lecturer")
                {
                    if (loginUser.Email==user.Email && loginUser.Password==user.Password)
                    {
                        return RedirectToAction("Index", "LecturerView");

                    }
                    else
                    {
                        ViewBag.Message = string.Format("Wrong Email or Password");
                        return View();
                    }


                }
                else
                {
                    if (loginUser.Email==user.Email && loginUser.Password==user.Password)
                    {
                        return RedirectToAction("Index", "Admin");

                    }
                    else
                    {
                        ViewBag.Message = string.Format("Wrong Email or Password");
                        return View();
                    }


                }


            }
            else
            {
                ViewBag.Message = string.Format("Wrong Input");
                return View();

            }


            return View();
        }
    }
}
