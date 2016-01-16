using Core;
using Core.Reposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    public class JsonController : Controller
    {
        private GadgetRepository gadgetRepo = new GadgetRepository(new DataContext());
        private CategoryRepository categoryRepo = new CategoryRepository(new DataContext());
        //
        // GET: /Json/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetJsonData()
        {
            var data = categoryRepo.Get().ToArray();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
	}
}