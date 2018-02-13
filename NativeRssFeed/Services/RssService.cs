using System;
using System.Xml;
using System.Xml.Serialization;
using NativeRssFeed.Interfaces;
using NativeRssFeed.Models;

namespace NativeRssFeed.Services
{
    public class RssService : IRssService
    {
        public RssService()
        {
        }
        public Channel GetChannelFromUrl(string url)
        {
            var channel = new Channel();
            var serializer = new XmlSerializer(typeof(Channel));
            using( XmlReader reader = XmlReader.Create(url)){
                channel = (Channel)serializer.Deserialize(reader);
                return channel;
            }
        }
    }
}
