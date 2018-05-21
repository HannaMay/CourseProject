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
    /// Логика взаимодействия для LogInControl.xaml
    /// </summary>
    public partial class LogInControl : UserControl
    {
        MainWindow win;
        public LogInControl(MainWindow win)
        {
            this.win = win;
            InitializeComponent();
        }

        private void ArrowSignUp(object sender, RoutedEventArgs e)
        {
            win.MainWindowCP.Children.Clear();
            win.MainWindowCP.Children.Add(new SignUpControl(win));
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {

            MainMenuxaml mainMenuxaml = new MainMenuxaml();
            win.Close();
            mainMenuxaml.Show();
        }
    }
}
