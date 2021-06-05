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
    }
}