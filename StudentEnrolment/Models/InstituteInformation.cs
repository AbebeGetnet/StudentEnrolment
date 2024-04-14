namespace StudentEnrolment.Models
{
    public class InstituteInformation
    {
        public class College
        {
            public int CollegeId { get; set; }
            public string Name { get; set; }
        }
        public class Campus
        {
            public int CampusId { get; set; }
            public string Name { get; set; }
            public int CollegeId { get; set; }
            public virtual College? College { get; set; }
        }
    }
}
