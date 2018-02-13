using Foundation;
using System;
using UIKit;

namespace NativeRssFeed.iOS
{
    public partial class RssViewController : UIViewController
    {
        public string Url { get; set; }

        public RssViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.UrlTextDisplay.Text = this.Url;
        }

    }
}