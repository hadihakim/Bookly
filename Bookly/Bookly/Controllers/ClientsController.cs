using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;

namespace Bookly.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Random()
        {
            var client1 = new Client { Name = "hadi"};
            return View(client1);
        }
    }
}