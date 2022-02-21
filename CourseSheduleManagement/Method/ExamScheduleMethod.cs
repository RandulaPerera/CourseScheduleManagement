using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class ExamScheduleMethod
    {
        ExamScheduleDataAccess _examScheduleDataAccess = new ExamScheduleDataAccess();

        public DataTable GetExams()
        {
            DataTable dt = _examScheduleDataAccess.GetExams();

            return dt;
        }
        public Exam GetExamById(int scheduleId)
        {
            Exam exam = new Exam();
            DataTable dt = _examScheduleDataAccess.GetExamById(scheduleId);
            if (dt.Rows.Count == 1)
            {
                exam.ScheduleId =Convert.ToInt32(dt.Rows[0]["ScheduleId"].ToString());
                exam.Date = Convert.ToDateTime(dt.Rows[0]["Date"].ToString());
                exam.StartTime = Convert.ToDateTime(dt.Rows[0]["StartTime"].ToString());
                exam.EndTime = Convert.ToDateTime(dt.Rows[0]["EndTime"].ToString());
                exam.CourseId = Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
                exam.HallId = Convert.ToInt32(dt.Rows[0]["HallId"].ToString());
                exam.BatchId = Convert.ToInt32(dt.Rows[0]["BatchId"].ToString());
                exam.ModuleId = Convert.ToInt32(dt.Rows[0]["ModuleId"].ToString());
                exam.StaffId = Convert.ToInt32(dt.Rows[0]["StaffId"].ToString());
            }
            return exam;
        }
        public int AddSchedule(DateTime date, DateTime startTime,DateTime endTime,int courseId, int hallId, int batchId,int moduleId)
        {
            return _examScheduleDataAccess.AddSchedule(date, startTime, endTime, courseId,hallId, batchId,moduleId);
        }

        public void AddExam(int scheduleId, int staffId)
        {
            _examScheduleDataAccess.AddExam(scheduleId, staffId);
        }

        public void EditSchedule(int scheduleId, DateTime date, DateTime startTime, DateTime endTime, int hallId, int courseId, int batchId, int moduleId )
        {
            _examScheduleDataAccess.EditSchedule(scheduleId, date, startTime, endTime, hallId,courseId, batchId, moduleId);
        }

        public void EditExam(int scheduleId, int staffId)
        {
            _examScheduleDataAccess.EditExam(scheduleId, staffId);
        }
        public void DeleteExam(int scheduleId)
        {
            _examScheduleDataAccess.DeleteExam(scheduleId);
        }
    }
}
