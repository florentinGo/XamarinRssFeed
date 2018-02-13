using System;
using System.Xml.Serialization;

namespace NativeRssFeed.Models
{
    [XmlRoot(ElementName = "rss")]
    public class RssRoot
    {
        public RssRoot()
        {
        }
       
        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }
        [XmlAttribute(AttributeName = "xmlns.dc")]
        public string Dc { get; set; }
        [XmlAttribute(AttributeName = "xmlns.media")]
        public string Media { get; set; }
        [XmlAttribute(AttributeName = "xmlns.atom")]
        public string Atom { get; set; }
        [XmlAttribute(AttributeName = "xmlns.nyt")]
        public string Nyt { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

    }
}
