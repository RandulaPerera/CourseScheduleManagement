﻿using Microsoft.AspNetCore.Mvc;

namespace CourseSheduleManagement.Controllers
{
    public class StudentViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}