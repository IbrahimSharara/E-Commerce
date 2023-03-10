// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "date")]
        public DateTime ArriveDate { get; set; }
        public double Price { get; set; }
        public int? CategoryID { get; set; }
        public int? BrandID { get; set; }
        public int? SupplierID { get; set; }

        [ForeignKey("BrandID")]
        [InverseProperty("Products")]
        public virtual Brand Brand { get; set; }
        [ForeignKey("CategoryID")]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [ForeignKey("SupplierID")]
        [InverseProperty("Products")]
        public virtual Supplier Supplier { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}