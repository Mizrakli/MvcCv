using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekCV.Models.entity;
using OrnekCV.Repositories;
namespace OrnekCV.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();

        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyim p)
        {
            repo.TAdd(p);
            return RedirectToAction("index"); 
        }
        public ActionResult DeneyimSil(int id)
        { 
            TblDeneyim t = repo.Find(x=>x.ID==id);
            repo.TRemove(t);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult DeneyimBul(int id)
        {
            TblDeneyim t= repo.Find(x=>x.ID==id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimBul(TblDeneyim p)
        {
            TblDeneyim t = repo.Find(x=>x.ID==p.ID);
            t.Baslik = p.Baslik;
            t.AltBaslik=p.AltBaslik;
            t.Tarih=p.Tarih;    
            t.Aciklama=p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("index");
        }
    }
}