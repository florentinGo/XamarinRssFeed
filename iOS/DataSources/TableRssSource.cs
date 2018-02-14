using System;
using System.Collections.Generic;
using Foundation;
using NativeRssFeed.iOS.View;
using NativeRssFeed.Models;
using UIKit;

namespace NativeRssFeed.iOS.DataSources
{
    public class TableRssSource : UITableViewSource
    {
        private rssChannelItem[] items;
        NSString cellIdentifier = new NSString("rssChannelItem");

        public TableRssSource(rssChannelItem[] items)
        {
            this.items = items;
        }



        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            if(cell == null){
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

            }
            var item = items[indexPath.Row];
            cell.TextLabel.Text = item.title;
            return cell;
        }

        public rssChannelItem GetItem(int index){
            if(index < this.items.Length){
                return this.items[index];
            }
            return null;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return this.items.Length;
        }
    }
}
