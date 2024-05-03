namespace StudentEnrolment.Models.ViewModels
{
    public class EnrollmentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public int[] SelectedCourseIds { get; set; }
    }
}
