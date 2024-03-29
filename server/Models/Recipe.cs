namespace AllSpice.Models;

public class Recipes : IdStuff
{
    public string Title { get; set; }
    public string Instructions { get; set; }
    public string Img { get; set; }
    public string Category { get; set; }
    public Account Creator { get; set; }
    public string CreatorId { get; set; }
}