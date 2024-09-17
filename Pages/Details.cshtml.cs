using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace MyApp.Namespace
{
    public class DetailsModel : PageModel
    {
        public void OnGet(int? id)
        {
            Process proc = Process.GetProcessById(id!.Value);
            ViewData["Proc"] = proc;   
        }
    }
}
