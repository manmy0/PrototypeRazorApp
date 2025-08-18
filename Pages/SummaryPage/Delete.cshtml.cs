using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.SummaryPage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Summary Summary { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summary = await _context.Summary.FirstOrDefaultAsync(m => m.Id == id);

            if (summary is not null)
            {
                Summary = summary;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summary = await _context.Summary.FindAsync(id);
            if (summary != null)
            {
                Summary = summary;
                _context.Summary.Remove(Summary);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
