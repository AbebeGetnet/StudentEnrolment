using System.Drawing;

namespace StudentEnrolment.Models.ViewModels
{
    public class CampusViewModel
    {
        public int CampusId { get; set; }
        public int CollegeId { get; set; }
        public virtual College? College { get; set; }
        public string CollegeName { get; set; }
    }
}
