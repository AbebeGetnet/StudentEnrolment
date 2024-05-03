namespace StudentEnrolment.Models.ViewModels
{
    public class DepartmentCourseCreateViewModel
    {
        public string Name { get; set; }
        public virtual List<int> CourseIds { get; set; }
    }
}
