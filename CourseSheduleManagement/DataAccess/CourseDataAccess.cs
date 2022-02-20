using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class CourseDataAccess :DataAccessBase
    {
       
        public DataTable GetCourses()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("GetCourses", parameters).Tables[0];
        }

        public DataTable GetCourseById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id",id),
                    };
            return RunProcedureQueryText("select * from Course where CourseId=@Id", parameters).Tables[0];
        }

        public void AddOrEditCourse(int courseId,string courseName, string courseCode, string description)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@CourseName",courseName),
            new SqlParameter("@CourseCode",courseCode),
            new SqlParameter("@Description",description)
            };
            RunProcedureQuery("AddorEditCourse", parameters);
        }

        public void DeleteCourse(int courseId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CourseId",courseId)
           
            };
            RunProcedureQuery("DeleteCourse", parameters);
        }

    }
}
