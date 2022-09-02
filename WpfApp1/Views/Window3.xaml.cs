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
using WpfApp1.ViewModels;
namespace WpfApp1.Views;

/// <summary>
/// Window3.xaml에 대한 상호 작용 논리
/// </summary>
public partial class Window3 : Window
{
    public Window3()
    {
        InitializeComponent();

        //Window1ViewModel people = new();

        //firstText.Text = people.Person1.ToString();
        //firstBorder.DataContext = people.Person2;
    }
}
