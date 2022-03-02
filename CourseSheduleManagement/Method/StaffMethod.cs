using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Library;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class StaffMethod
    {
        StaffDataAccess _staffDataAccess = new StaffDataAccess();
        CommonDataAccess _commonDataAccess = new CommonDataAccess();

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
                staff.RoleId = Convert.ToInt32(dt.Rows[0]["RoleId"].ToString());

            }

            string usertype = "Staff";
            DataTable dtc = _commonDataAccess.GetContactById(staffId, usertype);

            staff.Contacts = new List<Contact>();

            foreach (DataRow dr in dtc.Rows)
            {
                var contact = new Contact();
                contact.ContactId = dr.GetValue<int>("ContactId");
                contact.UserId = dr.GetValue<int>("UserId");
                contact.ContactNumber = dr.GetValue<int>("ContactNumber");
                staff.Contacts.Add(contact);
            }

            return staff;
        }
        public int AddStaff(string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email,string password,int roleId)
        {
            return _staffDataAccess.AddStaff(firstName,lastName,line1,line2,dob,sex,nic,email,password,roleId);
        }
        public void AddStaffMobile(int staffId, int mobileNumber)
        {
            _staffDataAccess.AddStaffMobile(staffId, mobileNumber);
        }

        public void EditStaff(int staffId, string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, string password, int roleId)
        {
            _staffDataAccess.EditStaff(staffId, firstName, lastName, line1, line2, dob, sex, nic, email, password, roleId);
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
                role.RoleName = dt.Rows[i]["RoleName"].ToString();
                list.Add(role);
            }
            return list;
        }


    }


}
