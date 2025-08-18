﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Data;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Pages.NetworkingPage
{
    public class EditModel : PageModel
    {
        private readonly PrototypeRazorApp.Data.ApplicationDbContext _context;

        public EditModel(PrototypeRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Networking Networking { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networking =  await _context.Networking.FirstOrDefaultAsync(m => m.Id == id);
            if (networking == null)
            {
                return NotFound();
            }
            Networking = networking;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Networking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NetworkingExists(Networking.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NetworkingExists(int id)
        {
            return _context.Networking.Any(e => e.Id == id);
        }
    }
}
