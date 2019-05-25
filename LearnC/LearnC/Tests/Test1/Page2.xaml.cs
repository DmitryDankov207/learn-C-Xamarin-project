using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnC.Tests.Test1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == true)
                switch2.IsToggled = switch3.IsToggled = false;
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            if (switch2.IsToggled == true)
                switch1.IsToggled = switch3.IsToggled = false;
        }

        private void Switch_Toggled_2(object sender, ToggledEventArgs e)
        {
            if (switch3.IsToggled == true)
                switch2.IsToggled = switch1.IsToggled = false;
        }
    }
}