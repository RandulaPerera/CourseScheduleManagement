using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Library;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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

        public List<Lecture> SearchLecturesByDate(DateTime date)
        {
            DataTable dt = _commonDataAccess.SearchLecturesByDate(date);

            var list = (from dr in dt.AsEnumerable()
                        select new Lecture()
                        {
                            ScheduleId = dr.GetValue<int>("ScheduleId"),
                            RetrieveDate = dr.GetValue<string>("Date"),
                            RetrieveStartTime = dr.GetValue<string>("StartTime"),
                            RetrieveEndTime = dr.GetValue<string>("EndTime"),
                            CourseName = dr.GetValue<string>("CourseName"),
                            HallName = dr.GetValue<string>("HallName"),
                            BatchCode = dr.GetValue<string>("BatchCode"),
                            ModuleName = dr.GetValue<string>("ModuleName"),
                            LecturerName = dr.GetValue<string>("LecturerName"),
                            LectureType = dr.GetValue<string>("LectureType")
                        }).ToList();

            return list;

        }

        public List<Exam> SearchExamsByDate(DateTime date)
        {
            DataTable dt = _commonDataAccess.SearchExamsByDate(date);

            var list = (from dr in dt.AsEnumerable()
                        select new Exam()
                        {
                            ScheduleId = dr.GetValue<int>("ScheduleId"),
                            RetrieveDate = dr.GetValue<string>("Date"),
                            RetrieveStartTime = dr.GetValue<string>("StartTime"),
                            RetrieveEndTime = dr.GetValue<string>("EndTime"),
                            CourseName = dr.GetValue<string>("CourseName"),
                            HallName = dr.GetValue<string>("HallName"),
                            BatchCode = dr.GetValue<string>("BatchCode"),
                            ModuleName = dr.GetValue<string>("ModuleName"),
                            LecturerName = dr.GetValue<string>("LecturerName")
                        }).ToList();

            return list;

        }

        public void AddContactNumber(int userId, int contactNumber,string userType)
        {
            _commonDataAccess.AddContactNumber(userId, contactNumber,userType);
        }

        public void UpdateContactNumber(int contactId,int userId, int contactNumber, string userType)
        {
            _commonDataAccess.UpdateContactNumber(contactId,userId, contactNumber, userType);
        }


    }
}
