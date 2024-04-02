using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolment.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public int CreditHour { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [ValidateNever]
        public virtual Department? Department { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
        public virtual ICollection<Enrolment>? Enrolments { get; set; }
        public virtual ICollection<StudentCourse>? StudentCourses { get; set; }
    }
}
