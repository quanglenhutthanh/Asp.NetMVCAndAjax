using Core;
using Core.Reposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    public class BasicAjaxController : Controller
    {
        private GadgetRepository gadgetRepo = new GadgetRepository(new DataContext());
        //
        // GET: /Gadget/
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetGadgets()
        {
            System.Threading.Thread.Sleep(5000);
            var gadgets = gadgetRepo.Get();
            return PartialView(gadgets);
        }

        public PartialViewResult ChangePrice(int id,decimal newPrice)
        {
            var gadget = gadgetRepo.GetByID(id);
            gadget.Price = newPrice;
            
            gadgetRepo.Update(gadget);
            gadgetRepo.Save();
            return PartialView("GetGadgets",gadgetRepo.Get());
        }
	}
}