using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.ViewModels;
using System.Runtime.CompilerServices;

namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionViewFeed.ItemsSource = await App.FDatabase.GetFeedAsync();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            collectionViewFeed.ItemsSource = await App.FDatabase.GetFeedAsync();
            NoteInput.Text = null;
        }
    }
}
