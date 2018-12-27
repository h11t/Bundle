using Bundle_Islemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bundle_Islemleri.Controllers
{
    public class HaberController : Controller
    {
        // GET: Haber
        public ActionResult Detay(string haberAdi, int id)
        {
            var haber = new HaberListesi().Where(x => x.Adi == haberAdi && x.Id == id).FirstOrDefault();
            
            return View(haber);
        }
        public ActionResult Listele()
        {
            return View(new HaberListesi());
        }
    }
}