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
    }
}
