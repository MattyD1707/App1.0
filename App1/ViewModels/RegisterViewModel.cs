using App1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class RegisterViewModel
    {
        public Command RegisteredCommand { get; }
        public RegisterViewModel()
        {
            RegisteredCommand = new Command(OnRegisteredClicked);
        }
        private async void OnRegisteredClicked(object obj)
        {
            //await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
