using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Networking
{
    public int Id { get; set; }
    public String? Name { get; set; }
    public String? Company { get; set; }
    public String? ContactInfo { get; set; }
    public String? ProgressNotes { get; set; }
}
