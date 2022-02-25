using System;
using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class StaffDataAccess :DataAccessBase
    {
      
        public DataTable GetStaff()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQuery("GetStaff", parameters).Tables[0];
        }

        public DataTable GetStaffById(int studentId)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StaffId",studentId),
                    };
            return RunProcedureQuery("GetStaffById", parameters).Tables[0];
        }

        public int AddStaff(string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email,string password,int roleId)
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
            new SqlParameter("@RoleId",roleId)
            };
            return int.Parse(RunProcedureScalar("AddStaff", parameters).ToString());
        }

        public void AddStaffMobile(int staffId, int mobileNuber)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StaffId",staffId),
            new SqlParameter("@MobileNumber",mobileNuber)
            };
            RunProcedureQuery("AddStaffMobile", parameters);
        }

        public void EditStaff(int staffId, string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, string password, int roleId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StaffId",staffId),
            new SqlParameter("@FirstName",firstName),
            new SqlParameter("@LastName",lastName),
            new SqlParameter("@Line1",line1),
            new SqlParameter("@Line2",line2),
            new SqlParameter("@DoB",dob),
            new SqlParameter("@Sex",sex),
            new SqlParameter("@NIC",nic),
            new SqlParameter("@Email",email),
            new SqlParameter("@Password",password),
            new SqlParameter("@RoleId",roleId)
            };
            RunProcedureQuery("EditStaff", parameters);
        }

        public void DeleteStaff(int staffId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@StaffId",staffId)
           
            };
            RunProcedureQuery("DeleteStaff", parameters);
        }

        public DataTable GetRoles()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("select * from Role where Active=1", parameters).Tables[0];
        }
    }
}
