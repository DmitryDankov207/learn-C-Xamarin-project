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
    public partial class FinishPage : ContentPage
    {
        int[] UserAnswers { get; set; }
        int[] CorrectAnswers { get; set; }
        public FinishPage(int[] userAnswers, int[] correctAnswers)
        {
            UserAnswers = userAnswers;
            CorrectAnswers = correctAnswers;

            InitializeComponent();
        }

        private void FinishButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPage(UserAnswers, CorrectAnswers));
        }
    }
}