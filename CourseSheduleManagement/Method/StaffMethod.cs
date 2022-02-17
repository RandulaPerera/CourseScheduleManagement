using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class StaffMethod
    {
        StaffDataAccess _staffDataAccess = new StaffDataAccess();

        public DataTable GetStaff()
        {
            DataTable dt = _staffDataAccess.GetStaff();
            return dt;
        }
        public Staff GetStaffById(int staffId)
        {
            Staff staff = new Staff();
            DataTable dt = _staffDataAccess.GetStaffById(staffId);
            if (dt.Rows.Count == 1)
            {
                staff.StaffId =Convert.ToInt32(dt.Rows[0]["StaffId"].ToString());
                staff.FirstName = dt.Rows[0]["FirstName"].ToString();
                staff.LastName = dt.Rows[0]["LastName"].ToString();
                staff.Line1 = dt.Rows[0]["Line1"].ToString();
                staff.Line2 = dt.Rows[0]["Line2"].ToString();
                staff.DoB = Convert.ToDateTime(dt.Rows[0]["DoB"].ToString());
                staff.Sex = dt.Rows[0]["Sex"].ToString();
                staff.NIC = dt.Rows[0]["NIC"].ToString();
                staff.Email = dt.Rows[0]["Email"].ToString();
                staff.Password = dt.Rows[0]["Password"].ToString();
                staff.MobileNumber =Convert.ToInt32(dt.Rows[0]["MobileNumber"].ToString());
                staff.Telephone =Convert.ToInt32(dt.Rows[0]["Telephone"].ToString());
                staff.RoleId =Convert.ToInt32(dt.Rows[0]["RoleId"].ToString());
               
            }
            return staff;
        }
        public void AddOrEditStaff(int staffId, string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, string password, int mobileNuber, int telephone, int roleId)
        {
            _staffDataAccess.AddOrEditStaff(staffId,firstName,lastName,line1,line2,dob,sex,nic,email,password,mobileNuber,telephone, roleId);
        }

        public void DeleteStaff(int staffId)
        {
            _staffDataAccess.DeleteStaff(staffId);
        }

        public List<Role> GetRoles()
        {
            DataTable dt = _staffDataAccess.GetRoles();
            var list = new List<Role>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Role role = new Role();
                role.RoleId = Convert.ToInt32(dt.Rows[i]["RoleId"]);
                role.Name = dt.Rows[i]["Name"].ToString();
                list.Add(role);
            }
            return list;
        }


    }


}
