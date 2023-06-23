using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : CarouselPage
    {
        public InfoPage(string selectedItemText, double slider1Value, double slider2Value, 
                        double slider3Value, double slider4Value, bool isSwitch1_1Toggled,
                        bool isSwitch1_2Toggled, bool isSwitch1_3Toggled, bool isSwitch2_1Toggled,
                        bool isSwitch2_2Toggled, bool isSwitch2_3Toggled, bool isRadioButton1Checked,
                        bool isRadioButton2Checked, bool isCheckBox1Checked, bool isCheckBox2Checked)
        {
            InitializeComponent();

            // привязка переданных значений к элементам интерфейса
            BindingContext = new InfoPageViewModel(selectedItemText, slider1Value, slider2Value, 
                                                slider3Value, slider4Value, isSwitch1_1Toggled,
                                                isSwitch1_2Toggled, isSwitch1_3Toggled, isSwitch2_1Toggled,
                                                isSwitch2_2Toggled, isSwitch2_3Toggled, isRadioButton1Checked,
                                                isRadioButton2Checked, isCheckBox1Checked, isCheckBox2Checked);
        }
    }
}