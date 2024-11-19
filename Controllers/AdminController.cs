using OrnekCV.Models.entity;
using OrnekCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekCV.Controllers
{

    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var admin = repo.List();
            return View(admin);
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(TblAdmin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult AdminSil(int id)
        {
            TblAdmin admin = repo.Find(x => x.ID == id);
            repo.TRemove(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminBul(int id)
        {
            TblAdmin admin = repo.Find(x => x.ID == id);
            return View(admin);
        }
        [HttpPost]
        public ActionResult AdminBul(TblAdmin p)
        {
            TblAdmin admin = repo.Find(x => x.ID == p.ID);
            admin.KullaniciAdi = p.KullaniciAdi;
            admin.Sifre=p.Sifre;
            repo.TUpdate(admin);
            return RedirectToAction("Index");

        }
    }
}