using BookDbEfCoreRazorPagesProject.Data;
using BookDbEfCoreRazorPagesProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookDbEfCoreRazorPagesProject.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly BookContext _context;

        public DeleteModel(BookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Book = await _context.Books.FindAsync(id);
            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Book = await _context.Books.FindAsync(id);
            if (Book != null)
            {
                _context.Books.Remove(Book);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
