using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class LoginDataAccess:DataAccessBase
    {

        public DataTable GetStudentDetailsByEmail(string email)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Email",email),
                    };
            return RunProcedureQuery("GetStudentDetailsByEmail", parameters).Tables[0];
        }

        public DataTable GetStaffDetailsByEmail(string email)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Email",email),
                    };
            return RunProcedureQuery("GetStaffDetailsByEmail", parameters).Tables[0];
        }
    }
}
