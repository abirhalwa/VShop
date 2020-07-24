using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        //[Required(ErrorMessage = "Category Name Requird")]
        //[StringLength(100, ErrorMessage = "Minimum 3 and minimum 5 and maximum 100 charaters are allwed", MinimumLength = 3)]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}