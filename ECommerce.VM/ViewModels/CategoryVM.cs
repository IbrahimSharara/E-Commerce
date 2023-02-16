
using ECommerce.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.VM.ViewModels
{
    public class CategoryVM : Category
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}
