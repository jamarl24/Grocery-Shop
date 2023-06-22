using Grocer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.Pages
{
    public class DetailsModel : PageModel
    {
        public List<GroceryItem> Foods = Inventory.ToList();
        public GroceryItem? CurrentFood;
        public async Task<IActionResult> OnGet(string name)
        {
            using (StreamWriter sw = new("log.txt", append: true))
            {
                await sw.WriteLineAsync($"{DateTime.Now} {name}");
            }
            CurrentFood = Foods.Find(food => food.Name.ToLower() == name.ToLower());
            if (CurrentFood == null) { return NotFound(); }
            return Page();
        }
    }
}
