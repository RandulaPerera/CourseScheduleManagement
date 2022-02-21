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
        public IActionResult AddOrEdit([Bind("StudentId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,MobileNumber,Telephone,CourseId,BatchId")] Student student)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            if (ModelState.IsValid)
            {
                if (student.StudentId == 0)
                {
                    int studentId = _studentMethod.AddStudent(student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.CourseId, student.BatchId);

                    _studentMethod.AddStudentMobile(studentId, student.MobileNumber);

                    if (student.Telephone!=null)
                    {
                            _studentMethod.AddStudentMobile(studentId, student.Telephone);

                    }
                    // ViewBag.Message = "Student Details Added Successfully";
                }
                else {
                    _studentMethod.EditStudent(student.StudentId, student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.MobileNumber, student.Telephone, student.CourseId, student.BatchId);

                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        //public IActionResult Add()
        //{
        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Add(Student student)
        //{
        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            int studentId = _studentMethod.AddStudent(student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.CourseId, student.BatchId);

        //            _studentMethod.AddStudentMobile(studentId, student.MobileNumber);

        //            //if (student.Telephone!=0)
        //            //{
        //            //    _studentMethod.AddStudentMobile(studentId, student.Telephone);

        //            //}
        //            // ViewBag.Message = "Student Details Added Successfully";

        //        }
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //public IActionResult Edit(int id)
        //{
        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");


        //    Student student = new Student();
        //    student.StudentId= id;
        //    student = _studentMethod.GetStudentById(student.StudentId);

        //    _studentMethod.EditStudent(student.StudentId, student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.MobileNumber, student.Telephone, student.CourseId, student.BatchId);

        //    return View(student);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int id, [Bind("StudentId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,MobileNumber,Telephone,CourseId,BatchId")] Student student)
        //{
        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //    try
        //    {
        //        _studentMethod.EditStudent(student.StudentId, student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.MobileNumber, student.Telephone, student.CourseId, student.BatchId);

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        //public IActionResult Add(int id)
        //{

        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //    Student student = new Student();
        //    if (id > 0)
        //        student = _studentMethod.GetStudentById(id);
        //    return View(student);

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Add(int id, [Bind("StudentId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,MobileNumber,Telephone,CourseId,BatchId")] Student student)
        //{
        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //    if (ModelState.IsValid)
        //    {
        //        int studentId = _studentMethod.AddStudent(student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.CourseId, student.BatchId);

        //        _studentMethod.AddStudentMobile(studentId, student.MobileNumber);

        //        if (student.Telephone!=0)
        //        {
        //            _studentMethod.AddStudentMobile(studentId, student.Telephone);

        //        }
        //        ViewBag.Message = "Student Details Added Successfully"; return RedirectToAction(nameof(Index));
        //    }
        //    return View(student);
        //}

        //public IActionResult Edit(int id)
        //{
        //    Student student = new Student();
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            List<Course> courseList = _commonMethod.GetCourses();
        //            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //            if (id > 0)
        //                student = _studentMethod.GetStudentById(id);   
        //        }
        //        return View(student);

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
         

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int id, Student student)
        //{
        //    List<Course> courseList = _commonMethod.GetCourses();
        //    ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

        //    if (ModelState.IsValid)
        //    {
        //        _studentMethod.EditStudent(student.StudentId, student.FirstName, student.LastName, student.Line1, student.Line2, student.DoB, student.Sex, student.NIC, student.Email, student.MobileNumber, student.Telephone, student.CourseId, student.BatchId);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(student);
        //}

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
