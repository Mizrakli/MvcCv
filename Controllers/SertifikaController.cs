using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekCV.Repositories;
using OrnekCV.Models.entity;
namespace OrnekCV.Controllers
{
    public class SertifikaController : Controller
    {
        GenericRepository<TblSertifika> repo = new GenericRepository<TblSertifika>();
        // GET: Sertifika
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaBul(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaBul(TblSertifika p)
        {
            var sertifika = repo.Find(x => x.ID == p.ID);
            sertifika.Aciklama= p.Aciklama;
            sertifika.Tarih= p.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public  ActionResult SertifikaEkle()
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult SertifikaEkle(TblSertifika p)
        {
            repo.TAdd(p); 
            return RedirectToAction("Index");
      
        }
        public ActionResult SertifikaSil(int id)
        { 
            var sertifika = repo.Find(x=>x.ID == id);
            repo.TRemove(sertifika);
            return RedirectToAction("Index");
        }
    }
}