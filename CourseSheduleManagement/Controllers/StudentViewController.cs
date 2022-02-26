using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CourseSheduleManagement.Controllers
{
    public class StudentViewController : Controller
    {
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
            
                return View();

        }

        [HttpGet]
        public IActionResult SearchByDate(DateTime date)
        {

            try
            {
                var data = _commonMethod.SearchByDate(date);
                return View(data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
