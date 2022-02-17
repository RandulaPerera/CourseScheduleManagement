using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public DateTime DoB { get; set; }
        public string Sex { get; set; }
        public string NIC { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int MobileNumber { get; set; }
        public int Telephone { get; set; }
        public int RoleId { get; set; }
    }
}
