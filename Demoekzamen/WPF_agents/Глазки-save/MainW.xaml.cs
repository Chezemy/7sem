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

namespace Глазки_save
{
    /// <summary>
    /// Логика взаимодействия для MainW.xaml
    /// </summary>
    public partial class MainW : Window
    {
        public MainW()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.User());
        }

        private void Btn_admin(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.Admin());
        }

        private void Btn_user(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.User());
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }

        private void Back(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack) GoBack.Visibility = Visibility.Visible;
            else GoBack.Visibility = Visibility.Hidden;
        }
    }
}
