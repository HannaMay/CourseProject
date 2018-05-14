using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace CP_WPF.View
{
    public partial class CardItem : UserControl
    {
        public Film film;
        MainMenuxaml win;
        public CardItem(MainMenuxaml win, Film film)
        {
            this.win = win;
            InitializeComponent();
            Uri urislide1 = new Uri(film.Image_Main, UriKind.RelativeOrAbsolute);
            this.MainImage.Source = BitmapFrame.Create(urislide1);

            this.EventName.Text = film.Name ?? "";
            foreach (string s in FilmHandler.GetListOfGenres(film.Genre))
            {
                if (s == FilmHandler.GetListOfGenres(film.Genre).Last())
                {
                    this.Genre.Text += s;
                    break;
                }
                this.Genre.Text += s + ", ";
            }
            if (film.Country != null)
            {
                if (!film.Country.Equals(""))
                {
                    if (film.Country[0] == ' ')
                    {
                        film.Country = film.Country.Remove(0, 1);
                    }
                }
                this.CountryAndYear.Text = film.Country + "\n" + film.Year;
            }
            this.film = film;
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            this.win.film = this.film;
        }
    }
}
