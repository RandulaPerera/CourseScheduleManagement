using System;
using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class LectureScheduleDataAccess :DataAccessBase
    {
        public DataTable GetLectures()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQuery("GetLectures", parameters).Tables[0];
        }

        public DataTable GetLectureById(int scheduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ScheduleId",scheduleId),
                    };
            return RunProcedureQuery("GetLectureById", parameters).Tables[0];
        }

        public int AddSchedule(DateTime date, DateTime startTime, DateTime endTime, int courseId, int hallId, int batchId, int moduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            
            new SqlParameter("@Date",date),
            new SqlParameter("@StartTime",startTime),
            new SqlParameter("@EndTime",endTime),
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@HallId",hallId),
            new SqlParameter("@BatchId",batchId),
            new SqlParameter("@ModuleId",moduleId)
            };
            return int.Parse(RunProcedureScalar("AddScheduleLecture", parameters).ToString());
        }

        public void AddLecture(int scheduleId,int staffId,string lectureType)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId),
            new SqlParameter("@StaffId",staffId),
            new SqlParameter("@LectureType",lectureType)
            };
            RunProcedureQuery("AddLecture", parameters);
        }

        public void EditSchedule(int scheduleId,DateTime date, DateTime startTime, DateTime endTime, int courseId, int hallId, int batchId, int moduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId),
            new SqlParameter("@Date",date),
            new SqlParameter("@StartTime",startTime),
            new SqlParameter("@EndTime",endTime),
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@HallId",hallId),
            new SqlParameter("@BatchId",batchId),
            new SqlParameter("@ModuleId",moduleId)
            };
            RunProcedureQuery("EditSchedule", parameters);
        }

        public void EditLecture(int scheduleId,int staffId, string lectureType)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId),
            new SqlParameter("@StaffId",staffId),
            new SqlParameter("@LectureType",lectureType)
            };
            RunProcedureQuery("EditLecture", parameters);
        }

        public void DeleteLecture(int scheduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId)

            };
            RunProcedureQuery("DeleteLecture", parameters);
        }

       
    }
}
