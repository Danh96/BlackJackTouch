﻿using System;
using Foundation;
using UIKit;

namespace BlackJackIOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			NavigationController.SetNavigationBarHidden(true, true);
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NavigationController.SetNavigationBarHidden(true, true);
			ButtonStartGame.Layer.CornerRadius = 5;
			ButtonStartGame.Layer.BorderWidth = 1;
			ButtonStartGame.Layer.BorderColor = UIColor.White.CGColor;
            
			NavigationController.NavigationBar.TintColor = UIColor.White;
			NavigationController.NavigationBar.BarTintColor = UIColor.Red;
            
			ButtonStartGame.TouchUpInside += (sender, e) =>
			{
				UIStoryboard gameStoryBoard = UIStoryboard.FromName("Game", NSBundle.MainBundle);
				GameViewController gameViewController = gameStoryBoard.InstantiateViewController("GameViewController") as GameViewController;
				NavigationController.PushViewController(gameViewController, true);
			};
		}
	}
}