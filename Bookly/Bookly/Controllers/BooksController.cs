using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;

namespace Bookly.Controllers
{
    
    public class BooksController : Controller
    {
        private ApplicationDbContext db;

        public BooksController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Books
        public ViewResult Index()
        {
            var books = db.Books.ToList();//This equal to select * from Books
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = db.Books.SingleOrDefault(c => c.ID == id);
            if (book == null)
                return HttpNotFound();
            return View(book);
        }
        
       
    }
}