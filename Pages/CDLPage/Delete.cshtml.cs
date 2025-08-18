using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.CDLPage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CDL CDL { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cdl = await _context.CDL.FirstOrDefaultAsync(m => m.Id == id);

            if (cdl is not null)
            {
                CDL = cdl;

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

            var cdl = await _context.CDL.FindAsync(id);
            if (cdl != null)
            {
                CDL = cdl;
                _context.CDL.Remove(CDL);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
