using NorthwindHCI.Models.NW;

public class Utils {
    public void InsertModel(string categoryName, string categoryDescription) {
        NorthwindContext context = new();
        context.Categories.Add(new Category {
            CategoryName = categoryName,
            Description = categoryDescription
        });
        
        context.SaveChanges();
    }
}