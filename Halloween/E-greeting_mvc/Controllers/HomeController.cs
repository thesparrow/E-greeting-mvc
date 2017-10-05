using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace E_greeting_mvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /* Responsible for collecting form data and verifying reCAPTCHA form*/

        [HttpPost]
        public ActionResult SubmitForm(FormCollection form)
        {
            //TODO: Collect form data
            //TODO: Create a MailboxAddress 

            var response = Request["g-recaptcha-response"];
            //secret that was generated in key value pair
            const string secret = "6LfVpjEUAAAAAK0FdygAgh0P1gZ8QU24ildwT86r";

            var client = new WebClient();
            var reply =
                client.DownloadString(
                    string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Dark_theme()
        {
            ViewBag.Message = "Your dark theme.";

            return View();
        }
    }
}