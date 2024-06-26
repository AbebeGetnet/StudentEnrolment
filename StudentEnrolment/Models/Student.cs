﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using StudentEnrolment.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



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
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage ="Please choose photo")]
        [Display(Name="Photo")]
        [NotMapped]
        public IFormFile? Photo { get; set; }        
        public virtual ICollection<StudentCourse>? StudentCourses { get; set; }
    }
}
