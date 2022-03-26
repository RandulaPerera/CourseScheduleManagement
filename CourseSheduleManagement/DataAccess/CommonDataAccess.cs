using System;
using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class CommonDataAccess : DataAccessBase
    {
        public DataTable GetCourses()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("select * from Course where Active=1", parameters).Tables[0];
        }

        public DataTable GetBatchByCourseId(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id",id),
                    };
            return RunProcedureQueryText("select * from Batch where CourseId=@Id", parameters).Tables[0];
        }

        public DataTable GetHalls()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("select * from Hall where Active=1", parameters).Tables[0];
        }

        public DataTable GetModules()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("select * from Module where Active=1", parameters).Tables[0];
        }

        public DataTable GetStaff()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQuery("GetLecturerStaff", parameters).Tables[0];
        }

        public DataTable SearchLecturesByDate(DateTime date,int courseId,int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Date",date),
                        new SqlParameter("@CourseId",courseId),
                        new SqlParameter("@BatchId",batchId)
                    };
            return RunProcedureQuery("SearchLecturesByDate", parameters).Tables[0];
        }

        public DataTable SearchExamsByModule(int moduleId, int courseId,int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ModuleId",moduleId),
                        new SqlParameter("@CourseId",courseId),
                        new SqlParameter("@BatchId",batchId)
                    };
            return RunProcedureQuery("SearchExamsByModule", parameters).Tables[0];
        }

        public DataTable SearchLecturesByModule(int moduleId, int courseId,int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ModuleId",moduleId),
                        new SqlParameter("@CourseId",courseId),
                        new SqlParameter("@BatchId",batchId)
                    };
            return RunProcedureQuery("SearchLecturesByModule", parameters).Tables[0];
        }

        public DataTable AllLectures(int batchId,int courseId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@BatchId",batchId),
                        new SqlParameter("@CourseId",courseId)
                    };
            return RunProcedureQuery("AllLectures", parameters).Tables[0];
        }

        public DataTable GetAllLectures(int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StaffId",staffId)
                    };
            return RunProcedureQuery("GetAllLectures", parameters).Tables[0];
        }

        public DataTable AllExams(int courseId,int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@CourseId",courseId),
                         new SqlParameter("@BatchId",batchId)
                    };
            return RunProcedureQuery("AllExams", parameters).Tables[0];
        }

        public DataTable GetModulesByCourseId(int courseId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                         new SqlParameter("@CourseId",courseId),
                    };
            return RunProcedureQueryText("select * from Module where Active=1 AND CourseId=@CourseId", parameters).Tables[0];
        }

        public DataTable GetLecturesByModule(int moduleId, int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ModuleId",moduleId),
                        new SqlParameter("@StaffId",staffId)
                    };
            return RunProcedureQuery("GetLecturesByModule", parameters).Tables[0];
        }


        public DataTable GetExamsByModule(int moduleId,int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ModuleId",moduleId),
                        new SqlParameter("@StaffId",staffId)
                    };
            return RunProcedureQuery("GetExamsByModule", parameters).Tables[0];
        }

        public DataTable GetAllExams(int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StaffId",staffId)
                    };
            return RunProcedureQuery("GetAllExams", parameters).Tables[0];
        }

        public DataTable GetModuleByCourseId(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id",id),
                    };
            return RunProcedureQueryText("select * from Module where CourseId=@Id", parameters).Tables[0];
        }

    }
}
