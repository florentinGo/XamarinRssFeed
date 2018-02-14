using Foundation;
using System;
using UIKit;
using NativeRssFeed.Models;
using NativeRssFeed.Services;
using NativeRssFeed.iOS.DataSources;

namespace NativeRssFeed.iOS
{
    public partial class RssItemsViewController : UITableViewController
    {
        public string Url { get; set; }
        public rssChannel Channel { get; set; }
        public RssService RssService { get; set; }
        public RssItemsViewController (IntPtr handle) : base (handle)
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
                var source = new TableRssSource(this.Channel.item);
                this.rssElements.Source = source;
                this.rssElements.AllowsSelection = true;
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier.Equals("ItemDetailSegue"))
            {
                ItemDetailViewController viewController = (ItemDetailViewController)segue.DestinationViewController;
                var cell = sender as UITableViewCell;
                var source = this.rssElements.Source as TableRssSource;
                var element = source.GetItem(this.rssElements.IndexPathForSelectedRow.Row);
                viewController.Url = element.link;
            }
        }

       


    }
}