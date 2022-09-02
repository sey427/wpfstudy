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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button = new()
            {
                Width = 150,
                Height = 50,
                FontSize = 22,
                Content = "dynamic btn"
            };

            button.Click += Button_Click1;
            this.btnGrid.Children.Add(button);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dynamic Hello world");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
