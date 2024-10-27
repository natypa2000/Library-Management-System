using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using WebApplication8.Pages.Models;
using WebApplication8.Pages.Services;

namespace WebApplication8.Pages
{
    public class BookActionsModel : PageModel
    {
        private readonly BookService _bookService;
        [BindProperty]
        public Books books { get; set; }

        private readonly SubscribersService _subscribersService;
        [BindProperty]
        public Subscribers subscribers { get; set; }
        public bool result { get; set; }
        public BookActionsModel(BookService bookService, SubscribersService subscribersService)
        {
            _bookService = bookService;
            _subscribersService = subscribersService;
        }
        public IActionResult OnPostLoanBook()
        {
            var subscriber = _subscribersService.GetId(subscribers.Id);
            if (subscriber != null && subscriber.booksId.Count<3)
            {
                subscriber.booksId.Add(books.Id);
                _subscribersService.UpdateSub(subscriber.Id,subscriber);
            }
            return RedirectToPage();
        }
        public IActionResult OnPostReturnBook()
        {
            var subscriber = _subscribersService.GetId(subscribers.Id);
            if (subscriber != null && subscriber.booksId.Count >0)
            {
                subscriber.booksId.Remove(books.Id);
                _subscribersService.UpdateSub(subscriber.Id, subscriber);
            }
            return RedirectToPage();
        }
    }
}
