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
                course.CourseName = dt.Rows[0]["CourseName"].ToString();
                course.CourseCode = dt.Rows[0]["CourseCode"].ToString();
                course.Description =  dt.Rows[0]["Description"].ToString();
            }
            return course;
        }
        public void AddOrEditCourse(int courseId, string courseName, string courseCode, string description)
        {
            _courseDataAccess.AddOrEditCourse(courseId, courseName, courseCode, description);
        }

        public void DeleteCourse(int courseId)
        {
            _courseDataAccess.DeleteCourse(courseId);
        }
    }


}
