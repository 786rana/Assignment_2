using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data.Assignment2
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Room_Number { get; set; }
    }
    
}
