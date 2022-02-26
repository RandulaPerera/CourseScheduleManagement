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
                course.CourseName = dt.Rows[i]["CourseName"].ToString();
                course.CourseCode = dt.Rows[i]["CourseCode"].ToString();
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
                batch.BatchCode = dt.Rows[i]["BatchCode"].ToString();
                list.Add(batch);
            }
            return list;
        }

        public List<Hall> GetHalls()
        {
            DataTable dt = _commonDataAccess.GetHalls();
            var list = new List<Hall>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Hall hall = new Hall();
                hall.HallId = Convert.ToInt32(dt.Rows[i]["HallId"]);
                hall.HallName = dt.Rows[i]["HallName"].ToString();
                list.Add(hall);
            }
            return list;
        }

        public List<Module> GetModules()
        {
            DataTable dt = _commonDataAccess.GetModules();
            var list = new List<Module>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Module module = new Module();
                module.ModuleId = Convert.ToInt32(dt.Rows[i]["ModuleId"]);
                module.ModuleName = dt.Rows[i]["ModuleName"].ToString();
                list.Add(module);
            }
            return list;
        }

        public List<Staff> GetStaff()
        {
            DataTable dt = _commonDataAccess.GetStaff();
            var list = new List<Staff>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Staff staff = new Staff();
                staff.StaffId = Convert.ToInt32(dt.Rows[i]["StaffId"]);
                staff.FullName = dt.Rows[i]["FullName"].ToString();
                list.Add(staff);
            }
            return list;
        }

        public List<Lecture> SearchByDate(DateTime date)
        {
            DataTable dt = _commonDataAccess.SearchByDate(date);
            var list = new List<Lecture>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Lecture lecture = new Lecture();
                lecture.ScheduleId =Convert.ToInt32(dt.Rows[0]["ScheduleId"].ToString());
                lecture.Date = Convert.ToDateTime(dt.Rows[0]["Date"].ToString());
                lecture.StartTime = Convert.ToDateTime(dt.Rows[0]["StartTime"].ToString());
                lecture.EndTime = Convert.ToDateTime(dt.Rows[0]["EndTime"].ToString());
                lecture.CourseName = dt.Rows[0]["CourseName"].ToString();
                lecture.HallName = dt.Rows[0]["HallName"].ToString();
                lecture.BatchCode = dt.Rows[0]["BatchCode"].ToString();
                lecture.ModuleName = dt.Rows[0]["ModuleName"].ToString();
                lecture.LecturerName = dt.Rows[0]["LecturerName"].ToString();
                lecture.LectureType =  dt.Rows[0]["LectureType"].ToString();
                list.Add(lecture);
            }
            return list;

            
        }
    }
}
