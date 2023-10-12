using PigLatinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PigLatinMVC.Controllers
{
    public class TranslateController : Controller
    {
        // GET: Translate
        public ActionResult Translate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Translate(English_PigLatin model)
        {
            if(ModelState.IsValid)
            {
                TranslatePigLatin translate = new TranslatePigLatin();

                string english = model.English_text;

                string pigLatin = translate.Translate(english);

                model.PigLatin_text = pigLatin;

                return View("DisplayPigLatin", model);
            }

            return View(model);
        }
    }
}