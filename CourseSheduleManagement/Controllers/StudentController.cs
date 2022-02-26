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

        public IActionResult AddOrEdit(int id = 0)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");


            if (id == 0)
                return View(new Student());
            else
                return View(_studentMethod.GetStudentById(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([Bind("StudentId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,Password,CourseId,BatchId,Contacts")] Student student)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            if (ModelState.IsValid)
            {
                if (student.StudentId == 0)
                {
                    int studentId = _studentMethod.AddStudent(student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email,student.Password, student.CourseId, student.BatchId);

                    string usertype = "Student";
                    for (int i = 0; i<student.Contacts.Count; i++)
                    {
                        _commonMethod.AddContactNumber(studentId, student.Contacts[i].ContactNumber, usertype);
                    }



                }
                else {
                    _studentMethod.EditStudent(student.StudentId, student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email,student.Password, student.CourseId, student.BatchId);

                    string usertype = "Student";
                    for (int i = 0; i<student.Contacts.Count; i++)
                    {
                        _commonMethod.UpdateContactNumber(student.Contacts[i].ContactId, student.StudentId, student.Contacts[i].ContactNumber,usertype);

                    }
                }
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
