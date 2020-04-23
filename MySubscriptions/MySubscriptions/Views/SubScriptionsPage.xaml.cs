using MySubscriptions.ViewModel;
using MySubscriptions.ViewModel.Helpers;
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
    public partial class SubScriptionsPage : ContentPage
    {
        SubscriptionVM vm;
        public SubScriptionsPage()
        {
            InitializeComponent();

            vm = Resources["vm"] as SubscriptionVM; ;

        }


        protected override async void OnAppearing()
        {

            try
            {

            base.OnAppearing();
          
            if (!Auth.IsAuthenticated())
            {
              await  Task.Delay(300);
              await Navigation.PushAsync(new LoginPage());
            }
                else
                {
                    vm.ReadSubscriptions();
                }


            }
            catch (Exception ex )
            {

               await DisplayAlert("info",ex.Message + ex.StackTrace,"ok");
            }

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewSubScriptionsPage());
        }
    }
}