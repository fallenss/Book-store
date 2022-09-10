using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для GoodInfo.xaml
    /// </summary>
    public partial class GoodInfo : Window
    {
        Товар товар { get; set; }
        public GoodInfo(Товар p)
        {
            InitializeComponent();
            товар = p;
            this.DataContext = товар;

            foreach (var amogus in КнижныйEntities.GetContext().Товар)
            {
                if (amogus.Наименование == p.Наименование)
                {
                    Cost.Text = "Стоимость: " + amogus.Стоимость_одной;
                }
            }
                    foreach (var amogus in КнижныйEntities.GetContext().лого)
            {
                if (amogus.id == p.Картинка)
                {
                    MemoryStream mem = new MemoryStream(amogus.screen);
                    var bmp = new BitmapImage();
                    bmp.BeginInit();
                    bmp.CacheOption = BitmapCacheOption.OnLoad;
                    bmp.StreamSource = mem;
                    bmp.EndInit();
                    bmp.Freeze();
                    Logo.Source = bmp;
                }
            }
        }
        public static BitmapImage ConvertFromByte(byte[] imageData)
        {
            if (imageData == null)
            {
                return null;
            }
            MemoryStream memorystream = new MemoryStream();

            memorystream.Write(imageData, 0, (int)imageData.Length);

            BitmapImage imgsource = new BitmapImage();

            imgsource.BeginInit();
            imgsource.StreamSource = memorystream;
            imgsource.EndInit();

            return imgsource;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            bool res = true;


            Корзина fresh = new Корзина
            {
                ID_товара = info.id_book,
                Количество = Convert.ToInt32(Count.Text),
                Номер_операции = info.num,
            };
            foreach (var item in КнижныйEntities.GetContext().Корзина)
            {
                if (item.ID_товара == fresh.ID_товара & item.Номер_операции == fresh.Номер_операции)
                {
                    res = false;
                }

                if (res == false)
                {
                    MessageBox.Show("Так уже в корзине...", "Ошибка!");
                    break;
                }
            }
            if (res == true)
            {
                КнижныйEntities.GetContext().Корзина.Add(fresh);
                КнижныйEntities.GetContext().SaveChanges();
                MessageBox.Show("Книга успешно добавлена в корзину...", "Успешно!");
            }
        }

        private void Count_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(Count.Text);
            }
            catch (System.FormatException)
            {
                Count.ToolTip = "Цифру впиши, дуралей";
                Count.Text = "1";
            }
            
        }
    }
}
