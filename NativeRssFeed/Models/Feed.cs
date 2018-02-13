using System;
namespace NativeRssFeed.Models
{
    public class Feed
    {
        public Feed()
        {
        }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
