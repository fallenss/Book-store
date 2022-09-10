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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        public Catalog()
        {
            InitializeComponent();
            var currentGames = КнижныйEntities.GetContext().Товар.ToList();
            LViewBooks.ItemsSource = currentGames;
            Genre.SelectedIndex = 0;
            Cost.SelectedIndex = 0;
        }

        private void LViewBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LViewBooks.SelectedItem == null) return;
            Товар в = LViewBooks.SelectedItem as Товар;
            info.id_book = в.ID_товара;
            GoodInfo aboba = new GoodInfo(new Товар
            {
                Наименование = в.Наименование,
                Жанр = в.Жанр,
                Описание = в.Описание,
                Стоимость_одной = в.Стоимость_одной,
                Картинка = в.Картинка,
            });
            aboba.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cart a = new Cart();
            a.Show();
        }

        private void Findless()
        {
            var abobus = КнижныйEntities.GetContext().Товар.ToList();

            if (Genre.SelectedIndex > 0)
            {
                abobus = abobus.Where(p => p.Жанр.Contains(Genre.Text)).ToList();
            }
            
            if (Cost.SelectedIndex > 0)
            {
                double cost = 0;
                switch (Cost.SelectedIndex)
                {
                    case 1:
                        {
                            cost = 10;
                        }
                        break;
                    case 2:
                        {
                            cost = 20;
                        }
                        break;
                    case 3:
                        {
                            cost = 50;
                        }
                        break;
                    default: cost = 999999;
                        break;

                }

                abobus = abobus.Where(p => p.Стоимость_одной<=cost).ToList();
            }

            abobus = abobus.Where(p => p.Наименование.ToLower().Contains(Find.Text.ToLower())).ToList();


            LViewBooks.ItemsSource = abobus;
        }

        private void Find_TextChanged(object sender, TextChangedEventArgs e)
        {
            Findless();
        }

        private void Genre_GotFocus(object sender, RoutedEventArgs e)
        {
            Findless();
        }

        private void Cost_GotFocus(object sender, RoutedEventArgs e)
        {
            Findless();
        }
    }
}
