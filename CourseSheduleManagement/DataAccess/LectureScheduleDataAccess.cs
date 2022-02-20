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
            return RunProcedureQueryText("GetLectures", parameters).Tables[0];
        }

        public DataTable GetLectureById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id",id),
                    };
            return RunProcedureQueryText("GetLectureById", parameters).Tables[0];
        }

        public void AddOrEditLecture(int scheduleId, DateTime date, DateTime startTime, DateTime endTime, int hallId, int batchId, int moduleId, int lectureBy, string type)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ScheduleId",scheduleId),
            new SqlParameter("@Date",date),
            new SqlParameter("@StartTime",startTime),
            new SqlParameter("@EndTime",endTime),
            new SqlParameter("@HallId",hallId),
            new SqlParameter("@BatchId",batchId),
            new SqlParameter("@ModuleId",moduleId),
            new SqlParameter("@LectureBy",lectureBy),
            new SqlParameter("@Type",type)
            };
            RunProcedureQuery("AddorEditLecture", parameters);
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
