namespace CourseSheduleManagement.Models
{
    public class Batch
    {
        public int BatchId { get; set; } = 0;
        public int Year { get; set; } = 0;
        public string BatchCode { get; set; } = string.Empty;
        public int CourseId { get; set; } = 0;
    }
}
