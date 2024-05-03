using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolment.Models
{
    public class DepartmentCourse
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [NotMapped]
        public virtual Department? Department { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        [ValidateNever]
        public virtual Course? Course { get; set; }
        
    }
}
