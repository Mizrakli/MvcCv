using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Tree;
using OrnekCV.Models.entity;
using OrnekCV.Repositories;
namespace OrnekCV.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            var veri = repo.List();
            return View(veri);
        }
        [HttpGet]
        public ActionResult SMEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SMEkle(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult SMBul(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult SMBul(TblSosyalMedya p)
        {
            var deger = repo.Find(x => x.ID == p.ID);
            deger.Ad = p.Ad;
            deger.Link = p.Link;
            deger.Icon = p.Icon;
            deger.durum = true;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SMSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            deger.durum = false;
            repo.TUpdate(deger);
            return RedirectToAction("Index");

        }
    }
}