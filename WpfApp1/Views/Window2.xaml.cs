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

namespace WpfApp1.Views
{
    /// <summary>
    /// Window2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            #region Canvas test
            //Canvas canv = new Canvas();

            ////add the Canvas as sole child of Window
            //this.Content = canv;
            //canv.Margin = new Thickness(0, 0, 0, 0);
            //canv.Background = new SolidColorBrush(Colors.White);

            ////The Rectangle
            //Rectangle r = new Rectangle();
            //r.Fill = new SolidColorBrush(Colors.Blue);
            //r.Stroke = new SolidColorBrush(Colors.Blue);
            //r.Width = 145;
            //r.Height = 126;
            //r.SetValue(Canvas.LeftProperty, (double)124);
            //r.SetValue(Canvas.TopProperty, (double)122);
            //canv.Children.Add(r);

            ////The Ellipse
            //Ellipse el = new Ellipse();
            //el.Fill = new SolidColorBrush(Colors.Green);
            //el.Stroke = new SolidColorBrush(Colors.Green);
            //el.Width = 121;
            //el.Height = 100;
            //el.SetValue(Canvas.ZIndexProperty, 1);
            //el.SetValue(Canvas.LeftProperty, (double)195);
            //el.SetValue(Canvas.TopProperty, (double)191);
            //canv.Children.Add(el);
            #endregion
        }
    }
}
