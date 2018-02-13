using System;
using System.Collections.Generic;

namespace NativeRssFeed.Models
{
    public class RssItem
    {
        public RssItem()
        {
        }
        public string Title { get; set; }
        public string PubDate { get; set; }
        public string Link { get; set; }
        public string Guid { get; set; }
        public string Author { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public Enclosure Enclosure { get; set; }
        public List<object> Categories { get; set; }
    }
}
