using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using StudentEnrolment.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolment.Models
{    
    public class Enrolment
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        [ValidateNever]
        public virtual Course? Course { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        [ValidateNever]
        public virtual Student? Student { get; set; }
        public Grade? Grade { get; set; }      
        
    }
}
