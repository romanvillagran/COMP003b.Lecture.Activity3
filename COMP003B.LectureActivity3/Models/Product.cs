using System.ComponentModel.DataAnnotations;
namespace COMP003B.LectureActivity3.Models
{
    public class Product
    {
        public int ID {  get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
