using System;

namespace CourseSheduleManagement.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int HallId { get; set; }
        public int BatchId { get; set; }
        public int ModuleId { get; set; }
    }

    public class Lecture:Schedule
    {
        public int LecturerBy { get; set; }
        public string Type { get; set; }
    }

    public class Exam : Schedule
    {
        public int PreparedBy { get; set; }
        public int ExamInvigilateBy { get; set; }
    }
}
