using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Batch
    {
        [Key]
        public int Id { get; set; }

        public string BatchName { get; set; }

        public int Year { get; set; }
    }
}
