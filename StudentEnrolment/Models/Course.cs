namespace StudentEnrolment.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public int CreditHour { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
