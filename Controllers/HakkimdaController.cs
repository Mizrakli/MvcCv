using OrnekCV.Models.entity;
using OrnekCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekCV.Controllers
{
    public class HakkimdaController : Controller
    {
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        [HttpGet]
        // GET: Hakkimda
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda p)
        {
            var hakkimda = repo.Find(x=>x.ID==1);
            hakkimda.Ad=p.Ad;
            hakkimda.Soyad=p.Soyad;
            hakkimda.Adres = p.Adres;
            hakkimda.Telefon=p.Telefon;
            hakkimda.Mail = p.Mail;
            hakkimda.Aciklama=p.Aciklama;
            hakkimda.Resim=p.Resim;
            repo.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}