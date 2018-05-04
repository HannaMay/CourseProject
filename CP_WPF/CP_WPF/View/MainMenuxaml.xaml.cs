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

namespace CP_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для MainMenuxaml.xaml
    /// </summary>
    public partial class MainMenuxaml : Window
    {
        public MainMenuxaml()
        {
            InitializeComponent();            
            
        }

        private void ButtonMinimaze_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void ButtonMultiTab_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
        }

        private void ButtonMenuOpen_Click(object sender, RoutedEventArgs e)
        {
            MainBtnToolbarOpen.Visibility = Visibility.Collapsed;
            MainBtnToolbarClose.Visibility = Visibility.Visible;
        }

        private void ButtonMenuClose_Click(object sender, RoutedEventArgs e)
        {
            MainBtnToolbarOpen.Visibility = Visibility.Visible;
            MainBtnToolbarClose.Visibility = Visibility.Collapsed;
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
        }

        private void ButtonPanelClose_Click(object sender, RoutedEventArgs e)
        {
            MainNavSencondPart.Visibility = Visibility.Collapsed;
        }
    }
}
