using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolment.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [NotMapped]
        public virtual Department? Department { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        [NotMapped]
        public virtual Course? Course { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        [NotMapped]
        public virtual Student? Student { get; set; }
    }
}
