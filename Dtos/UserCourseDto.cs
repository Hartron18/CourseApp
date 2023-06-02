using CourseApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Dtos
{
    public class UserCourseDto
    {
        public AppUser User { get; set; }
        public List<int> CourseIds { get; set; }
    }
}
