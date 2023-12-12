using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data.Assignment2
{
    public class EditModel
    {
        [Required(ErrorMessage ="Name IS Required.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Add New Course is Required.")]
        public string? NewCourse { get; set; }
    }
}
