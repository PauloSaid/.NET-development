using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The field {0} can not be empty.")]
        [StringLength(60, ErrorMessage = "The field {0} can not be bigger than {1} characters.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "The field {0} can not be empty.")]
        [StringLength(500, ErrorMessage = "The field {0} can not be bigger than {1} characters.")]
        public string? Description { get; set; }
        [DisplayName("Unit price")]
        [Required(ErrorMessage = "The field {0} can not be empty.")]
        [Range(0.05, int.MaxValue, ErrorMessage = "Please, enter a valid price that be expansive than 0.05")]
        public decimal? UnitPrice { get; set; }
        [Required(ErrorMessage = "The field {0} can not be empty.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please, enter valid a number")]
        public int? Amount { get; set; }
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile? ImageUpload { get; set; }
        public string? Image {  get; set; }
        public bool Active { get; set; }
    }
}
