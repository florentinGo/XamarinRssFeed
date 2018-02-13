using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NativeRssFeed.Models
{
    [XmlElement(ElementName = "channel")]
    public class RssItem
    {
        public RssItem()
        {
        }
        [XmlElement(ElementName = "channel")]
        public string Title { get; set; }
        [XmlElement(ElementName = "channel")]
        public string PubDate { get; set; }
        [XmlElement(ElementName = "channel")]
        public string Link { get; set; }
        [XmlElement(ElementName = "channel")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "channel")]
        public string Author { get; set; }
        [XmlElement(ElementName = "channel")]
        public string Thumbnail { get; set; }
        [XmlElement(ElementName = "channel")]
        public string Description { get; set; }
        [XmlElement(ElementName = "channel")]
        public string Content { get; set; }
        [XmlElement(ElementName = "channel")]
        public Enclosure Enclosure { get; set; }
        [XmlElement(ElementName = "channel")]
        public List<object> Categories { get; set; }
    }
}
