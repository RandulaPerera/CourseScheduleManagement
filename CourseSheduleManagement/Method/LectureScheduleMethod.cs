using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class LectureScheduleMethod
    {
        LectureScheduleDataAccess _lectureScheduleDataAccess = new LectureScheduleDataAccess();

        public DataTable GetLectures()
        {
            DataTable dt = _lectureScheduleDataAccess.GetLectures();

            return dt;
        }
        public Lecture GetLectureById(int scheduleId)
        {
            Lecture lecture = new Lecture();
            DataTable dt = _lectureScheduleDataAccess.GetLectureById(scheduleId);
            if (dt.Rows.Count == 1)
            {
                lecture.ScheduleId =Convert.ToInt32(dt.Rows[0]["ScheduleId"].ToString());
                lecture.Date = Convert.ToDateTime(dt.Rows[0]["Date"].ToString());
                lecture.StartTime = Convert.ToDateTime(dt.Rows[0]["StartTime"].ToString());
                lecture.EndTime = Convert.ToDateTime(dt.Rows[0]["EndTime"].ToString());
                lecture.CourseId = Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
                lecture.HallId = Convert.ToInt32(dt.Rows[0]["HallId"].ToString());
                lecture.BatchId = Convert.ToInt32(dt.Rows[0]["BatchId"].ToString());
                lecture.ModuleId = Convert.ToInt32(dt.Rows[0]["ModuleId"].ToString());
                lecture.StaffId = Convert.ToInt32(dt.Rows[0]["StaffId"].ToString());
                lecture.LectureType =  dt.Rows[0]["LectureType"].ToString();
            }
            return lecture;
        }
        public int AddSchedule(DateTime date, DateTime startTime,DateTime endTime,int courseId, int hallId, int batchId,int moduleId)
        {
            return _lectureScheduleDataAccess.AddSchedule(date, startTime, endTime, courseId,hallId, batchId,moduleId);
        }

        public void AddLecture(int scheduleId, int staffId, string lectureType)
        {
            _lectureScheduleDataAccess.AddLecture(scheduleId, staffId, lectureType);
        }

        public void EditSchedule(int scheduleId, DateTime date, DateTime startTime, DateTime endTime, int hallId, int courseId, int batchId, int moduleId )
        {
            _lectureScheduleDataAccess.EditSchedule(scheduleId, date, startTime, endTime, hallId,courseId, batchId, moduleId);
        }

        public void EditLecture(int scheduleId, int staffId, string lectureType)
        {
            _lectureScheduleDataAccess.EditLecture(scheduleId, staffId, lectureType);
        }
        public void DeleteLecture(int scheduleId)
        {
            _lectureScheduleDataAccess.DeleteLecture(scheduleId);
        }
    }
}
