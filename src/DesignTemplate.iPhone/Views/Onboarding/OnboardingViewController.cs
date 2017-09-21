using System;
using DesignTemplate.iPhone.Views.Main;
using UIKit;

namespace DesignTemplate.iPhone.Views.Onboarding
{
    public partial class OnboardingViewController : UIViewController
    {
        private int _cardIndex = 1;
        public int CardIndex
        {
            get => _cardIndex;
            set
            {
                if (_cardIndex != value)
                {
                    _cardIndex = value;

                    if (CardIndex <= _pageControl.Pages)
                        _pageControl.CurrentPage = CardIndex - 1;

                    if (CardIndex >= _pageControl.Pages)
                        UIView.Animate(0.3, () => _onboardingButton.SetImage(UIImage.FromBundle("Onboarding_button"), UIControlState.Normal));
                    else
                        UIView.Animate(0.3, () => _onboardingButton.SetImage(UIImage.FromBundle("Onboarding_button_next"), UIControlState.Normal));
                }
            }
        }

        public OnboardingViewController() 
            : base("OnboardingViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, false);

            _onboardingButton.TouchUpInside += (sender, e) =>
            {
                if (CardIndex < _pageControl.Pages)
                    _scrollView.SetContentOffset(new CoreGraphics.CGPoint(UIScreen.MainScreen.Bounds.Width * CardIndex, 0), true);

                if (CardIndex == _pageControl.Pages)
                    NavigationController.PushViewController(new MainViewController(), false);
            };

            _scrollView.Scrolled += (sender, e) =>
            {
                CardIndex = (int)Math.Round(_scrollView.ContentOffset.X / UIScreen.MainScreen.Bounds.Width) + 1;
            };
        }
    }
}

