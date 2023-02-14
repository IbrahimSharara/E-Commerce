﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Models
{
    [Table("Supplier")]
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int SupplierID { get; set; }
        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }

        [InverseProperty("Supplier")]
        public virtual ICollection<Product> Products { get; set; }
    }
}