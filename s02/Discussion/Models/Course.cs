using System.Collections;
using System.ComponentModel.DataAnnotations;
namespace Discussion.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; } = null;
       
        // Stack is a data structure that allows you to store multiple items of the same type
        [Required]
        public Stack Stack {  get; set; }

        [Required]
        public string Description { get; set; } = null;

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string StackUrl { get; set; } = null;

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; } = null;
    }
}
