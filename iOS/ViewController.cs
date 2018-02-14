using System;

using UIKit;

namespace NativeRssFeed.iOS
{
    public partial class ViewController : UIViewController
    {

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if(segue.Identifier.Equals("BuildRss" )){
                RssItemsViewController viewController = (RssItemsViewController)segue.DestinationViewController;
                viewController.Url = this.UrlText.Text;
            }

        }
    }
}
