using MySubscriptions.Model;
using MySubscriptions.ViewModel.Helpers;
using MySubscriptions.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MySubscriptions.ViewModel
{
   public class SubscriptionVM  : INotifyPropertyChanged
    {
        private Subscription selectedSubscription;

        public Subscription SelectedSubscription
        {
            get { 
                return selectedSubscription; 
            }
            set {
                selectedSubscription = value;
                OnPropertyChanged("selectedSubscription");
                if (selectedSubscription !=null)
                    App.Current.MainPage.Navigation.PushAsync(new SubscriptionDetailsPage(selectedSubscription));
                }
        }

        public ObservableCollection<Subscription> Subscriptions { get; set; }
        public SubscriptionVM()
        {
            Subscriptions = new ObservableCollection<Subscription>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void ReadSubscriptions()
        {

            var subscriptions = await DatabaseHelper.ReadSubscriptions();

            Subscriptions.Clear();
            foreach (var s in subscriptions)
            {
                Subscriptions.Add(s);
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
