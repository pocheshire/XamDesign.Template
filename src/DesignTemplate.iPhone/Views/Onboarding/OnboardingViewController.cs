using System;

using UIKit;

namespace DesignTemplate.iPhone.Views.Onboarding
{
    public partial class OnboardingViewController : UIViewController
    {
        public OnboardingViewController() : base("OnboardingViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.SetNavigationBarHidden(true, false);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

