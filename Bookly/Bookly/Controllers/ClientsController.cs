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
        private ApplicationDbContext db;
        public ClientsController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        public ViewResult Index()
        {
            var clients = db.Clients.ToList();//This equal to select * from Clients
            return View(clients);
        }


        // GET: Clients
        public ActionResult Random()
        {
            var client1 = new Client { Name = "hadi"};
            return View(client1);
        }
    }
}