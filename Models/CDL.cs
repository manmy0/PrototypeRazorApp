using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class CDL
{
    public int Id { get; set; }
    public String? Document { get; set; }
    public String? Description { get; set; }
    public String? Link { get; set; }
    public DateOnly DateUploaded { get; set; }
    public String? ElevatorPitch { get; set; }
    public String? CompaniesContact { get; set; }
    public String? Questions { get; set; }
    public String? UpcomingEvents { get; set; }
}
