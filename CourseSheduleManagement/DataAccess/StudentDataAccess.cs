using System;
using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class StudentDataAccess :DataAccessBase
    {
      
        public DataTable GetStudents()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("select * from Student where IsDelete=0", parameters).Tables[0];
        }

        public DataTable GetStudentById(int studentId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentId",studentId),
                    };
            return RunProcedureQueryText("select * from Student where StudentId=@StudentId", parameters).Tables[0];
        }

        public void AddOrEditStudent(int studentId,string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email,string password,int mobileNuber,int telephone,int courseId,int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StudentId",studentId),
            new SqlParameter("@FirstName",firstName),
            new SqlParameter("@LastName",lastName),
            new SqlParameter("@Line1",line1),
            new SqlParameter("@Line2",line2),
            new SqlParameter("@DoB",dob),
            new SqlParameter("@Sex",sex),
            new SqlParameter("@NIC",nic),
            new SqlParameter("@Email",email),
            new SqlParameter("@Password",password),
            new SqlParameter("@MobileNumber",mobileNuber),
            new SqlParameter("@Telephone",telephone),
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@BatchId",batchId)
            };
            RunProcedureQuery("AddorEditStudent", parameters);
        }

        public void DeleteStudent(int studentId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StudentId",studentId)
           
            };
            RunProcedureQuery("DeleteStudent", parameters);
        }

   
    }
}
