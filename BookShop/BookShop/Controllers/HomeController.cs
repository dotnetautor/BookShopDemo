using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers {
  public class HomeController : Controller {
    // GET: Home
    public ActionResult Index() {
      return View();
    }



    public ActionResult Dashboard() {
      return PartialView("_dashboard");
    }

    public ActionResult BooksView() {
      return PartialView("_booksView");
    }

    public ActionResult ReadersView() {
      return PartialView("_readersView");
    }

    public ActionResult BookEdit() {
      return PartialView("_bookEdit");
    }
  }
}