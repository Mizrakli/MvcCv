using OrnekCV.Models.entity;
using OrnekCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekCV.Controllers
{
    public class HobiController : Controller
    {
        GenericRepository<TblHobiler> repo = new GenericRepository<TblHobiler>();

        // GET: Hobi
        [HttpGet]
        public ActionResult Index()
        {
            var hobi= repo.List();
            return View(hobi);
        }
   
        [HttpPost]
        public ActionResult Index(TblHobiler p)
        {
            var hobi = repo.Find(x=>x.ID==1);
            hobi.Aciklama1 = p.Aciklama1;
            hobi.Aciklama2 = p.Aciklama2;
            repo.TUpdate(hobi);
         return RedirectToAction("Index");
        }
    }
}