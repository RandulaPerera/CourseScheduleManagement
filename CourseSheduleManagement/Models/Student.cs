using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public DateTime DoB { get; set; }
        public string Sex { get; set; }
        public string NIC { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public int CourseId { get; set; }
        public int BatchId { get; set; }
    }
}
