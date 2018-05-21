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
    /// Логика взаимодействия для SignUpControl.xaml
    /// </summary>
    public partial class SignUpControl : UserControl
    {
        MainWindow win;
        public SignUpControl(MainWindow win)
        {
            this.win = win;
            InitializeComponent();
        }

        private void ArrowLogIn (object sender, RoutedEventArgs e)
        {
            win.MainWindowCP.Children.Clear();
            win.MainWindowCP.Children.Add(new LogInControl(win));
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            AsyncClient.SetTypeInfo(TypeOfInfo.User);
            AsyncClient.StartClient();
            User user = new User
            {
                Id =1,
                Name = this.Name.Text,
                UserName = this.Username.Text,
                Password = this.Password.Password
            };
            AsyncClient.SetUser(user);
            AsyncClient.StartClient();
            AsyncClient.SetTypeInfo(TypeOfInfo.Users);
            AsyncClient.StartClient();
            MainMenuxaml mainMenuxaml = new MainMenuxaml();
            win.Close();
            mainMenuxaml.Show();
        }
    }
}
