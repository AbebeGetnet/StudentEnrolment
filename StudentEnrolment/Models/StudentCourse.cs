﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrolment.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [ValidateNever]
        public virtual Department? Department { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        [ValidateNever]
        public Course? Course { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        [ValidateNever]
        public Student? Student { get; set; }
    }
}
