using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication8.Pages.Models;
using WebApplication8.Pages.Services;

namespace WebApplication8.Pages
{
    public class DisplayModel : PageModel
    {
        private readonly BookService _bookService;
        [BindProperty]
        public List<Books> books { get; set; }

        private readonly SubscribersService _subscribersService;
        [BindProperty]
        public List<Subscribers> subscribers { get; set; }
        public bool result { get; set; }
        public DisplayModel(BookService bookService, SubscribersService subscribersService)
        {
            _bookService = bookService;
            _subscribersService = subscribersService;
        }
        public void OnGet()
        {
            subscribers = _subscribersService.GetSubs();
            books=_bookService.GetBooks();
        }
    }
}
