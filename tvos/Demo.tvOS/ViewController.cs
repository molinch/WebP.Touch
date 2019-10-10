using System;
using System.Net.Http;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Demo.tvOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            var decoder = new WebP.WebPCodec();
            var httpClient = new HttpClient();
            using (var stream = await httpClient.GetStreamAsync("https://res.cloudinary.com/demo/image/upload/w_300/sample.webp").ConfigureAwait(false)) {
                var image = decoder.Decode(stream);
                InvokeOnMainThread(() =>
                {
                    var imageView = new UIImageView(new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
                    View.AddSubview(imageView);
                    imageView.Image = image;
                });
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}

