using System.Linq;
using System.Web.Http;
using BookShop.Models;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;

namespace BookShop.Controllers {
  [BreezeController]
  public class BookShopController : ApiController {

    private readonly EFContextProvider<BookContext> _contextProvider = new EFContextProvider<BookContext>();

    [HttpGet]
    public string Metadata() {
      return _contextProvider.Metadata();
    }

    // ~/breeze/BookShop/Books
    // ~/breeze/BookShop/Books?$filter=Title eq 'ASP.NET 4.0'
    [HttpGet]
    public IQueryable<Book> Books() {
      return _contextProvider.Context.Books;
    }

    [HttpGet]
    public IQueryable<Reader> Readers() {
      return _contextProvider.Context.Readers;
    }

    [HttpGet]
    public IQueryable<Category> Categories() {
      return _contextProvider.Context.Categories;
    }

    // ~/breeze/BookShop/SaveChanges
    [HttpPost]
    public SaveResult SaveChanges(JObject saveBundle) {
      return _contextProvider.SaveChanges(saveBundle);
    }
  }
}