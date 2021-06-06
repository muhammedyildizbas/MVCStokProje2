using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje.Models.Entity;
namespace MvcProje.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun

        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLERs.ToList();
            return View(degerler);
           
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.TBLKATEGORILERs.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(TBLURUNLER p1)
        {
            var ktg = db.TBLKATEGORILERs.Where(m => m.KATEGORIID == p1.TBLKATEGORILER.KATEGORIID).FirstOrDefault();
            p1.TBLKATEGORILER = ktg;

            db.TBLURUNLERs.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var urun = db.TBLURUNLERs.Find(id);
            db.TBLURUNLERs.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = db.TBLURUNLERs.Find(id);
            return View("UrunGetir", urun);
        }
    }
}