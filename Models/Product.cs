using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VShop.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(110)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Date Created")]
        public System.DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        [StringLength(1000)]
        public string Description { get; set; }
        [DisplayName("Product Image")]
        public string ProductImage { get; set; }
       
        [Range(1, 100000,
           ErrorMessage = "Quantity must be between 1 and 100000")]
        public int Quantity { get; set; }
        [Range(0.01, 10000.00,
            ErrorMessage = "Price must be between 0.01 and 10000.00")]
        public decimal Price { get; set; }
        public Category Category { get; set; }
        //public virtual Category Cat { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}