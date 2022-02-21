using System;

namespace CourseSheduleManagement.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CourseId { get; set; }
        public int HallId { get; set; }
        public int BatchId { get; set; }
        public int ModuleId { get; set; }
    }

    public class Lecture:Schedule
    {
        public int StaffId { get; set; }
        public string LectureType { get; set; }
    }

    public class Exam : Schedule
    {
        public int StaffId { get; set; }
    }
}
