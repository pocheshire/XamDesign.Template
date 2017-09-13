using System;

using UIKit;

namespace DesignTemplate.iPhone.Views
{
    public partial class MyViewController : UIViewController
    {
        private int _count;
        
        public MyViewController()
            : base("MyViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _button.TouchUpInside += (sender, e) => 
            {
                _count++;

                _label.Text = $"{_count} clicks!";
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

