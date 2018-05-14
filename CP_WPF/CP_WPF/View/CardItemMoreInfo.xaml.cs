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
    /// <summary>
    /// Логика взаимодействия для CardItemMoreInfo.xaml
    /// </summary>
    public partial class CardItemMoreInfo : UserControl
    {
        public bool flag = false;
        List<Image> slidelist = new List<Image>();
        MainMenuxaml win;

        public CardItemMoreInfo(MainMenuxaml win, Film film)
        {
            this.win = win;
            InitializeComponent();
            Uri urislide1 = new Uri(film.Image_Main, UriKind.RelativeOrAbsolute);
            this.CardInfoMainImg.Source = BitmapFrame.Create(urislide1);
            if (film.Images != "")
            {
                foreach (string s in FilmHandler.GetListOfImages(film.Images))
                {
                    Uri urislide = new Uri(s, UriKind.RelativeOrAbsolute);
                    Image image = new Image
                    {
                        Source = BitmapFrame.Create(urislide)
                    };
                    this.Images.Children.Add(image);
                }
            }
            this.EventNameCardMoreInfo.Text = film.Name;
            List<string> list = FilmHandler.GetListOfGenres(film.Genre);
            foreach (string s in list)
            {
                if (s == list.Last())
                {
                    this.GenresCardMoreInfo.Text += s;
                    break;
                }
                this.GenresCardMoreInfo.Text += s + ", ";
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
                this.YearCardMoreInfo.Text = film.Country;
            }
            this.CountryCardMoreInfo.Text = film.Country;
            this.DescriptionCardMoreInfo.Text = film.Info;
            this.RatingCardMoreInfo.Text = film.Rating;
            this.TimeCardMoreInfo.Text = film.Duration;
        }        

        private void PreviousSlide(object sender, RoutedEventArgs e)
        {
            flag = true;
            
            //Slide1.Visibility = Visibility.Collapsed;
            //Slide5.Visibility = Visibility.Visible;
            
        }

        private void NextSlide(object sender, RoutedEventArgs e)
        {
            flag = true;
            //Slide1.Visibility = Visibility.Collapsed;
            //Slide2.Visibility = Visibility.Visible;
        }
    }
}
