using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static LearnC.Helper;

namespace LearnC.Tests.Test1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private int Result { get; set; }

        public Page2(ref int result)
        {
            Result = result;
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Toggle(switch1, switch2, switch3, e.Value);
            Result = 1;
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            Toggle(switch2, switch1, switch3, e.Value);
            Result = 2;
        }

        private void Switch_Toggled_2(object sender, ToggledEventArgs e)
        {
            Toggle(switch3, switch2, switch1, e.Value);
            Result = 3;
        }
    }
}