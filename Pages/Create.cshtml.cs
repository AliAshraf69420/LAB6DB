using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LAB6DB.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string TaskTitle { get; set; }

        public IActionResult OnPost()
        { 
            IndexModel.Tasks.Add(TaskTitle);
            return RedirectToPage("Index");
        }
    }

}
