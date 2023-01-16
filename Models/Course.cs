using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string CourseName { get; set; }

        public int Duration { get; set; }
    }
}
