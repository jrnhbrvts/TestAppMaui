namespace TestApp.Models;

public class News
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool ShowComments { get; set; }
    public int TotalLikes { get; set; }
    public int TotalComments { get; set; }
    public List<Slide> Slides { get; set; } = new();
    public DateTime Date { get; set; }
}