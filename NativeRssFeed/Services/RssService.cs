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
        public rssChannel GetChannelFromUrl(string url)
        {
            var serializer = new XmlSerializer(typeof(rss));
            using (var reader = XmlReader.Create(url))
            {
                try
                {
                    var root = (rss)serializer.Deserialize(reader);
                    if (root != null && root.channel != null)
                    {
                        return root.channel;
                    }
                }
                catch (Exception)
                {
                    return null;
                }

                return null;
            }

        }
    }
}
