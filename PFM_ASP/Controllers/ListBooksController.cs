using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace PFM_ASP.Controllers
{
    [Authorize]
    public class ListBooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ListBooks
        public ActionResult Index()
        {
            var list = db.Categories.ToList();
            return View(list);
        }
    }
}