using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        public string Passport { get; set; }
        public string FullName { get; set; }

        [ForeignKey("Library")]
        public int Lib_Id { get; set; }
        public Library? Library { get; set; } 

        [ForeignKey("Position")]
        public int Pos_Id { get; set;}
        public Position? Position { get; set; }

    }
}
