using BookDbEfCoreRazorPagesProject.Data;
using BookDbEfCoreRazorPagesProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookDbEfCoreRazorPagesProject.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookContext _context;

        public CreateModel(BookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
