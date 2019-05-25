using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnC.Content.Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chapter1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public Chapter1()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Структура программы на Си",
                "Переменные",
                "Типы данных",
                "Консольный вывод. Функция printf",
                "Константы",
                "Арифметические операции",
                "Логические операции и операции отношения",
                "Поразрядные операции",
                "Операции присваивания",
                "Преобразование типов",
                "Условные конструкции",
                "Циклы",
                "Введение в массивы и строки",
                "Ввод в консоли. Функция scanf",
                "Пройти тест по главе 1"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;


            if(e.Item == "Пройти тест по главе 1")
                await Navigation.PushModalAsync( new TabbedPage
                {
                    Children =
                    {
                        new Tests.Test1.Page1(),
                        new Tests.Test1.Page2(),
                        new Tests.Test1.Page3()
                    }
                });

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
