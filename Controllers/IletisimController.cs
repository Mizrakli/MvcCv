using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekCV.Repositories;
using OrnekCV.Models.entity;
namespace OrnekCV.Controllers
{
    public class IletisimController : Controller
    {
        GenericRepository<Tbliletisim> repo = new GenericRepository<Tbliletisim>(); 
        // GET: Iletisim
        public ActionResult Index()
        {
            var mesaj = repo.List();
            return View(mesaj);
        }
    }
}