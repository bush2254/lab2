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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(AA.Text);
            int B = Convert.ToInt32(BB.Text);
            int C = Convert.ToInt32(CC.Text);
            int SSquare = C * C, count = 0, S = A * B;
            while (S >= SSquare) { S -= SSquare; count++; }
            MessageBox.Show($"Максимальное число квадратов={count} Незанятая площадь ={S} ", "ответ");
        }
    }
 }

