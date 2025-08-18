using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.GoalsPage
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DetailsModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Goals Goals { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goals = await _context.Goals.FirstOrDefaultAsync(m => m.Id == id);

            if (goals is not null)
            {
                Goals = goals;

                return Page();
            }

            return NotFound();
        }
    }
}
