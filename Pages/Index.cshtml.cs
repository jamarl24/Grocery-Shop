using Grocer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Rating { get; set; }
        [BindProperty]
        public string Feedback { get; set; }
        public List<GroceryItem> Foods = Inventory.ToList(); 


        public void OnGet()
        {

        }
    }
}