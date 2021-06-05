using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje.Models.Entity;

namespace MvcProje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDbStokEntities db = new MvcDbStokEntities();

        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORILERs.ToList();
            return View(degerler);
        }
        [HttpGet] //sayfa yüklenirken yapması gerekenleri belirler
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost] // sayfada bir işlem yapıldığı zaman devreye girer
        public ActionResult YeniKategori(TBLKATEGORILER p1)
        {
            db.TBLKATEGORILERs.Add(p1);
            db.SaveChanges();
            return View();

        }
    }
}