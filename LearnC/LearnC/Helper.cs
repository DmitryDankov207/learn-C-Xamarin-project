using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnC
{
    public static class Helper
    {
        public static void Toggle(Switch switch1, Switch switch2,
            Switch switch3, bool value)
        {
            if (switch1.IsToggled == true)
                switch2.IsToggled = switch3.IsToggled = false;
        }
    }
}
