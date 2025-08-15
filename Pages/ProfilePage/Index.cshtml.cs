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
    public class IndexModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public IndexModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Profile> Profile { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Profile = await _context.Profile.ToListAsync();
        }
    }
}
