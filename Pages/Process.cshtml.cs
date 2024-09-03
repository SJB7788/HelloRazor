using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Hello Worldadjhaskjdhaksd";
            
            string[] people = {"Jermany", "Seena", "Miata", "Neesan"};
            ViewData["People"] = people;
        }
    }
}
