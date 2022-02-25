using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Controllers
{
    public class StaffController : Controller
    {
        StaffMethod _staffMethod = new StaffMethod();
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
           
            try
            {
                var data = _staffMethod.GetStaff();
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

            List<Role> roleList = _staffMethod.GetRoles();
            ViewBag.RoleList=new SelectList(roleList, "RoleId", "RoleName");


            if (id == 0)
                return View(new Staff());
            else
                return View(_staffMethod.GetStaffById(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([Bind("StaffId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,Password,RoleId")] Staff staff)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            List<Role> roleList = _staffMethod.GetRoles();
            ViewBag.RoleList=new SelectList(roleList, "RoleId", "RoleName");

            if (ModelState.IsValid)
            {
                if (staff.StaffId == 0)
                {
                    int staffId = _staffMethod.AddStaff(staff.FirstName, staff.LastName, staff.Line1, staff.Line2, staff.DoB, staff.Sex, staff.NIC, staff.Email,staff.Password,staff.RoleId);

                   // _staffMethod.AddStaffMobile(staffId, staff.MobileNumber);

                   // if (staff.Telephone!=null)
                   // {
                      //  _staffMethod.AddStaffMobile(staffId, staff.Telephone);

                   // }
                    // ViewBag.Message = "Student Details Added Successfully";
                }
                else
                {
                    _staffMethod.EditStaff(staff.StaffId, staff.FirstName, staff.LastName, staff.Line1, staff.Line2, staff.DoB, staff.Sex, staff.NIC, staff.Email, staff.Password, staff.RoleId);

                }
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        public IActionResult Delete(int id)
        {
            _staffMethod.DeleteStaff(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}
