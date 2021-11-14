using ASP_NETCore_Working_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NETCore_Working_EF.Controllers
{
    public class CheckoutInfoController : Controller
    {
        public IActionResult Index()
        {
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var countries = context.Countries.ToList();

            List<CartItem> cart = new List<CartItem>();

            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            if (jsoncart != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            decimal total = 0;
            foreach (var item in cart)
            {
                decimal fuckC = item.Price ?? 0;
                total += fuckC * Decimal.Parse(item.Quantity.ToString());
            }

            ViewBag.Countries = countries;
            ViewBag.Total = total;
            
            return View();
        }

        [HttpPost]
        public IActionResult Submit(
            string first_name,
            string last_name,
            string company_name,
            string email,
            int? country_id,
            string address,
            string town,
            string zip_code,
            string phone,
            string comment
        )
        {
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var checkoutInfo = new CheckoutInfo() { 
                FirstName = first_name, 
                LastName= last_name,
                CompanyName = company_name,
                Email = email,
                CountryId = country_id,
                Address = address,
                Town = town,
                ZipCode = zip_code,
                Phone = phone,
                Comment = comment
            };

            List<CartItem> cart = new List<CartItem>();

            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            if (jsoncart != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            decimal total = 0;
            foreach (var item in cart)
            {
                decimal fuckC = item.Price ?? 0;
                total += fuckC * Decimal.Parse(item.Quantity.ToString());
            }

            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var item in cart)
            {
                orderItems.Add(new OrderItem() { ProductId = item.referredProduct.Pid, Quantity = item.Quantity });
            }

            Order order = new Order() {CheckoutInfo= checkoutInfo, Total=total, OrderItems=orderItems };
            context.CheckoutInfos.Add(checkoutInfo);
            context.Orders.Add(order);
            context.SaveChanges();
            
            return RedirectToAction("Index", "Home");
        }
    }
}
