using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Namespace.Model;

namespace MyApp.Namespace
{
    public class ZodiacModel : PageModel
    {
        public int Year { get; set; }

        public void OnGet()
        {
            ViewData["Zodiac"] = "";
        }

        public void OnPost(Zodiac model)
        {
            ViewData["Zodiac"] = model.GetZodiac();
        }
    }
}