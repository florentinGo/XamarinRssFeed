using System;
using System.Collections.Generic;

namespace NativeRssFeed.Models
{
    public class Channel
    {
        public Channel()
        {
        }
        public string Status { get; set; }
        public Feed Feed { get; set; }
        public List<RssItem> Items { get; set; }
    }
}
