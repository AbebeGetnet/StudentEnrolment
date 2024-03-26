using StudentEnrolment.Models.Enums;

namespace StudentEnrolment.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
