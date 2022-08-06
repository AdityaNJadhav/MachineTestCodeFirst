using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name Required.")]
        [DisplayName ("Product Name")]
        public String ProductName { get; set; }

        [Required(ErrorMessage = "Category ID Required.")]
        public int CategoryID { get; set; }
       
        [Required(ErrorMessage = "Category Name Required.")]
        public String  CategoryName { get; set; }
    }

    public class EFCodeFirstEntieis : DbContext 
    {
        public DbSet<Products> Products { get; set; }
    }
}