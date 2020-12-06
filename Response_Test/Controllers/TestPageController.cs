using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Response_Test.Models;
using Response_Test.Repository;
using Response_Test.Models.ViewModel;

namespace Response_Test.Controllers
{
    public class TestPageController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Home(TesterInfomationModel tester)
        {
            if (ModelState.IsValid)
            {
                TesterBuildRepository build = new TesterBuildRepository();
                build.BuildTester(tester);
            }
            return View("FirstTest");
        }

        public ActionResult FirstTest()
        {
            return View();
        }

        public ActionResult SecondTest()
        {
            return View();
        }

        public ActionResult ThirdTest()
        {
            return View();
        }

        public ActionResult FourthTest()
        {
            return View();
        }

        public ActionResult FifthTest()
        {
            return View();
        }

        public ActionResult SixFifthTest()
        {
            return View();
        }

        public ActionResult SeventhTest()
        {
            return View();
        }
    }
}