using Foundation;
using System;
using UIKit;
using NativeRssFeed.Models;
using NativeRssFeed.Services;
using NativeRssFeed.iOS.View;

namespace NativeRssFeed.iOS
{
    public partial class RssViewController : UIViewController
    {
        public string Url { get; set; }
        public rssChannel Channel { get; set; }
        public RssService RssService { get; set; }
        UIWebView webView;

        public RssViewController (IntPtr handle) : base (handle)
        {
            this.Channel = new rssChannel();
            this.RssService = new RssService();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (!string.IsNullOrEmpty(this.Url))
            {
                this.Channel = this.RssService.GetChannelFromUrl(this.Url);
                webView = new UIWebView(UIScreen.MainScreen.Bounds);
                View.Add(webView);

                // Intercept URL loading to handle native calls from browser

                // Render the view from the type generated from RazorView.cshtml

                var template = new DisplayRssChannel() { Model = this.Channel };
                var page = template.GenerateString();
                webView.LoadHtmlString(page, NSBundle.MainBundle.BundleUrl);
            }
        }

    }
}