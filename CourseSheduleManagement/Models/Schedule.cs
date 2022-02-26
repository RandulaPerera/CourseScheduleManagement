using System;

namespace CourseSheduleManagement.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; } = 0;
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CourseId { get; set; } = 0;
        public int HallId { get; set; } = 0;
        public int BatchId { get; set; } = 0;
        public int ModuleId { get; set; } = 0;

        public string CourseName { get; set; } = string.Empty;
        public string HallName { get; set; } = string.Empty;
        public string BatchCode { get; set; } = string.Empty;
        public string ModuleName { get; set; } = string.Empty;
        public string LecturerName { get; set; } = string.Empty;
    }

    public class Lecture:Schedule
    {
        public int StaffId { get; set; } = 0;
        public string LectureType { get; set; } = string.Empty;
    }

    public class Exam : Schedule
    {
        public int StaffId { get; set; } = 0;
    }
}
