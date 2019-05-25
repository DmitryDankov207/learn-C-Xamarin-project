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
        public Test1()
        {
            InitializeComponent();
            this.On<Xamarin.Forms.PlatformConfiguration.Android>()
                .SetIsSwipePagingEnabled(false);
        }
    }
}