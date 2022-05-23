using App1.Views;
using System;
using Xamarin.Forms;
using System.Linq;

namespace App1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegisterClicked);
        }

        private async void OnLoginClicked(object obj)
        {

            var result = await App.Database.GetUserAsync();
            var getter = result.Where(u => u.UserName.Equals(Username) && u.Password.Equals(Password)).FirstOrDefault();

            if (getter != null)
            {
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }

            else
            {
                return;
            }

        }
        private async void OnRegisterClicked(object obj)
        {

            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
        }


    }
}
