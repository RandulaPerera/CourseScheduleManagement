using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Controllers
{
    public class StudentController : Controller
    {
        StudentMethod _studentMethod = new StudentMethod();
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
           
            try
            {
                var data = _studentMethod.GetStudents();
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
            ViewBag.CourseList=new SelectList(courseList, "CourseId","Name");

            Student student = new Student();
            if (id > 0)
                student = _studentMethod.GetStudentById(id);
            return View(student);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, [Bind("StudentId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,Password,MobileNumber,Telephone,CourseId,BatchId")] Student student)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "Name");
 
            if (ModelState.IsValid)
            {
                _studentMethod.AddOrEditStudent(student.StudentId,student.FirstName,student.LastName,student.Line1,student.Line2,student.DoB,student.Sex,student.NIC,student.Email,student.Password,student.MobileNumber,student.Telephone,student.CourseId,student.BatchId);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            _studentMethod.DeleteStudent(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult GetBatchList(int courseId)
        {
            List<Batch> batchList = _commonMethod.GetBatchByCourseId(courseId);
            return Json(batchList);
        }
    }
}
