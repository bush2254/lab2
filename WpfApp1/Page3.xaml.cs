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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = int.Parse(AA.Text);
            

           
            switch ((k+1)%7)
            {
                case 1:
                    MessageBox.Show($" Понедельник", "ответ");
                    break;
                case 2:
                    MessageBox.Show($" Вторник", "ответ");
                    break;
                case 3:
                    MessageBox.Show($" Среда", "ответ"); 
                    break;
                case 4:
                    MessageBox.Show($" Четверг", "ответ");
                    break;
                case 5:
                    MessageBox.Show($" Пятница", "ответ");
                    break;
                case 6:
                    MessageBox.Show($" Суббота", "ответ");
                    break;
                case 0:
                case 7:
                    MessageBox.Show($" Воскресенье", "ответ");
                    break;
                default:
                    MessageBox.Show($"Ошибка ", "ответ");
                    break;
            }
        }
    }
}
