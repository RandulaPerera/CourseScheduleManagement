namespace CourseSheduleManagement.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
    }
}
