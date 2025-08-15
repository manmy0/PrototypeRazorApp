using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazor.Models;
using PrototypeRazorApp.Data;

namespace PrototypeRazorApp.Pages.ProfilePage
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DetailsModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
