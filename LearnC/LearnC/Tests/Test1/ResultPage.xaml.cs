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
    public partial class ResultPage : ContentPage
    {
        private int Result { get; set; }

        public ResultPage(int[] userAnswers,
            int[] correctAnswers)
        {
            Result = CalculateResult(userAnswers, correctAnswers);
            resultLabel.Text = $"Ваш результат: " +
                $"{CalculateResult(userAnswers, correctAnswers)}";
            InitializeComponent();
        }

        private static int CalculateResult(int[] userAnswers, 
            int[] correctAnswers)
        {
            int result = 0;

            for (int i = 0; i < userAnswers.Length; i++)
                if (userAnswers[i] == correctAnswers[i])
                    result++;

            return result;
        }


    }
}