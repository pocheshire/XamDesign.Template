﻿using DesignTemplate.iPhone.Views;
using DesignTemplate.iPhone.Views.Onboarding;
using Foundation;
using UIKit;

namespace DesignTemplate.iPhone
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow();

			//TODO: заменить инициализацию пустого MyViewController на свой экран
			var viewController = new OnboardingViewController();

            Window.RootViewController = new UINavigationController(viewController);

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}

