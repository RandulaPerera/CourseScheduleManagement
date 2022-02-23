namespace CourseSheduleManagement.Models
{
    public class ContactNumber
    {
        public int Id { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public string UserType { get; set; }=string.Empty;
        public int MobileNumber { get; set; } = 0;
    }
}
