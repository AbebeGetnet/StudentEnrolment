using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentEnrolment.Models
{    
    public class College
    {
        public int CollegeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Campus>? Campus { get; set; }
    }
    public class Campus
    {
        public int CampusId { get; set; }
        public string Name { get; set; }
        public int CollegeId { get; set; }
        public virtual College? College { get; set; }
    }
    
}
