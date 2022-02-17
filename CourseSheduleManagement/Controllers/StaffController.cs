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

        public IActionResult AddOrEdit(int id)
        {

            List<Role> roleList = _staffMethod.GetRoles();
            ViewBag.RoleList=new SelectList(roleList, "RoleId","Name");

            Staff staff = new Staff();
            if (id > 0)
                staff = _staffMethod.GetStaffById(id);
            return View(staff);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, [Bind("StaffId,FirstName,LastName,Line1,Line2,DoB,Sex,NIC,Email,Password,MobileNumber,Telephone,RoleId")] Staff staff)
        {
            List<Role> roleList = _staffMethod.GetRoles();
            ViewBag.RoleList=new SelectList(roleList, "RoleId", "Name");

            if (ModelState.IsValid)
            {
                _staffMethod.AddOrEditStaff(staff.StaffId, staff.FirstName, staff.LastName, staff.Line1, staff.Line2, staff.DoB, staff.Sex, staff.NIC, staff.Email, staff.Password, staff.MobileNumber, staff.Telephone, staff.RoleId);
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
