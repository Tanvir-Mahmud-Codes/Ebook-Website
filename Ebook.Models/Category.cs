using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ebook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(20)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "The range of the order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
