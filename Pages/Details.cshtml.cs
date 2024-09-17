using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindHCI.Models.NW;

namespace NorthwindHCI.Pages
{
    public class DetailsModel : PageModel
    {
        public IQueryable<NorthwindHCI.Models.NW.Category> query;
        public void OnGet(string? categoryName)
        {
            NorthwindContext _context = new();
            query = _context.Categories.Where(
                c => c.CategoryName.Equals(categoryName)
            );
        }
    }
}
