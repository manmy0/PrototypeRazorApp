using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.DashboardPage
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public DetailsModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Dashboard Dashboard { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dashboard = await _context.Dashboard.FirstOrDefaultAsync(m => m.Id == id);

            if (dashboard is not null)
            {
                Dashboard = dashboard;

                return Page();
            }

            return NotFound();
        }
    }
}
