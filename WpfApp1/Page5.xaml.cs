using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Y = int.Parse(AA.Text);
            int Y1 = Y % 100;
            int Y2 = Y / 100;
            if (Y1 % 10 != 0)
            {
                Y2++;
            }
            MessageBox.Show($"{Y2}веу", "ответ");
        }
    }
}
