// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DesignTemplate.iPhone.Views.Onboarding
{
	[Register ("OnboardingViewController")]
	partial class OnboardingViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton _onboardingButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIPageControl _pageControl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIScrollView _scrollView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_onboardingButton != null) {
				_onboardingButton.Dispose ();
				_onboardingButton = null;
			}

			if (_pageControl != null) {
				_pageControl.Dispose ();
				_pageControl = null;
			}

			if (_scrollView != null) {
				_scrollView.Dispose ();
				_scrollView = null;
			}
		}
	}
}
