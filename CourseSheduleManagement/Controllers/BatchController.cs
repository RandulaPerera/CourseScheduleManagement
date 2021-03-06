using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Controllers
{
    public class BatchController : Controller
    {
        BatchMethod _batchMethod = new BatchMethod();
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
            try
            {
                var data = _batchMethod.GetBatches();
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
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName","CourseCode");

            Batch batch = new Batch();
            if (id > 0)
                batch = _batchMethod.GetBatchById(id);
            return View(batch);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, [Bind("BatchId,Year,CourseId,BatchCode")] Batch batch)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            if (ModelState.IsValid)
            {
                _batchMethod.AddOrEditBatch(batch.BatchId, batch.Year, batch.CourseId, batch.BatchCode);
                return RedirectToAction(nameof(Index));
            }
            return View(batch);
        }

        public IActionResult Delete(int id)
        {
            _batchMethod.DeleteBatch(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult GetBatchNo(int courseId, int year)
        {
            int batchNo = _batchMethod.GetBatchNo(courseId, year);
            return Json(batchNo);
        }
    }
}
