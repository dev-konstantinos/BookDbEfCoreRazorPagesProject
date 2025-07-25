using BookDbEfCoreRazorPagesProject.Data;
using BookDbEfCoreRazorPagesProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookDbEfCoreRazorPagesProject.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookContext _context;

        public IndexModel(BookContext context)
        {
            _context = context;
        }

        public IList<Book> BookList { get; set; }

        public async Task OnGetAsync()
        {
            BookList = await _context.Books.ToListAsync();
        }
    }
}
