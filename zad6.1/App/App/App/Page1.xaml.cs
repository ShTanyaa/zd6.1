using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : CarouselPage
	{
		string login;
		string password;

		public Page1(string login, string password)
		{
			InitializeComponent();

			this.login = login;
			this.password = password;

			onSwitch1_2.IsVisible = false;
		}

		private void oneButton1_Clicked(object sender, EventArgs e)
		{
			double sliderValue = slider3.Value;
			int department = (int)sliderValue + 1;


			string selectedItemText = (myPicker.SelectedIndex == -1) ? "Не выбран" : myPicker.SelectedItem.ToString();
			double slider1Value = slider1.Value;
			double slider2Value = slider2.Value;
			double slider3Value = (department == 0) ? department + 1 : (department == 4) ? department - 1 : department;
			double slider4Value = 100 - slider4_1.Value - slider4_2.Value;
			bool isSwitch1_1Toggled = toggleSwitch1_1.IsToggled;
			bool isSwitch1_2Toggled = toggleSwitch1_2.IsToggled;
			bool isSwitch1_3Toggled = toggleSwitch1_3.IsToggled;
			bool isSwitch2_1Toggled = toggleSwitch2_1.IsToggled;
			bool isSwitch2_2Toggled = toggleSwitch2_2.IsToggled;
			bool isSwitch2_3Toggled = toggleSwitch2_3.IsToggled;
			bool isRadioButton1Checked = RadioButton1.IsChecked;
			bool isRadioButton2Checked = RadioButton2.IsChecked;
			bool isCheckBox1Checked = CheckBox1.IsChecked;
			bool isCheckBox2Checked = CheckBox2.IsChecked;


			_ = Navigation.PushModalAsync(new InfoPage(selectedItemText, slider1Value, slider2Value,
													   slider3Value, slider4Value, isSwitch1_1Toggled, isSwitch1_2Toggled,
													   isSwitch1_3Toggled, isSwitch2_1Toggled, isSwitch2_2Toggled, isSwitch2_3Toggled,
													   isRadioButton1Checked, isRadioButton2Checked, isCheckBox1Checked, isCheckBox2Checked));
		}



		private void slider4_1_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			double maxValue = slider4_1.Maximum;
			double value = e.NewValue;

			if (value > (maxValue / 2))
			{
				slider4_1.Value = maxValue / 2;
				slider4_2.Value = maxValue / 2;
			}
			else { slider4_2.Value = value; }
		}

		private void toggleSwitch1_2_Toggled(object sender, ToggledEventArgs e)
		{
			bool isToggled = e.Value;
			onSwitch1_2.IsVisible = isToggled;
			offSwitch1_2.IsVisible = !isToggled;
		}

		private void toggleSwitch1_3_Toggled(object sender, ToggledEventArgs e)
		{
			bool isToggled = e.Value;
			onSwitch1_3.IsVisible = isToggled;
			offSwitch1_3.IsVisible = !isToggled;
		}

		private void toggleSwitch2_2_Toggled(object sender, ToggledEventArgs e)
		{
			bool isToggled = e.Value;
			onSwitch2_2.IsVisible = isToggled;
			offSwitch2_2.IsVisible = !isToggled;
		}

		private void toggleSwitch2_3_Toggled(object sender, ToggledEventArgs e)
		{
			bool isToggled = e.Value;
			onSwitch2_3.IsVisible = isToggled;
			offSwitch2_3.IsVisible = !isToggled;
		}

	}
}