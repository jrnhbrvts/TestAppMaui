using TestApp.Contracts;
using TestApp.Models;

namespace TestApp.Controls;

public class FeedDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate FeedViralTemplate { get; set; }
    public DataTemplate FeedNewsTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var feedItemType = ((FeedItem)item).Type;
        switch (feedItemType)
        {
            case FeedItemType.News:
                return FeedNewsTemplate;
            default:
                return FeedViralTemplate;
        }
    }
}