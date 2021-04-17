using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;
using System.Data.Entity;

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
            var reservations = db.Reservations.Include(c => c.Book).ToList();
            //This equal to select * from Clients
            return View(reservations);
        }

        public async Task<ActionResult> Delete(int id)
        {
            Reservation empresa = await db.Reservations.FindAsync(id);
            db.Reservations.Remove(empresa);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}