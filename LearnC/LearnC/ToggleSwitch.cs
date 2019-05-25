using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LearnC
{
    class ToggleSwitch : Switch
    {
        public static readonly BindableProperty ToggleProperty =
            BindableProperty.Create("Toggle",
                typeof(bool),
                typeof(ToggleSwitch),
                false,
                BindingMode.TwoWay
                );

        public bool Toggle
        {
            set
            {
                SetValue(ToggleProperty, value);
            }
            get
            {
                return (bool)GetValue(ToggleProperty) == true ? false : true;
            }
        }
    }
}
