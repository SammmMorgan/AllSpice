namespace AllSpice.Models;

public class Ingredient : IdStuff
{
    public string Name { get; set; }
    public string Quantity { get; set; }
    public int RecipeId { get; set; }
}