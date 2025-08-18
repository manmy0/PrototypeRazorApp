using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.NetworkingPage
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DetailsModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Networking Networking { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networking = await _context.Networking.FirstOrDefaultAsync(m => m.Id == id);

            if (networking is not null)
            {
                Networking = networking;

                return Page();
            }

            return NotFound();
        }
    }
}
