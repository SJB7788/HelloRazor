using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindHCI.Models.NW;

namespace NorthwindHCI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Category> CategoriesInDB { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        NorthwindContext _context = new();
        CategoriesInDB = _context.Categories.Select(c => new Category {
            CategoryName = c.CategoryName,
        }).ToList();

    }
}
