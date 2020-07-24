using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VShop.Models
{
    public class VShopEnities : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail>OrderDetails { get; set; }

        public System.Data.Entity.DbSet<VShop.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}
