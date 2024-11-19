using OrnekCV.Models.entity;
using OrnekCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekCV.Controllers
{
    public class EgitimController : Controller
    {
       
        GenericRepository<TblEgitimler> repo = new GenericRepository<TblEgitimler>();
        [Authorize]
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        public ActionResult EgitimSil(int id)
        {
            TblEgitimler egitim = repo.Find(x => x.ID == id);
            repo.TRemove(egitim);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult EgitimEkle() 
        { 
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TblEgitimler p)
        {
      
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimBul(int id)
        {
            TblEgitimler egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EgitimBul(TblEgitimler p)
        {
          
            TblEgitimler egitim = repo.Find(x => x.ID == p.ID);
            egitim.Baslik=p.Baslik;
            egitim.AltBaslik1 = p.AltBaslik1; 
             egitim.AltBaslik2 = p.AltBaslik2;
            egitim.GNO=p.GNO;
            egitim.Tarih=p.Tarih;
            repo.TUpdate(egitim);
           return RedirectToAction("Index");
        }


    }
}