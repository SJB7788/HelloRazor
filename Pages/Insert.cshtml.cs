using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindHCI.Models.NW;

namespace NorthwindHCI.Pages
{
    public class InsertModel : PageModel
    {
        [BindProperty]
        public string CategoryName { get; set; }

        [BindProperty]
        public string CategoryDescription { get; set; }
        public Utils utils = new();
        public void OnGet()
        {
        }

        public void OnPost()
        {
            utils.InsertModel(CategoryName, CategoryDescription);
        }

    }
}
