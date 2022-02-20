namespace CourseSheduleManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }=0;
        public string CourseName { get; set; }=string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
