using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;

namespace PrototypeRazorApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PrototypeRazorApp.Models.Profile> Profile { get; set; } = default!;
        public DbSet<PrototypeRazorApp.Models.Dashboard> Dashboard { get; set; } = default!;
        public DbSet<PrototypeRazorApp.Models.CDL> CDL { get; set; } = default!;
        public DbSet<PrototypeRazorApp.Models.Competencies> Competencies { get; set; } = default!;
        public DbSet<PrototypeRazorApp.Models.Goals> Goals { get; set; } = default!;
        public DbSet<PrototypeRazorApp.Models.Networking> Networking { get; set; } = default!;
        public DbSet<PrototypeRazorApp.Models.Summary> Summary { get; set; } = default!;
    }
}
