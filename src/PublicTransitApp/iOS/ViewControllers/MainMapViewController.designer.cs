// <auto-generated />
// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PublicTransit.iOS
{
    [Register ("MainMapViewController")]
    partial class MainMapViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MaterialControls.MDButton LocateMeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.UI.Controls.MapView MapView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LocateMeButton != null) {
                LocateMeButton.Dispose ();
                LocateMeButton = null;
            }

            if (MapView != null) {
                MapView.Dispose ();
                MapView = null;
            }
        }
    }
}