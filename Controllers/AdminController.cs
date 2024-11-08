using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reservation.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult SignIn()
        {
            return View("~/Views/Admin/SignIn.cshtml");
        }

        public ActionResult RoomsManagement()
        {
            return View("~/Views/Admin/RoomsManagement.cshtml");
        }
    }
}