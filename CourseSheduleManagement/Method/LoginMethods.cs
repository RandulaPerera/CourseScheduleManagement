using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class LoginMethods
    {
        LoginDataAccess _loginDataAccess = new LoginDataAccess();

        public User GetStudentDetailsByEmail(string email)
        {
            User userstudent = new User();
            DataTable dt = _loginDataAccess.GetStudentDetailsByEmail(email);
            if (dt.Rows.Count == 1)
            {
                userstudent.FullName =dt.Rows[0]["FullName"].ToString();
                userstudent.Email = dt.Rows[0]["Email"].ToString();
                userstudent.Password = dt.Rows[0]["Password"].ToString();
                userstudent.CourseId = Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
                userstudent.BatchId = Convert.ToInt32(dt.Rows[0]["BatchId"].ToString());

            }
            return userstudent;
        }

        public User GetStaffDetailsByEmail(string email)
        {
            User userStaff = new User();
            DataTable dt = _loginDataAccess.GetStaffDetailsByEmail(email);
            if (dt.Rows.Count == 1)
            {
                userStaff.FullName =dt.Rows[0]["FullName"].ToString();
                userStaff.Email = dt.Rows[0]["Email"].ToString();
                userStaff.Password = dt.Rows[0]["Password"].ToString();
                userStaff.RoleName =  dt.Rows[0]["RoleName"].ToString();
                userStaff.StaffId =  Convert.ToInt32(dt.Rows[0]["StaffId"].ToString());
            }
            return userStaff;
        }

    }
}
