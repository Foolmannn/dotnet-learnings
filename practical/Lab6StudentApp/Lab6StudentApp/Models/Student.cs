using System.ComponentModel.DataAnnotations;

namespace Lab6StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Address { get; set; }
    }
}