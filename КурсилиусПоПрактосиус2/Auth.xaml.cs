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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            int max=0;
            foreach (var amogus in КнижныйEntities.GetContext().Корзина)
            {
                if (amogus.Номер_операции > max)
                {
                    max = Convert.ToInt32(amogus.Номер_операции);
                }
            }
            max++;
            info.num = max;
            Catalog a = new Catalog();
            a.Show();
            Close();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            bool temp = false;
            if (pas.Password == "")
            {
                pas.ToolTip = "Нормально впиши";
            }
            else
            {
                bool res2 = false;


                foreach (var item in КнижныйEntities.GetContext().Продавец) //Берёт все строки из таблицы Пользователи
                {
                    if (item.Пароль == pas.Password) // так же проверяет пароль
                    {
                        res2 = true;
                    }
                    if (res2 == true) //Если оба совпадают открывает основную форму (Info это статик класс для передачи инфы между формами, необязателен)
                    {
                        temp = true;
                        Admin cat = new Admin();
                        cat.Show();
                        Close();
                        break;
                    }
                }
                if (temp != true) //Проверка на фальшифку
                {
                    MessageBox.Show("Пароль неверный, повтори попытку.", "Ошибка!");
                }


            }
        }
    }
}
