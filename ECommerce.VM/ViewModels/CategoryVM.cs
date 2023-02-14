
using ECommerce.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.VM.ViewModels
{
    public class CategoryVM : Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
