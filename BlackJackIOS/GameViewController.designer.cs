// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BlackJackIOS
{
    [Register ("GameViewController")]
    partial class GameViewController
    {
        [Outlet]
        UIKit.UIButton ButtonHit { get; set; }


        [Outlet]
        UIKit.UIButton ButtonStick { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonHit != null) {
                ButtonHit.Dispose ();
                ButtonHit = null;
            }

            if (ButtonStick != null) {
                ButtonStick.Dispose ();
                ButtonStick = null;
            }
        }
    }
}