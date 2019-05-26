using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace LearnC.Tests.Test1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test1 : Xamarin.Forms.TabbedPage
    {
        private int[] Answers { get; set; } = new int[3];
        public Test1()
        {
            Children.Add(new Page1(ref Answers[0]));
            Children.Add(new Page2(ref Answers[0]));
            Children.Add(new Page3(ref Answers[0]));
            Children.Add(new FinishPage(Answers, new int[]{2, 2, 3}));

            InitializeComponent();
            this.On<Xamarin.Forms.PlatformConfiguration.Android>()
                .SetIsSwipePagingEnabled(false);
        }
    }
}