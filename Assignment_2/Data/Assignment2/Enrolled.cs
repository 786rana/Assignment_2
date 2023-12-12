using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data.Assignment2
{
    public class Enrolled
    {
        [Key]
        public int SId { get; set; }
        public int FId { get; set; }
        public int CId { get; set; }
    }
}
