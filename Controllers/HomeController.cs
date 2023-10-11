using Multi_StepRegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Multi_StepRegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveFormDetails(FormDetails userDetails)
        {
            var query = $"Insert into FormDetails values('{userDetails.FullName}','{userDetails.Address}','{userDetails.State}','{userDetails.City}','{userDetails.UserName}','{userDetails.Password}')";
            return Json(Connection.Save(query));
        }
    }
}