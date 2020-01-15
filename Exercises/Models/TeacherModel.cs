using System.Collections.Generic;

namespace Exercises.Models
{
    public class TeacherModel : PersonModel
    {
        public int TeachingExperience { get; set; }

        public List<CourseModel> ListOfCourses { get; set; }
    }
}
