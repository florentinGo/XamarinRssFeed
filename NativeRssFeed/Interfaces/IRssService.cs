using System;
using NativeRssFeed.Models;

namespace NativeRssFeed.Interfaces
{
    public interface IRssService
    {
        rssChannel GetChannelFromUrl(string url);
    }
}
