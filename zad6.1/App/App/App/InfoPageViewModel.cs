using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
	public class InfoPageViewModel
	{
		public string SelectedItemText { get; set; }
		public double Slider1Value { get; set; }
		public double Slider2Value { get; set; }
		public double Slider3Value { get; set; }
		public double Slider4Value { get; set; }
		public bool IsSwitch1_1Toggled { get; set; }
		public bool IsSwitch1_2Toggled { get; set; }
		public bool IsSwitch1_3Toggled { get; set; }
		public bool IsSwitch2_1Toggled { get; set; }
		public bool IsSwitch2_2Toggled { get; set; }
		public bool IsSwitch2_3Toggled { get; set; }
		public bool IsRadioButton1Checked { get; set; }
		public bool IsRadioButton2Checked { get; set; }
		public bool IsCheckBox1Checked { get; set; }
		public bool IsCheckBox2Checked { get; set; }

		public InfoPageViewModel(string selectedItemText, double slider1Value, double slider2Value,
							  double slider3Value, double slider4Value, bool isSwitch1_1Toggled,
							  bool isSwitch1_2Toggled, bool isSwitch1_3Toggled, bool isSwitch2_1Toggled,
							  bool isSwitch2_2Toggled, bool isSwitch2_3Toggled, bool isRadioButton1Checked,
							  bool isRadioButton2Checked, bool isCheckBox1Checked, bool isCheckBox2Checked)
		{
			SelectedItemText = selectedItemText;
			Slider1Value = slider1Value;
			Slider2Value = slider2Value;
			Slider3Value = slider3Value;
			Slider4Value = slider4Value;
			IsSwitch1_1Toggled = isSwitch1_1Toggled;
			IsSwitch1_2Toggled = isSwitch1_2Toggled;
			IsSwitch1_3Toggled = isSwitch1_3Toggled;
			IsSwitch2_1Toggled = isSwitch2_1Toggled;
			IsSwitch2_2Toggled = isSwitch2_2Toggled;
			IsSwitch2_3Toggled = isSwitch2_3Toggled;
			IsRadioButton1Checked = isRadioButton1Checked;
			IsRadioButton2Checked = isRadioButton2Checked;
			IsCheckBox1Checked = isCheckBox1Checked;
			IsCheckBox2Checked = isCheckBox2Checked;
		}
		public string RadioButtonStatus
		{
			get
			{
				if (IsRadioButton1Checked) { return "Первая радиокнопка включена"; }
				else if (IsRadioButton2Checked) { return "Вторая радиокнопка включена"; }
				else { return "Ни одна из радиокнопок не включена"; }
			}
		}
		public string MaxSliderValueText
		{
			get
			{
				if (Slider1Value > Slider2Value && Slider1Value > Slider3Value && Slider1Value > Slider4Value)
					return "Максимальное значение на Slider 1";
				else if (Slider2Value > Slider1Value && Slider2Value > Slider3Value && Slider2Value > Slider4Value)
					return "Максимальное значение на Slider 2";
				else if (Slider3Value > Slider1Value && Slider3Value > Slider2Value && Slider3Value > Slider4Value)
					return "Максимальное значение на Slider 3";
				else if (Slider4Value > Slider1Value && Slider4Value > Slider2Value && Slider4Value > Slider3Value)
					return "Максимальное значение на Slider 4";
				else return "Максимальное значение не определено";
			}
		}
	}
}
