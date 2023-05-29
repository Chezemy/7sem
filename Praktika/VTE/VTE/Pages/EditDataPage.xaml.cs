using VTE.Models;
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

namespace VTE.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditDataPage.xaml
    /// </summary>
    public partial class EditDataPage : Page
    {
        public EditDataPage()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                prods prd = new prods();
                int a = Int32.Parse(Price.Text);
                int b = Int32.Parse(IdTbx.Text);
                prd.ID =b;
                prd.price = a;
                prd.title = CmbTitle.Text;
            
                AppData.db.prods.Add(prd);
                AppData.db.SaveChanges();
                MessageBox.Show("Данные внесены успешно");
                NavigationService.GoBack();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
