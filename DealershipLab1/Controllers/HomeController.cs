using DealershipLab1.AboutPageModels;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DealershipLab1.Models;


namespace DealershipLab1.AboutPageModels
{
    public class HomeController : Controller
    {

        private AutoDBContext db = new AutoDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var GenreLst = new List<string>();
            var data = from m in db.AutoModelDataBase
                       orderby m.Make
                        select m.Make;

            GenreLst.AddRange(data.Distinct()); 
                       
                       //group m by m.Make into MakeGroup
                 
            /*
                       new SpecificMakeGroup()
                       {
                           Make = MakeGroup.Key,
                           carCount = MakeGroup.Count()
                       };
            */
            return View(data);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}