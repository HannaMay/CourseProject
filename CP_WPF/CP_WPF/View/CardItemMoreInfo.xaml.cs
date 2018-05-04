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

namespace CP_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для CardItemMoreInfo.xaml
    /// </summary>
    public partial class CardItemMoreInfo : UserControl
    {
        public bool flag = false;
        List<Image> slidelist = new List<Image>();
        
        public CardItemMoreInfo()
        {
            InitializeComponent();
            //Uri urislide1 = new Uri("https://img.afisha.tut.by/img/865x575c/screens/0b/8/taksi-5-529789.jpg");
            
            Image image = new Image();
            slidelist.Add(image);
            //"../Resources/Image/TestImage/princes1.jpg
        }

        private void PreviousSlide(object sender, RoutedEventArgs e)
        {
            flag = true;
            Slide1.Visibility = Visibility.Collapsed;
            Slide2.Visibility = Visibility.Visible;
            
        }

        private void NextSlide(object sender, RoutedEventArgs e)
        {

        }
    }
}
