using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LAB6DB.Pages
{
    public class IndexModel : PageModel
    { 
        public static List<string> Tasks { get; set; } = new List<string>();

        public void OnGet() { }
    }
}

