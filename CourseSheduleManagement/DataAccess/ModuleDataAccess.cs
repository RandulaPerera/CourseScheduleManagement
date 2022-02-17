using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class ModuleDataAccess :DataAccessBase
    {
       
        public DataTable GetModules()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("GetModules", parameters).Tables[0];
        }

        public DataTable GetModuleById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id",id),
                    };
            return RunProcedureQueryText("select * from Module where ModuleId=@Id", parameters).Tables[0];
        }

        public void AddOrEditModule(int moduleId, string name,string description, int courseId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ModuleId",moduleId),
            new SqlParameter("@Name",name),
            new SqlParameter("@Description",description),
            new SqlParameter("@CourseId",courseId)
            };
            RunProcedureQuery("AddorEditModule", parameters);
        }

        public void DeleteModule(int moduleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ModuleId",moduleId)
           
            };
            RunProcedureQuery("DeleteCourse", parameters);
        }

    }
}
