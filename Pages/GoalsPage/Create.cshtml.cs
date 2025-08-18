using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.GoalsPage
{
    public class CreateModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public CreateModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Goals Goals { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Goals.Add(Goals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
