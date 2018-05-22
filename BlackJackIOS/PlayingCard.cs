using Foundation;
using System;
using UIKit;
using ObjCRuntime;

namespace BlackJackIOS
{
	public partial class PlayingCard : UIView
    {
        public static readonly NSString Key = new NSString("PlayingCard");
        public static readonly UINib Nib;

        static PlayingCard()
        {
            Nib = UINib.FromName("PlayingCard", NSBundle.MainBundle);
        }

        protected PlayingCard(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public static PlayingCard Create()
        {
			var CardArray = NSBundle.MainBundle.LoadNib("PlayingCard", null, null);
			var Card = Runtime.GetNSObject<PlayingCard>(CardArray.ValueAt(0));

			Card.Layer.BorderWidth = 1;
			Card.Layer.CornerRadius = 5;
			Card.Layer.BorderColor = UIColor.Black.CGColor;

			Card.CardSuitImage.Image = UIImage.FromBundle("Diamonds");
			Card.CardValueTop.Text = "3";
			Card.CardValueBottom.Text = "3";

			return Card;
        }
    }
}