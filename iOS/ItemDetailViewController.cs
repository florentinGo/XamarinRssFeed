using Foundation;
using System;
using UIKit;

namespace NativeRssFeed.iOS
{
    public partial class ItemDetailViewController : UIViewController
    {
        public string Url { get; set; }

        public ItemDetailViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (!string.IsNullOrEmpty(this.Url))
            {
                var webView = new UIWebView();
                webView.LoadRequest(new NSUrlRequest(new NSUrl(this.Url)));
                this.View = webView;
            }
        }
    }
}