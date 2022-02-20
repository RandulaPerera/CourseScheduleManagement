using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CourseSheduleManagement.Controllers
{
    public class ModuleController : Controller
    {

        ModuleMethod _moduleMethod = new ModuleMethod();
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
            try
            {   var data = _moduleMethod.GetModules();
                return View(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult AddOrEdit(int id)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            Module module = new Module();
            if (id > 0)
                module = _moduleMethod.GetModuleById(id);
            return View(module);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, [Bind("ModuleId,ModuleName,Description,CourseId")] Module module)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            if (ModelState.IsValid)
            {
                _moduleMethod.AddOrEditModule(module.ModuleId, module.ModuleName, module.Description, module.CourseId);
                return RedirectToAction(nameof(Index));
            }
            return View(module);
        }

        public IActionResult Delete(int id)
        {
            _moduleMethod.DeleteModule(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
