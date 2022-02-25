namespace CourseSheduleManagement.Models
{
    public class User
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public int CourseId { get; set; } = 0;
        public int BatchId { get; set; } = 0;
    }
}
