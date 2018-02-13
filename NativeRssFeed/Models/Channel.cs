using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NativeRssFeed.Models
{
    [XmlElement(ElementName = "channel")]
    public class Channel
    {
        public Channel()
        {
        }
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "fee")]
        public Feed Feed { get; set; }
        [XmlElement(ElementName = "item")]
        public List<RssItem> Items { get; set; }
    }
}
