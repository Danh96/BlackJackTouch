using System;
using System.Drawing;
using CoreGraphics;
using Foundation;
using Mono;
using UIKit;

namespace BlackJackIOS
{
	public partial class GameViewController : UIViewController
	{
		PlayingCard Card;

		public GameViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
                     
			var titleView = new UIView(new CGRect (0, 0, 120, 40));
			var titleImageView = new UIImageView(UIImage.FromBundle("Logo"));
			titleImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
			titleImageView.Frame = new CGRect(0, 0, titleView.Frame.Width, titleView.Frame.Height);
			titleView.AddSubview(titleImageView);
			NavigationController.NavigationBar.TopItem.TitleView = titleView;
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

			Card = PlayingCard.Create();
			Card.Frame = PlayerFirstCard.Frame;
			PlayerFirstCard.AddSubview(Card);
        }
	}
}