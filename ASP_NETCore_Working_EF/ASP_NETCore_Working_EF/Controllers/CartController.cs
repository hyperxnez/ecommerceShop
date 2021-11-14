using ASP_NETCore_Working_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NETCore_Working_EF.Controllers
{
    public class CartController : Controller
    {
        public const string CARTKEY = "cart";

        public List<CartItem> GetCartItems()
        {

            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        public decimal getCartTotal()
        {
            var cart = GetCartItems();
            decimal total = 0;
            foreach (var item in cart)
            {
                decimal fuckC = item.Price ?? 0;
                total += fuckC * Decimal.Parse(item.Quantity.ToString());
            }
            return total;
        }

        public IActionResult Index()
        {
            ViewBag.Total = getCartTotal();
            return View(GetCartItems());
        }

        [HttpPost]
        public IActionResult Add(string name, decimal? price, string pid, int quantity)
        {
            List<CartItem> cartItems = GetCartItems();

            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var product = context.Products.Find(pid);

            foreach(var item in cartItems)
            {
                if(item.referredProduct.Pid == pid)
                {
                    item.Quantity += quantity;
                    SaveCartSession(cartItems);
                    return RedirectToAction("Index", "Cart");
                }
            }

            cartItems.Add(new CartItem() { Name = name, Price = price, Quantity = quantity, referredProduct = product });
            SaveCartSession(cartItems);

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult AddQuantity()
        {
            string pid = RouteData.Values["id"].ToString();

            List<CartItem> cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                if (item.referredProduct.Pid == pid)
                {
                    item.Quantity++;
                    break;
                }
            }
            SaveCartSession(cartItems);

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult SubtractQuantity()
        {
            string pid = RouteData.Values["id"].ToString();

            List<CartItem> cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                if (item.referredProduct.Pid == pid && item.Quantity > 1)
                {
                    item.Quantity--;
                    break;
                }
            }
            SaveCartSession(cartItems);

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Remove()
        {
            string pid = RouteData.Values["id"].ToString();

            List<CartItem> cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                if (item.referredProduct.Pid == pid)
                {
                    cartItems.Remove(item);
                    break;
                }
            }
            SaveCartSession(cartItems);

            return RedirectToAction("Index", "Cart");
        }
    }
}
