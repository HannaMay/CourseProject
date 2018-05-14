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
using System.Windows.Shapes;
using ClassLibrary;
namespace CP_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для MainMenuxaml.xaml
    /// </summary>
    public partial class MainMenuxaml : Window
    {
        WrapPanel grid;
        public Film film;
        public MainMenuxaml()
        {
            InitializeComponent();
            AsyncClient.SetTypeInfo(TypeOfInfo.Films);
            AsyncClient.StartClient();
            List<CardItem> list = new List<CardItem>(AsyncClient.films.Count);
            foreach(Film a in AsyncClient.films)
            {
                CardItem cardItem = new CardItem(this, a);
                cardItem.Details.Click += new RoutedEventHandler(Handler);
                list.Add(cardItem);
                GridSpaceInfo.Children.Add(cardItem);
                grid = GridSpaceInfo;
            }
        }

        public void Handler(object sender, RoutedEventArgs e)
        {
            GridSpaceInfo.Children.Clear();
            GridSpaceInfo.Children.Add(new CardItemMoreInfo(this, film));
        }
        
        private void ButtonMinimaze_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void ButtonMultiTabUp_Click(object sender, RoutedEventArgs e)
        {            
            ButtonMultiTabUp.Visibility = Visibility.Collapsed;
            ButtonMultiTabDown.Visibility = Visibility.Visible;
            SystemCommands.MaximizeWindow(this);
        }
        private void ButtonMultiTabDown_Click(object sender, RoutedEventArgs e)
        {
            ButtonMultiTabUp.Visibility = Visibility.Visible;
            ButtonMultiTabDown.Visibility = Visibility.Collapsed;
            SystemCommands.RestoreWindow(this);
        }

        private void ButtonMenuOpen_Click(object sender, RoutedEventArgs e)
        {
            MainBtnToolbarOpen.Visibility = Visibility.Collapsed;
            MainBtnToolbarClose.Visibility = Visibility.Visible;
            ToolbarPanel.Margin = new Thickness(0); 
        }

        private void ButtonMenuClose_Click(object sender, RoutedEventArgs e)
        {
            MainBtnToolbarOpen.Visibility = Visibility.Visible;
            MainBtnToolbarClose.Visibility = Visibility.Collapsed;
            ToolbarPanel.Margin = new Thickness(-20, 0, 520, 0);
        }

        private void ButtonLogInOpen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void ButtonPanelOpen_Click(object sender, RoutedEventArgs e)
        {
            MainNavSencondPart.Visibility = Visibility.Visible;
            MainBtnDropDown.Visibility = Visibility.Collapsed;
            MainBtnDropUp.Visibility = Visibility.Visible;


        }

        private void ButtonPanelClose_Click(object sender, RoutedEventArgs e)
        {
            MainNavSencondPart.Visibility = Visibility.Collapsed;
            MainBtnDropUp.Visibility = Visibility.Collapsed;
            MainBtnDropDown.Visibility = Visibility.Visible;
        }

        private void Cinema_Click(object sender, RoutedEventArgs e)
        {
          /*  AsyncClient.SetTypeInfo(TypeOfInfo.Cinema);
            AsyncClient.StartClient();
            List<CardItem> list = new List<CardItem>(AsyncClient.cinemas.Count);
            foreach (Cinema a in AsyncClient.cinemas)
            {
                CardItem cardItem = new CardItem(this,);
                cardItem.Details.Click += new RoutedEventHandler(Handler);
                list.Add(cardItem);
                GridSpaceInfo.Children.Add(cardItem);
                grid = GridSpaceInfo;
            }*/
        }

        private void MainBtnFilms_Click(object sender, RoutedEventArgs e)
        {
            GridSpaceInfo.Children.Clear();
            List<CardItem> list = new List<CardItem>(AsyncClient.films.Count);
            foreach (Film a in AsyncClient.films)
            {
                CardItem cardItem = new CardItem(this, a);
                cardItem.Details.Click += new RoutedEventHandler(Handler);
                list.Add(cardItem);
                GridSpaceInfo.Children.Add(cardItem);
                grid = GridSpaceInfo;
            }
        }
    }
}
