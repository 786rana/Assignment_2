using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data.Assignment2
{
    public class DeleteModel
    {
        [Required(ErrorMessage ="Are you sure this Message is Deleted ?")]
        public string? Name { get; set; }
    }
}
