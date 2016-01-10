using Core;
using Core.Reposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    public class DropdownAjaxController : Controller
    {
        private GadgetRepository gadgetRepo = new GadgetRepository(new DataContext());
        private CategoryRepository categoryRepo = new CategoryRepository(new DataContext());
        //
        // GET: /DropdownAjax/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryList()
        {
            var categories = categoryRepo.Get();
            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(categories.ToArray(), "CategoryID", "Name"), JsonRequestBehavior.AllowGet);
            }
            return View("Index");
        }

        public ActionResult GadgetByCategory(int id)
        {
            var gadgets = gadgetRepo.GetByCategoryId(id);
            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(gadgets.ToArray(), "GadgetID", "Name"), JsonRequestBehavior.AllowGet);
            }
            return View("Index");
        }
	}
}