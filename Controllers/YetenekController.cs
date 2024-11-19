using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekCV.Models.entity;
using OrnekCV.Repositories;
namespace OrnekCV.Controllers
{
    public class YetenekController : Controller
    {
        GenericRepository<tblYeteneklerim> repo = new GenericRepository<tblYeteneklerim>();
        public ActionResult Index()
        {
            var yetenek = repo.List();
            return View(yetenek);
        }
        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(tblYeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("index");
        }
        public ActionResult YetenekSil(int id)
        {
            tblYeteneklerim t = repo.Find(x => x.ID == id);
            repo.TRemove(t);
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult YetenekBul(int id)
        {
            tblYeteneklerim t=repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult YetenekBul(tblYeteneklerim p)
        {
            tblYeteneklerim t = repo.Find(x => x.ID == p.ID);
            t.Yetenek = p.Yetenek;
            t.Oran = p.Oran;
            repo.TUpdate(t);
            return RedirectToAction("index"); 
        }

    }
}