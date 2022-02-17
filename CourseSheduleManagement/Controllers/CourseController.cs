using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CourseSheduleManagement.Controllers
{
    public class CourseController : Controller
    {
        
        CourseMethod _courseMethod = new CourseMethod();
        
        public IActionResult Index()
        {
            try
            {   var data = _courseMethod.GetCourses();
                return View(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult AddOrEdit(int id)
        {
            Course course = new Course();
            if (id > 0)
                course = _courseMethod.GetCourseById(id);
            return View(course);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, [Bind("CourseId,Name,Code,Description")] Course course)
        {
            if (ModelState.IsValid)
            {
                _courseMethod.AddOrEditCourse(course.CourseId, course.Name, course.Code, course.Description);
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        public IActionResult Delete(int id)
        {
            _courseMethod.DeleteCourse(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
