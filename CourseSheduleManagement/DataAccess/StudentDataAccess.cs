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
            return RunProcedureQuery("GetStudents", parameters).Tables[0];
        }

        public DataTable GetStudentById(int studentId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentId",studentId),
                    };
            return RunProcedureQuery("GetStudentById", parameters).Tables[0];
        }

        public int AddStudent(string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, string password, int courseId, int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            
            new SqlParameter("@FirstName",firstName),
            new SqlParameter("@LastName",lastName),
            new SqlParameter("@Line1",line1),
            new SqlParameter("@Line2",line2),
            new SqlParameter("@DoB",dob),
            new SqlParameter("@Sex",sex),
            new SqlParameter("@NIC",nic),
            new SqlParameter("@Email",email),
            new SqlParameter("@Password",password),
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@BatchId",batchId)
            };
            return int.Parse(RunProcedureScalar("AddStudent", parameters).ToString());
        }

        public void AddStudentMobile(int studentId, int mobileNuber)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StudentId",studentId),
            new SqlParameter("@MobileNumber",mobileNuber)
            };
            RunProcedureQuery("AddStudentMobile", parameters);
        }

        public void EditStudent(int studentId, string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, string password, int courseId, int batchId)
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
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@BatchId",batchId)
            };
            RunProcedureQuery("EditStudent", parameters);
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
