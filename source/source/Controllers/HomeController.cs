using Core.Entities;
using Core.Infrastructure;
using Core.Reposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace source.Controllers
{
    public class HomeController : Controller
    {
        private GadgetRepository gadgetRepro;
        private CategoryRepository categoryRepo;
        public HomeController()
        {
            gadgetRepro = new GadgetRepository(new Core.DataContext());
            categoryRepo = new CategoryRepository(new Core.DataContext());
        }
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var test = gadgetRepro.Get();
            return View();
        }

        public ActionResult List()
        {
            var test = categoryRepo.Get(c => c.CategoryID == 1,q=>q.OrderBy(i => i.DateCreated));
            return View();
        }

        public void CreateSampleCategory()
        {
            var category = new Category
            {
                CategoryID = 1,
                Name = "cat1"
            };
            categoryRepo.Insert(category);
            categoryRepo.Save();
        }
    }
}