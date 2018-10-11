using System;
using AEGDemo.Implementation.ViewController;
using AEGDemo.Implementation.ViewModel;
using AEGDemo.Root.View;
using Xamarin.Forms;

namespace AEGDemo.Implementation.View
{
    public partial class LoginView : ProjectBaseContentPage<LoginViewController, LoginViewModel>
    {
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_YourMethodName_EventAsync(object sender, EventArgs e)
        {
            await _ViewController.YourMethodNameAsync();
        }
    }
}


