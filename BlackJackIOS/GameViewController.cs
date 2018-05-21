using System;
using System.Drawing;
using Foundation;
using Mono;
using UIKit;

namespace BlackJackIOS
{
	public partial class GameViewController : UIViewController
	{
		public GameViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			//NavigationController.NavigationBar.TopItem.TitleView = new UIImageView(UIImage.FromBundle("Logo"))
            //{
            //    Frame = new RectangleF(0, 0, 100, 30),
            //    ContentMode = UIViewContentMode.ScaleAspectFit
            //};
        }

		public override void ViewDidLoad()
        {
			base.ViewDidLoad();
			NavigationController.SetNavigationBarHidden(false, true);

			NavigationController.NavigationBar.TintColor = UIColor.White;
            NavigationController.NavigationBar.BarTintColor = UIColor.FromRGB(245, 0, 0);
			NavigationController.NavigationBar.Translucent = false;

			NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
			NavigationController.NavigationBar.ShadowImage = new UIImage();

			ButtonStick.Layer.CornerRadius = 5;
			ButtonStick.Layer.BorderWidth = 1;
			ButtonStick.Layer.BorderColor = UIColor.White.CGColor;

			ButtonHit.Layer.CornerRadius = 5;
			ButtonHit.Layer.BorderWidth = 1;
			ButtonHit.Layer.BorderColor = UIColor.White.CGColor;
            
        }
	}
}