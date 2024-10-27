using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication8.Pages.Models;
using WebApplication8.Pages.Services;

namespace WebApplication8.Pages
{
    public class ManageModel : PageModel
    {
        private readonly BookService _bookService;
        [BindProperty]
        public Books books { get; set; }

        private readonly SubscribersService _subscribersService;
        [BindProperty]
        public Subscribers subscribers { get; set; }
        public bool result { get; set; }
        public ManageModel(BookService bookService, SubscribersService subscribersService)
        {
            _bookService = bookService;
            _subscribersService = subscribersService;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPostInsertBook() 
        {
            result = _bookService.InsertBook(books);
            return RedirectToPage();
        }
        public IActionResult OnPostInsertSub()
        {
            result = _subscribersService.InsertSub(subscribers);
            return RedirectToPage();
        }
    }
}
