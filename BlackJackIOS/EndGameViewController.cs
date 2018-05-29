using System;
using UIKit;

namespace BlackJackIOS
{
	public partial class EndGameViewController : UIViewController
	{
		public EndGameViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			ButtonMainMenu.Layer.CornerRadius = 5;
			ButtonMainMenu.Layer.BorderWidth = 1;
			ButtonMainMenu.Layer.BorderColor = UIColor.White.CGColor;

			ButtonPlayAgain.Layer.CornerRadius = 5;
			ButtonPlayAgain.Layer.BorderWidth = 1;
			ButtonPlayAgain.Layer.BorderColor = UIColor.White.CGColor;

			LabelWinnerText.Font = UIFont.BoldSystemFontOfSize(26);
		}
	}
}