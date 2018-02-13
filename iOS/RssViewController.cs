using Foundation;
using System;
using UIKit;
using NativeRssFeed.Models;
using NativeRssFeed.Services;

namespace NativeRssFeed.iOS
{
    public partial class RssViewController : UIViewController
    {
        public string Url { get; set; }
        public Channel Channel { get; set; }
        public RssService RssService { get; set; }

        public RssViewController (IntPtr handle) : base (handle)
        {
            this.Channel = new Channel();
            this.RssService = new RssService();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (!string.IsNullOrEmpty(this.Url))
            {
                this.Channel = this.RssService.GetChannelFromUrl(this.Url);
            }
        }

    }
}