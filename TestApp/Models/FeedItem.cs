using TestApp.Contracts;

namespace TestApp.Models;

public class FeedItem(string id, FeedItemType type, DateTime date, bool isPinned = false)
{
    /// <summary>
    ///     Constructor for placeholder FeedItems
    /// </summary>
    public FeedItem(string id, FeedItemType type) : this(id, type, new DateTime()) => IsPlaceholder = true;

    public string Id { get; set; } = id;
    public FeedItemType Type { get; set; } = type;
    public DateTime Date { get; set; } = date;
    public bool IsPinned { get; set; } = isPinned;
    public bool IsPlaceholder { get; set; }
    public News? News { get; set; }
}