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
        public Lecture GetLectureById(int id)
        {
            Lecture lecture = new Lecture();
            DataTable dt = _lectureScheduleDataAccess.GetLectureById(id);
            if (dt.Rows.Count == 1)
            {
                lecture.ScheduleId =Convert.ToInt32(dt.Rows[0]["ScheduleId"].ToString());
                lecture.Date = Convert.ToDateTime(dt.Rows[0]["Date"].ToString());
                lecture.StartTime = Convert.ToDateTime(dt.Rows[0]["StartTime"].ToString());
                lecture.EndTime = Convert.ToDateTime(dt.Rows[0]["EndTime"].ToString());
                lecture.HallId = Convert.ToInt32(dt.Rows[0]["HallId"].ToString());
                lecture.BatchId = Convert.ToInt32(dt.Rows[0]["BatchId"].ToString());
                lecture.ModuleId = Convert.ToInt32(dt.Rows[0]["ModuleId"].ToString());
                lecture.LecturerBy = Convert.ToInt32(dt.Rows[0]["LecturerBy"].ToString());
                lecture.Type =  dt.Rows[0]["Type"].ToString();
            }
            return lecture;
        }
        public void AddOrEditLecture(int scheduleId, DateTime date, DateTime startTime,DateTime endTime, int hallId, int batchId,int moduleId,int lectureBy,string type)
        {
            _lectureScheduleDataAccess.AddOrEditLecture(scheduleId, date, startTime, endTime,hallId,batchId,moduleId,lectureBy,type);
        }

        public void DeleteLecture(int scheduleId)
        {
            _lectureScheduleDataAccess.DeleteLecture(scheduleId);
        }
    }
}
