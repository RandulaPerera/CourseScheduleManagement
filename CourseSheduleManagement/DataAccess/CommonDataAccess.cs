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
            return RunProcedureQueryText("select StaffId,(FirstName+' '+LastName) as FullName from Staff where Active=1", parameters).Tables[0];
        }

        public DataTable SearchByDate(DateTime date)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Date",date),
                    };
            return RunProcedureQuery("SearchByDate", parameters).Tables[0];
        }
    }
}
