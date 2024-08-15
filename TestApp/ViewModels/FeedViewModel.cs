using System.Collections.ObjectModel;
using System.Windows.Input;
using TestApp.Contracts;
using TestApp.Models;

namespace TestApp.ViewModels;

public class FeedViewModel
{
    public FeedViewModel()
    {
        //Initial data
        LoadMore();
    }

    public ObservableCollection<FeedItem> FeedItems { get; set; } = [];
    
    private void LoadMore ()
    {
        foreach (var item in GetFeedItems())
        {
            FeedItems.Add(item);
        }
    }
    
    private List<FeedItem> GetFeedItems()
    {
        var feedItems = new List<FeedItem>
        {
            
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 0",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.News)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 1",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Picture 1",
                            Image = "https://media.prod.by433.com/media/image/431d1f86-a98f-4a00-b49d-f6601905e182.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        },
                        new Slide
                        {
                            Id = 98744,
                            Title = "",
                            Description = "Picture 2",
                            Image = "https://media.prod.by433.com/media/image/63fa5ea6-c07b-42f8-a006-99e5f3790f7c.jpeg",
                            Position = 2,
                            ButtonText = "",
                            Url = ""
                        },
                        new Slide
                        {
                            Id = 98745,
                            Title = "",
                            Description = "Picture 3",
                            Image = "https://media.prod.by433.com/media/image/dfb57613-9ed5-4804-a153-7fb99358a0a4.jpeg",
                            Position = 3,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 2",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 3",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 4",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 5",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
                         new("47532", FeedItemType.News)
                         {
                             Date = DateTime.Today,
                             IsPinned = false,
                             IsPlaceholder = false,
                             News = new News
                             {
                                 Id = 47532,
                                 Title = "Item 1",
                                 ShowComments = true,
                                 TotalLikes = 6,
                                 TotalComments = 5,
                                 Slides =
                                 [
                                     new Slide
                                     {
                                         Id = 98743,
                                         Title = "",
                                         Description = "Picture 1",
                                         Image = "https://media.prod.by433.com/media/image/431d1f86-a98f-4a00-b49d-f6601905e182.jpeg",
                                         Position = 1,
                                         ButtonText = "",
                                         Url = ""
                                     },
                                     new Slide
                                     {
                                         Id = 98744,
                                         Title = "",
                                         Description = "Picture 2",
                                         Image = "https://media.prod.by433.com/media/image/63fa5ea6-c07b-42f8-a006-99e5f3790f7c.jpeg",
                                         Position = 2,
                                         ButtonText = "",
                                         Url = ""
                                     },
                                     new Slide
                                     {
                                         Id = 98745,
                                         Title = "",
                                         Description = "Picture 3",
                                         Image = "https://media.prod.by433.com/media/image/dfb57613-9ed5-4804-a153-7fb99358a0a4.jpeg",
                                         Position = 3,
                                         ButtonText = "",
                                         Url = ""
                                     }
                                 ],
                                 Date = DateTime.Today
                             }
                         },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 6",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 7",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 8",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 9",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 10",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 11",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 12",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 13",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 14",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 15",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 16",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 17",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
                         new("47532", FeedItemType.News)
                         {
                             Date = DateTime.Today,
                             IsPinned = false,
                             IsPlaceholder = false,
                             News = new News
                             {
                                 Id = 47532,
                                 Title = "Item 1",
                                 ShowComments = true,
                                 TotalLikes = 6,
                                 TotalComments = 5,
                                 Slides =
                                 [
                                     new Slide
                                     {
                                         Id = 98743,
                                         Title = "",
                                         Description = "Picture 1",
                                         Image = "https://media.prod.by433.com/media/image/431d1f86-a98f-4a00-b49d-f6601905e182.jpeg",
                                         Position = 1,
                                         ButtonText = "",
                                         Url = ""
                                     },
                                     new Slide
                                     {
                                         Id = 98744,
                                         Title = "",
                                         Description = "Picture 2",
                                         Image = "https://media.prod.by433.com/media/image/63fa5ea6-c07b-42f8-a006-99e5f3790f7c.jpeg",
                                         Position = 2,
                                         ButtonText = "",
                                         Url = ""
                                     },
                                     new Slide
                                     {
                                         Id = 98745,
                                         Title = "",
                                         Description = "Picture 3",
                                         Image = "https://media.prod.by433.com/media/image/dfb57613-9ed5-4804-a153-7fb99358a0a4.jpeg",
                                         Position = 3,
                                         ButtonText = "",
                                         Url = ""
                                     }
                                 ],
                                 Date = DateTime.Today
                             }
                         },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 18",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 19",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 20",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 21",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47535", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47535,
                    Title = "Item 22",
                    ShowComments = true,
                    TotalLikes = 1337,
                    TotalComments = 1337,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98748,
                            Title = "The quarter-finals are set!",
                            Description = "The race for Gold is on!",
                            Image = "https://media.prod.by433.com/media/image/1b0b9094-3638-4a2e-a5db-892370a384eb.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.Viral)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 23",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Reminder: El Toro bagged 24 goals last season.",
                            Image = "https://media.prod.by433.com/media/image/7bb349d9-e70e-4e58-8fcb-5bd6d19f7edd.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            },
            new("47532", FeedItemType.News)
            {
                Date = DateTime.Today,
                IsPinned = false,
                IsPlaceholder = false,
                News = new News
                {
                    Id = 47532,
                    Title = "Item 1",
                    ShowComments = true,
                    TotalLikes = 6,
                    TotalComments = 5,
                    Slides =
                    [
                        new Slide
                        {
                            Id = 98743,
                            Title = "",
                            Description = "Picture 1",
                            Image = "https://media.prod.by433.com/media/image/431d1f86-a98f-4a00-b49d-f6601905e182.jpeg",
                            Position = 1,
                            ButtonText = "",
                            Url = ""
                        },
                        new Slide
                        {
                            Id = 98744,
                            Title = "",
                            Description = "Picture 2",
                            Image = "https://media.prod.by433.com/media/image/63fa5ea6-c07b-42f8-a006-99e5f3790f7c.jpeg",
                            Position = 2,
                            ButtonText = "",
                            Url = ""
                        },
                        new Slide
                        {
                            Id = 98745,
                            Title = "",
                            Description = "Picture 3",
                            Image = "https://media.prod.by433.com/media/image/dfb57613-9ed5-4804-a153-7fb99358a0a4.jpeg",
                            Position = 3,
                            ButtonText = "",
                            Url = ""
                        }
                    ],
                    Date = DateTime.Today
                }
            }
        };

        return feedItems;
    }
}