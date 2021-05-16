using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YazanSozluk.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        // GET: Statistics
        public ActionResult Index()
        {
            //toplam kategori sayısı
            var totalCategory = context.Categories.Count();
            ViewBag.totalCategory = totalCategory;

            //başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            var totalSoftware = context.Headings.Count(x => x.CategoryID == 1);
            ViewBag.totalSoftware = totalSoftware;

            //yazar adında "a" harfi geçen yazar sayısı
            var totalA = context.Writers.Count(x => x.WriterName.Contains("a")); ;
            ViewBag.totalA = totalA;

            //en fazla başlığa sahip kategori adı
            var maxCategory = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.maxCategory = maxCategory;

            //kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal farkı
            var differenceStatus = Math.Abs(context.Categories.Where(x => x.CategoryStatus == true).Count() -
                context.Categories.Where(x => x.CategoryStatus == false).Count());
            ViewBag.differenceStatus = differenceStatus;

            return View();
        }
    }
}