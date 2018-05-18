using System;

using Foundation;
using UIKit;

namespace BlackJackIOS
{
	public partial class GameViewController : UIViewController
	{
		public GameViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad()
        {
			base.ViewDidLoad();
			NavigationController.SetNavigationBarHidden(false, true);

			ButtonStick.Layer.CornerRadius = 5;
			ButtonStick.Layer.BorderWidth = 1;
			ButtonStick.Layer.BorderColor = UIColor.White.CGColor;

			ButtonHit.Layer.CornerRadius = 5;
			ButtonHit.Layer.BorderWidth = 1;
			ButtonHit.Layer.BorderColor = UIColor.White.CGColor;
        }
	}
}