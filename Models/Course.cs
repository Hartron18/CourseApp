using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    public class Course:BaseClass
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseUnit { get; set; }

        
        public UserCourse UserCourse { get; set; }

    }
}
