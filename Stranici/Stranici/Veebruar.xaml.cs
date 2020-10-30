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
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
          {
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
                Label nimetus = new Label { Text = "Veebruari Pilt", FontSize = 30 };
                Image img = new Image { Source = "veebruar.jpg" };
                Label kirjeldus = new Label { Text = "Второй месяц в юлианском и григорианском календарях, двенадцатый месяц староримского года, начинавшегося до реформы Цезаря с марта. Это самый короткий месяц года, и единственный с числом дней менее 30: имеет 28 дней в обычном году и 29 дней в високосные годы." };
                var tap = new TapGestureRecognizer();
                tap.Tapped += async (s, e) =>
                {
                    img = (Image)s;
                    await DisplayAlert("Информация", "Мой любимый месяц", "Закрыть");
                };
                img.GestureRecognizers.Add(tap);
                grd.Children.Add(nimetus, 0, 0);
                grd.Children.Add(img, 0, 1);
                grd.Children.Add(kirjeldus, 0, 2);
                Content = grd;
          }     
        }
    }
}