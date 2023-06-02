using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    public class UserCourse: BaseClass
    {
        public AppUser User { get; set; }

        [ForeignKey(nameof(Courses))]
        public List<int> CourseIds { get; set; }
        public List<Course> Courses { get;set; }
    }
}
