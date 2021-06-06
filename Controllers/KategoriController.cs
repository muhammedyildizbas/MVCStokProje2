using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MvcProje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDbStokEntities db = new MvcDbStokEntities();

        public ActionResult Index(int sayfa=1)
        {
            //var degerler = db.TBLKATEGORILERs.ToList();
            var degerler = db.TBLKATEGORILERs.ToList().ToPagedList(sayfa, 4);
            return View(degerler);
        }
        //sayfa yüklenirken yapması gerekenleri belirler
        [HttpGet] 
        public ActionResult YeniKategori()
        {
            return View();
        }
        // sayfada bir işlem yapıldığı zaman devreye girer
        [HttpPost] 
        public ActionResult YeniKategori(TBLKATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.TBLKATEGORILERs.Add(p1);
            db.SaveChanges();
            return View();

        }
        public ActionResult SIL(int id)
        {
            var kategori = db.TBLKATEGORILERs.Find(id);
            db.TBLKATEGORILERs.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TBLKATEGORILERs.Find(id);
            return View("KategoriGetir", ktgr);
        }
        public ActionResult Guncelle(TBLKATEGORILER p1)
        {
            var ktg = db.TBLKATEGORILERs.Find(p1.KATEGORIID);
            ktg.KATEGORIAD = p1.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}