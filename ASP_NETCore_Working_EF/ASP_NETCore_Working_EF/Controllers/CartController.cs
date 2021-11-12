using ASP_NETCore_Working_EF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NETCore_Working_EF.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            List<CartItem> cartItems = new List<CartItem>();
            cartItems.Add(new CartItem() { Name="h", Price= 1, Quantity = 1 });
            cartItems.Add(new CartItem() { Name = "h", Price = 1, Quantity = 2 });
            cartItems.Add(new CartItem() { Name = "h", Price = 1, Quantity = 3 });
            return View(cartItems);
        }
    }
}
