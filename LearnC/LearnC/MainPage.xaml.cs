using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Chapter1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Content.Chapter1.Chapter1());
        }

        private void Chapter2_Clicked(object sender, EventArgs e)
        {

        }

        private void Chapter3_Clicked(object sender, EventArgs e)
        {

        }

        private void Chapter4_Clicked(object sender, EventArgs e)
        {

        }

        private void Chapter5_Clicked(object sender, EventArgs e)
        {

        }

        private void Chapter6_Clicked(object sender, EventArgs e)
        {

        }
    }
}
