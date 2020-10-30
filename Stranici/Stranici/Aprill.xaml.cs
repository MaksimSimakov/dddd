using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stranici
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                       new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                       new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                       new RowDefinition { Height = new GridLength(2, GridUnitType.Star) }


                },
                ColumnDefinitions =
                {
                      new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            Label nimetus = new Label { Text = "Aprilli Pilt", FontSize = 30 };
            Image img = new Image { Source = "aprill.jpg" };
            Label kirjeldus = new Label { Text = "Aprill on neljas kuu!!! \nЧетвёртый месяц года в юлианском и григорианском календарях, второй месяц староримского года, начинавшегося до реформы Цезаря с марта. Один из четырёх месяцев длиной в 30 дней.!!!" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Мой День Рождения!", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}