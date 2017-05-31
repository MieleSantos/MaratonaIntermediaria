using SocialLoginMaratona.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialLoginMaratona.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }

}