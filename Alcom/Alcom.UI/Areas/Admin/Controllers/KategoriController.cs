using Alcom.BLL;
using Alcom.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Admin/Kategori
        [HttpGet]
        public ActionResult Ekle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kategori model)
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                model.KayitTarihi = DateTime.Now;
               bool durum= repo.Ekle(model);
                TempData["Mesaj"] = durum ? new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Kayıt eklendi." } } : new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Kayıt eklenemedi." } };
                    return View();
            }
            
        }
    }
}