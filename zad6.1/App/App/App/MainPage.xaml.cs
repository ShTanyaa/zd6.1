using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : CarouselPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void InputButton_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(userNameEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
			{
				_ = DisplayAlert("Внимание", "Заполните логин и пароль", "OK");
				return;
			}

			await Navigation.PushModalAsync(new Page1(userNameEntry.Text, passwordEntry.Text));
		}
	}
}
