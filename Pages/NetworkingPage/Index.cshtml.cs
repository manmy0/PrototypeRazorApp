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
    public class IndexModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public IndexModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Networking> Networking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Networking = await _context.Networking.ToListAsync();
        }
    }
}
