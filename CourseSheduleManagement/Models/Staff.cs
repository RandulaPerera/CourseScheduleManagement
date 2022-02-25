using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Models
{
    public class Staff
    {
        public int StaffId { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Line1 { get; set; } = string.Empty;
        public string Line2 { get; set; } = string.Empty;
        public DateTime DoB { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string NIC { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int MobileNumber { get; set; } = 0;
        public int Telephone { get; set; } = 0;
        public int RoleId { get; set; } = 0;
        public string FullName { get; set; } = string.Empty;

    }
}
