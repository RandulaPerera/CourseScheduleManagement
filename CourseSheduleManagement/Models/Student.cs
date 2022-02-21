﻿using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }=0;
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Line1 { get; set; } = string.Empty;
        public string Line2 { get; set; } = string.Empty;
        public DateTime DoB { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string NIC { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int MobileNumber { get; set; } = 0;
        public int Telephone { get; set; } = 0;
        public int CourseId { get; set; } = 0;
        public int BatchId { get; set; } = 0;
    }
}