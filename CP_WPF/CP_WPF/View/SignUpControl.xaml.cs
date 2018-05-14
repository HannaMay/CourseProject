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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Id = 1,
                Name = "fox",
                UserName = "hedgehog",
                Password = "12345"
            };
            AsyncClient.SetUser(user);
            AsyncClient.SetTypeInfo(TypeOfInfo.User);
            AsyncClient.StartClient();
        }
    }
}
