using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class CommonMethod
    {
        CommonDataAccess _commonDataAccess = new CommonDataAccess();

        public List<Course> GetCourses()
        {
            DataTable dt = _commonDataAccess.GetCourses();
            var list = new List<Course>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Course course = new Course();
                course.CourseId = Convert.ToInt32(dt.Rows[i]["CourseId"]);
                course.Name = dt.Rows[i]["Name"].ToString();
                list.Add(course);
            }
            return list;
        }

        public List<Batch> GetBatchByCourseId(int courseId)
        {
            DataTable dt = _commonDataAccess.GetBatchByCourseId(courseId);
            var list = new List<Batch>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Batch batch = new Batch();
                batch.BatchId = Convert.ToInt32(dt.Rows[i]["BatchId"]);
                batch.Code = dt.Rows[i]["Code"].ToString();
                list.Add(batch);
            }
            return list;
        }
    }
}
