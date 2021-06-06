using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje.Models.Entity;


namespace MvcProje.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDbStokEntities db = new MvcDbStokEntities();

        public ActionResult Index()
        {

            var degerler = db.TBLMUSTERILERs.ToList(); 
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TBLMUSTERILER p1)
        {
            db.TBLMUSTERILERs.Add(p1);
            db.SaveChanges();
            return View();

        }
        public ActionResult SIL(int id)
        {
            var musteri = db.TBLMUSTERILERs.Find(id);
            db.TBLMUSTERILERs.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult MusteriGetir(int id)
        {
            var mus = db.TBLMUSTERILERs.Find(id);
            return View("MusteriGetir", mus);
        }
    }
}