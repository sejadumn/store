using Microsoft.AspNetCore.Mvc;

// /search?query=b1b
 namespace Store.Web.Controllers
{
    public class SearchController : Controller 
    {
        private readonly BookService bookService;

        private readonly IBookRepository bookRepository;
        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index( string query)
        {
            var books = bookService.GetAllByQuery(query);

            return View(books);
        }
    }
}
