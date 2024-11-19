using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekCV.Models.entity;


namespace OrnekCV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities1 db = new DbCvEntities1();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya= db.TblSosyalMedya.Where(x=>x.durum==true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyim.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitim()
        {
            var egitim = db.TblEgitimler.ToList();
            return PartialView(egitim);
        }
        public PartialViewResult Yetenek()
        {
            var yetenekler = db.tblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobi()
        {
            var hobiler = db.TblHobiler.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifika()
        {
            var Sertifikalar= db.TblSertifika.ToList();
            return PartialView(Sertifikalar);  
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(Tbliletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();   
            return PartialView();
        }
    }
}