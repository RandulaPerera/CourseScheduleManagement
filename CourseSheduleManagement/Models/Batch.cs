﻿namespace CourseSheduleManagement.Models
{
    public class Batch
    {
        public int BatchId { get; set; }
        public int Year { get; set; }
        public string BatchCode { get; set; }
        public int CourseId { get; set; }
    }
}