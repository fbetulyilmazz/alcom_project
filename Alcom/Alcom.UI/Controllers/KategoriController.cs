using Alcom.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
              var model=  repo.Listele();
            return View(model);
            }
        }
    }
}