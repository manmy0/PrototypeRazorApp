using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorApp.Data;

namespace PrototypeRazorApp.Pages.ProfilePage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Profile Profile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile.FirstOrDefaultAsync(m => m.Id == id);

            if (profile is not null)
            {
                Profile = profile;

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

            var profile = await _context.Profile.FindAsync(id);
            if (profile != null)
            {
                Profile = profile;
                _context.Profile.Remove(Profile);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
