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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YesButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            Canvas.SetLeft(YesButton, random.Next((int)(Canva.Width - YesButton.Width)));
            Canvas.SetTop(YesButton, random.Next((int)(Canva.Height - YesButton.Height)));
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("«Дякуюємо за економію!", "Подяка", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
