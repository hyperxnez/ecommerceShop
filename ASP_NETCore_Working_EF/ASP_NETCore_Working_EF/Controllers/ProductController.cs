using ASP_NETCore_Working_EF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NETCore_Working_EF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Khoi tao CSDL
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();

            // Các cách truyền dữ liệu từ Contrller -> View: ViewData, ViewBag, TempData, View()
            // Lưu ý: Với 1 action chỉ được phép truyền 1 Model vào trong View()
            var query = context.Categories.Select(c => new { c.CateId, c.CateName });
            ViewBag.Categories = new SelectList(query.AsEnumerable(), "CategoryId", "CategoryName");

            return View(context.Products.ToList());
        }

        [HttpPost]
        public IActionResult Index(Category category)
        {
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var query = context.Categories.Select(c => new { c.CateId, c.CateName });
            ViewBag.Categories = new SelectList(query.AsEnumerable(), "CategoryId", "CategoryName");

            return View(context.Products.ToList());
        }

        public IActionResult Detail()
        {
            string pid = RouteData.Values["id"].ToString();
            ECommerce_PRN211Context context = new ECommerce_PRN211Context();
            var product = context.Products.Find(pid);
            var category = context.Categories.Find(product.CateId);

            ViewBag.Product = product;
            ViewBag.Category = category.CateName;

            return View(product);
        }

        public IActionResult InsertProduct()
        {
            return View();
        }
        

       
    }
}
