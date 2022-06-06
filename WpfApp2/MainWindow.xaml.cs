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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            double x = 0,y = 0;
            try
            {
                x = Convert.ToDouble(X.Text);
            }
            catch
            {
                errors.AppendLine($"Неккоректно введено значение {X.Text}");
            }
            try
            {
                y = Convert.ToDouble(Y.Text);
            }
            catch
            {
                errors.AppendLine($"Неккоректно введено значение {Y.Text}");
            }
            if (errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            Result.Content = $"{(5 * x - 3 * y) * 2}";
        }
    }
}
