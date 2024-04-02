namespace StudentEnrolment.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
        public virtual ICollection<StudentCourse>? StudentCourses { get; set; }
    }
}
