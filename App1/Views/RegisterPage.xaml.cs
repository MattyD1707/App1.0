using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.BindingContext = new RegisterViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetUserAsync();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EntryUsername.Text))
            {
                await App.Database.SaveUserAsync(new User
                {
                    Name = EntryName.Text,
                    UserName = EntryUsername.Text,
                    Password = EntryPassword.Text,
                    Email = EntryEmail.Text,
                    DOB = EntryDOB.Text,
                    JobTitle = EntryJobTitle.Text,
                });
                collectionView.ItemsSource = await App.Database.GetUserAsync();
            }
        }
    }
}
