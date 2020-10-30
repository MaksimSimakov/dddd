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
    public partial class Detsember : ContentPage
    {
        public Detsember()
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
            Label nimetus = new Label { Text = "Detsembri Pilt", FontSize = 30 };
            Image img = new Image { Source = "detsember.jpg" };
            Label kirjeldus = new Label { Text = "Detsember on kahekümnendas!!! \n31 Декабря, Новый год!!!" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Праздник в декабре: 10 декабря - день футбола!", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}