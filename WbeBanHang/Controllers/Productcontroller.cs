using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbeBanHang.Models;

namespace WbeBanHang.Controllers
{
    public class Productcontroller : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hosting;
        public Productcontroller(ApplicationDbContext db, IHostingEnvironment hosting)
        {
            _db = db;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            var dsSanPham = _db.Products.ToList();
            return View();
        }
    }
}
