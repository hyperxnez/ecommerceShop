using ASP_NETCore_Working_EF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NETCore_Working_EF.Controllers
{
    public class BillCustomer : Controller
    {
        public IActionResult Index()
        {
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var bill = context.Bills.ToList();
            ViewBag.Bill = bill;
            return View(bill);
        }
    }
}
