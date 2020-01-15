namespace Exercises.Models
{
    public class StudentModel : PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
