using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySubscriptions.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();


        }

        private void RegisterLabel_Tapped(object sender, EventArgs args)
        {
            RegisterStackLayout.IsVisible = true;
            LoginStackLayout.IsVisible = false;
        }


        private void LoginLabel_Tapped(object sender, EventArgs args)
        {
            RegisterStackLayout.IsVisible = false;
            LoginStackLayout.IsVisible = true;
        }
    }
}