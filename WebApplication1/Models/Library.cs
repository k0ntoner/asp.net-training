using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Library
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
    }
}
