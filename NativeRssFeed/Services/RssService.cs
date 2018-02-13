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
            var serializer = new XmlSerializer(typeof(RssRoot));
            using( XmlReader reader = XmlReader.Create(url)){
                try{
                    var root = (RssRoot)serializer.Deserialize(reader);
                    if (root != null && root.Channel != null)
                    {
                        return root.Channel;
                    }   
                }
                catch(Exception error){
                    return null;
                }

                return null;
            }

        }
    }
}
