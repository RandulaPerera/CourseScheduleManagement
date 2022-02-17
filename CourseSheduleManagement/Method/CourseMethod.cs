using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class CourseMethod
    {
        CourseDataAccess _courseDataAccess = new CourseDataAccess();

        public DataTable GetCourses()
        {
            DataTable dt = _courseDataAccess.GetCourses();
           
            return dt;
        }
        public Course GetCourseById(int id)
        {
            Course course = new Course();
            DataTable dt = _courseDataAccess.GetCourseById(id);
            if (dt.Rows.Count == 1)
            {
                course.CourseId =Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
                course.Name = dt.Rows[0]["Name"].ToString();
                course.Code = dt.Rows[0]["Code"].ToString();
                course.Description =  dt.Rows[0]["Description"].ToString();
            }
            return course;
        }
        public void AddOrEditCourse(int courseId, string name, string code, string description)
        {
            _courseDataAccess.AddOrEditCourse(courseId,name,code,description);
        }

        public void DeleteCourse(int courseId)
        {
            _courseDataAccess.DeleteCourse(courseId);
        }
    }


}
