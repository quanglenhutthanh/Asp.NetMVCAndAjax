using Core;
using Core.Reposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    public class UnobtrusiveAjaxController : Controller
    {
        private GadgetRepository gadgetRepo = new GadgetRepository(new DataContext());
        private CategoryRepository categoryRepo = new CategoryRepository(new DataContext());
        //
        // GET: /UnobtrusiveAjax/
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GadgetByCategoryData(int id)
        {
            var gadgets = gadgetRepo.Get();
            if (id != -1)
            {
                gadgets = gadgetRepo.GetByCategoryId(id);
            }
            return PartialView(gadgets);
        }

        public ActionResult GadgetByCategory(int id = -1)
        {
            return View((object)id);
        }
	}
}