using System;
using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class ExamScheduleDataAccess :DataAccessBase
    {
        public DataTable GetExams()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQuery("GetExams", parameters).Tables[0];
        }

        public DataTable GetExamById(int scheduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ScheduleId",scheduleId),
                    };
            return RunProcedureQuery("GetExamById", parameters).Tables[0];
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
            return int.Parse(RunProcedureScalar("AddScheduleExam", parameters).ToString());
        }

        public void AddExam(int scheduleId,int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId),
            new SqlParameter("@StaffId",staffId)
            };
            RunProcedureQuery("AddExam", parameters);
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

        public void EditExam(int scheduleId,int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId),
            new SqlParameter("@StaffId",staffId)
            };
            RunProcedureQuery("EditExam", parameters);
        }

        public void DeleteExam(int scheduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId)

            };
            RunProcedureQuery("DeleteSchedule", parameters);
        }
    }
}
