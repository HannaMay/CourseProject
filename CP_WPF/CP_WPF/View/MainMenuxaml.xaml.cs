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

        public bool flagH = false;
        public bool flagS = false;

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
            GridSpaceInfo.Margin = new Thickness(80, 0, 0, 0);
            flagS = true;
            
        }
        private void ButtonMultiTabDown_Click(object sender, RoutedEventArgs e)
        {
            ButtonMultiTabUp.Visibility = Visibility.Visible;
            ButtonMultiTabDown.Visibility = Visibility.Collapsed;
            SystemCommands.RestoreWindow(this);
            flagS = false;
        }

       
       
        private void ButtonMenuOpen_Click(object sender, RoutedEventArgs e)
        {
            MainBtnToolbarOpen.Visibility = Visibility.Collapsed;
            MainBtnToolbarClose.Visibility = Visibility.Visible;
            ToolbarPanel.Margin = new Thickness(0);
         
            if (flagH == true)
            {
                GridSpaceInfo.Margin = new Thickness(230, 60, 0, 0);                
            }
            else
            {
                GridSpaceInfo.Margin = new Thickness(230, 0, 0, 0);
            }
        }        

        private void ButtonMenuClose_Click(object sender, RoutedEventArgs e)
        {
            MainBtnToolbarOpen.Visibility = Visibility.Visible;
            MainBtnToolbarClose.Visibility = Visibility.Collapsed;
            ToolbarPanel.Margin = new Thickness(-20, 0, 520, 0);
            
            if (flagH == true)
            {
                GridSpaceInfo.Margin = new Thickness(0, 60, 0, 0);                
            }
            else
            {
                GridSpaceInfo.Margin = new Thickness(0);
            }
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
            GridSpaceInfo.Margin = new Thickness(0, 60, 0, 0);
            flagH = true;
        }       

        private void ButtonPanelClose_Click(object sender, RoutedEventArgs e)
        {
            MainNavSencondPart.Visibility = Visibility.Collapsed;
            MainBtnDropUp.Visibility = Visibility.Collapsed;
            MainBtnDropDown.Visibility = Visibility.Visible;
            GridSpaceInfo.Margin = new Thickness(0);
            flagH = false;
        }

        private void Cinema_Click(object sender, RoutedEventArgs e)
        {
              /*AsyncClient.SetTypeInfo(TypeOfInfo.Cinema);
              AsyncClient.StartClient();
              List<CardItemCinema> list = new List<CardItemCinema>(AsyncClient.cinemas.Count);
              foreach (Cinema a in AsyncClient.cinemas)
              {
                  CardItemCinema cardItemCinema = new CardItemCinema(this,);
                  cardItemCinema.Details.Click += new RoutedEventHandler(Handler);
                  list.Add(cardItemCinema);
                  GridSpaceInfo.Children.Add(cardItemCinema);
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
                /// спросить у Андрея  и  сначала пользователи!!!!!!!!!
                if (cardItem.flagFavorite == true)
                {
                    cardItem.AddFavOn.Visibility = Visibility.Collapsed;
                    cardItem.AddFavOff.Visibility = Visibility.Visible;
                }
                else if (cardItem.flagFavorite == false)
                {
                    cardItem.AddFavOn.Visibility = Visibility.Visible;
                    cardItem.AddFavOff.Visibility = Visibility.Collapsed;
                }

            }
        }

        //private void ShowScroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        //{
            
        //}

        private void OpenSearch(object sender, RoutedEventArgs e)
        {
            GridSpaceInfo.Children.Clear();
            Search search = new Search(this);
            GridSpaceInfo.Children.Add(search);
            if (flagS == true)
            {
                search.Margin = new Thickness(10,10,10, 0);
                search.Width = 1500;

            }
            else
            {
                search.Margin = new Thickness(0);
                search.Width = 800;
            }

        }

        private void OpenFavorite(object sender, RoutedEventArgs e)
        {

        }

        private void OpenComments(object sender, RoutedEventArgs e)
        {

        }
    }
}
