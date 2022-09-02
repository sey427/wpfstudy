using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
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
using WpfApp1.Controls;

namespace WpfApp1.Views
{
    /// <summary>
    /// Window4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();

            /*CustomControl1 ctr = (CustomControl1)FindName("CustCtrl");

            MessageBox.Show($$"""{Id:{{ctr.Id}},Age:{{ctr.Age}}, Name:{{ctr.Irum}}, Gender:{{ctr.Gender}}}""");*/
        }

        private void PersonButton_Click(object sender, RoutedEventArgs e)
        {
            TestCall(sender);
        }

        private void PersonButton_Click_1(object sender, RoutedEventArgs e)
        {
            TestCall(sender);
        }

        private void PersonButton_Click_2(object sender, RoutedEventArgs e)
        {
            TestCall(sender);
        }

        private void TestCall(object sender)
        {
            PersonButton temp = (PersonButton)sender;
            MessageBox.Show($$"""{Id:{{temp.Id}},Age:{{temp.Age}}, Name:{{temp.Irum}}, Gender:{{temp.Gender}}}""", Title = "Person Button");
            CustomControl1 ctr = (CustomControl1)FindName("CustCtrl");
            MessageBox.Show($$"""{Id:{{ctr.Id}},Age:{{ctr.Age}}, Name:{{ctr.Irum}}, Gender:{{ctr.Gender}}}""", Title = "Custom Control");

            temp.CustomEventTest1();
            temp.RealCustomEventTest();
            temp.RealWorldCustomEventTest();
        }


        private void PersonButton_CustomClick(object sender, RoutedEventArgs e)
        {
            PersonButton? temp = e.Source as PersonButton;
            MessageBox.Show(temp?.Irum, Title = "Custom Event");
        }

        private void PersonButton_RealCustomClick(object sender, CustomEventArgs e)
        {
            MessageBox.Show($$"""{Id:{{e.Saram?.Id}},Age:{{e.Saram?.Age}}, Name:{{e.Saram?.Name}}, Gender:{{e.Saram?.Gender}}}""".ToString(), Title = "Real Custom Event");
        }

        private void PersonButton_RealCustomClick_1(object sender, CustomEventArgs e)
        {
            MessageBox.Show($$"""{Id:{{e.Saram?.Id}},Age:{{e.Saram?.Age}}, Name:{{e.Saram?.Name}}, Gender:{{e.Saram?.Gender}}}""".ToString(), Title = "Real Custom Event");
        }

        private void PersonButton_RealCustomClick_2(object sender, CustomEventArgs e)
        {
            MessageBox.Show($$"""{Id:{{e.Saram?.Id}},Age:{{e.Saram?.Age}}, Name:{{e.Saram?.Name}}, Gender:{{e.Saram?.Gender}}}""".ToString(), Title = "Real Custom Event");
        }

        private void PersonButton_RealWorldCustomClick(object sender, RealWorldCustomEventArgs e)
        {
            MessageBox.Show(e.Name, Title = "Real World Custom Event");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("System.Windows.Controls.TextBox:asasasasaaa");
        }
    }
}
