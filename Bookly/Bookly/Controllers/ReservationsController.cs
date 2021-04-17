using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;

namespace Bookly.Controllers
{
    public class ReservationsController : Controller
    {


        private ApplicationDbContext db;
        public ReservationsController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        // GET: Reservations
        public ViewResult Index()
        {
            var reservations = db.Reservations.ToList();//This equal to select * from Clients
            return View(reservations);
        }
       
       
    }
}