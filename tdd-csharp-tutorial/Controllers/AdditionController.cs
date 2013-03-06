using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tdd_csharp_tutorial.Models;

namespace tdd_csharp_tutorial.Controllers
{
    public class AdditionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(AdditionViewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                model.Result = model.First + model.Second;
            }

            return View(model);
        }
    }
}
