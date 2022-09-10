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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
            var currentGames = КнижныйEntities.GetContext().Корзина.ToList();
            currentGames.Clear();
            foreach (var amogus in КнижныйEntities.GetContext().Корзина)
            {
                if (info.num == amogus.Номер_операции)
                {
                    currentGames.Add(amogus);
                    info.id_book = amogus.ID_товара;

                }
            }
            double sum = 0;
            foreach (var amogus in currentGames)
            {
                sum += amogus.Количество * amogus.Товар.Стоимость_одной;
            }
            Itogo.Text = sum.ToString();
            DataSour.ItemsSource = currentGames;
            

        }



        private void Buy_Click(object sender, RoutedEventArgs e)
        {

            if (name.Text == "" | tel.Text == "")
            {

                Buy.ToolTip = "Нормально впиши имя и телефон.";
            }
            else
            {
                bool res = true;
                Покупатель Fresh = new Покупатель
                {
                    ФИО = name.Text,
                    Номер_Телефона = tel.Text,
                };
                foreach (var item in КнижныйEntities.GetContext().Покупатель)
                {
                    if (item.Номер_Телефона == tel.Text)
                    {
                        res = false;
                        break;
                    }
                }
                if (res == true)
                {
                    КнижныйEntities.GetContext().Покупатель.Add(Fresh);
                    КнижныйEntities.GetContext().SaveChanges();
                }


                Покупка FreshBuy = new Покупка
                {
                    ID_статуса = 1,
                    ID_номер = 1,
                    Итоговая_стоимость = Convert.ToDouble(Itogo.Text),
                };
                foreach (var item in КнижныйEntities.GetContext().Покупатель)
                {
                    if (item.Номер_Телефона == tel.Text)
                    {
                        FreshBuy.Индивидуальный_номер_заказа = item.Индивидуальный_номер_заказа;
                    }
                }
                foreach (var item in КнижныйEntities.GetContext().Корзина)
                {
                    FreshBuy.Номер_корзины = item.Номер_корзины;
                }

                bool res2 = true;

                foreach (var item in КнижныйEntities.GetContext().Покупка)
                {
                    if (item.Номер_корзины == FreshBuy.Номер_корзины)
                    {
                        res2 = false;
                    }

                    if (res2 == false)
                    {
                        MessageBox.Show("Так уже купил типа...", "Ошибка!");
                        break;
                    }
                }
                if (res2 == true)
                {
                    КнижныйEntities.GetContext().Покупка.Add(FreshBuy); 
                    КнижныйEntities.GetContext().SaveChanges();
                    MessageBox.Show("Поздравляем с покупкой!", "Успешно!");
                }
            }
        }

        

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var a = DataSour.SelectedItems.Cast<Корзина>().ToList();
            КнижныйEntities.GetContext().Корзина.RemoveRange(a);
            КнижныйEntities.GetContext().SaveChanges();
            var currentGames = КнижныйEntities.GetContext().Корзина.ToList();
            currentGames.Clear();
            foreach (var amogus in КнижныйEntities.GetContext().Корзина)
            {
                if (info.num == amogus.Номер_операции)
                {
                    currentGames.Add(amogus);
                    info.id_book = amogus.ID_товара;

                }
            }
            double aa = 0;
            foreach (var amogus in currentGames)
            {
                aa += amogus.Количество * amogus.Товар.Стоимость_одной;
            }
            Itogo.Text = "Итоговая стоимость: " + aa.ToString();
            DataSour.ItemsSource = currentGames;
        }

        private void Update_Click(object sender, RoutedEventArgs e) // Редактирование
        {
            var currentGames = DataSour.SelectedItems.Cast<Корзина>().ToList();
            КнижныйEntities.GetContext().SaveChanges();
            double aa = 0;
            foreach (var amogus in currentGames)
            {
                aa += amogus.Количество * amogus.Товар.Стоимость_одной;
            }
            Itogo.Text = "Итоговая стоимость: " + aa.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            org.Visibility = Visibility.Visible;
            adres.Visibility = Visibility.Visible;
            UNN.Visibility = Visibility.Visible;
            Bank.Visibility = Visibility.Visible;
            Code.Visibility = Visibility.Visible;
            RS.Visibility = Visibility.Visible;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            org.Visibility = Visibility.Hidden;
            adres.Visibility = Visibility.Hidden;
            UNN.Visibility = Visibility.Hidden;
            Bank.Visibility = Visibility.Hidden;
            Code.Visibility = Visibility.Hidden;
            RS.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
