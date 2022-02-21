namespace CourseSheduleManagement.Models
{
    public class Module
    {
        public int ModuleId { get; set; } = 0;

        public string ModuleName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CourseId { get; set; } = 0;
    }
}
