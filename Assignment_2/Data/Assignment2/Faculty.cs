using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data.Assignment2
{
    public class Faculty
    {
            [Key]
            public int id { get; set; }
            public string FName { get; set; }
            public int DepId { get; set; }

            public int FId { get; set; }

    }
}
