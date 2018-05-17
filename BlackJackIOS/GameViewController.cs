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
        }
	}
}