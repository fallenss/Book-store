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

namespace КурсилиусПоПрактосиус2
{
    /// <summary>
    /// Логика взаимодействия для element.xaml
    /// </summary>
    public partial class element : Window
    {
        public element()
        {
            InitializeComponent();
            Gridetsky.ItemsSource = КнижныйEntities.GetContext().Товар.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var a = Gridetsky.SelectedItems.Cast<Товар>().ToList();
            КнижныйEntities.GetContext().Товар.AddRange(a);
            КнижныйEntities.GetContext().SaveChanges();
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            Gridetsky.SelectedItems.Cast<Товар>().ToList();
            КнижныйEntities.GetContext().SaveChanges();
        }

        private void smert_Click(object sender, RoutedEventArgs e)
        {
            var a = Gridetsky.SelectedItems.Cast<Товар>().ToList();
            КнижныйEntities.GetContext().Товар.RemoveRange(a);
            КнижныйEntities.GetContext().SaveChanges();
        }
    }
}
