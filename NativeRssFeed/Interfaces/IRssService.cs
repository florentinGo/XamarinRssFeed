using System;
using NativeRssFeed.Models;

namespace NativeRssFeed.Interfaces
{
    public interface IRssService
    {
        Channel GetChannelFromUrl(string url);
    }
}
