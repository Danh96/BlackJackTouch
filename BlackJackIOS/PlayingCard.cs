using System;

using Foundation;
using Mono;
using UIKit;

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
    }
}
