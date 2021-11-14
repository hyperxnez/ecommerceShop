using ASP_NETCore_Working_EF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ASP_NETCore_Working_EF.Controllers
{
    public class BillController : Controller
    {
        
        public IActionResult Index()
        {
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var model = context.Bills.ToList();
            return View(model);
        }
        
        public IActionResult Detail(int? id)
        {
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            if (id == null)
            {
                return NotFound();
            }
            var bill = context.Bills.FirstOrDefault(m => m.Cid == id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

    }
}
