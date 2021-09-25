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

namespace Canvas_2D_02_CustomizeCoordinate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CanvasUtils plotcanvas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            plotcanvas = new CanvasUtils(cv, 0, 0, 30, 30);
      
        }

  

        public void draw()
        {
            // (0,0)- (30,40)
            cv.Children.Clear();
            Line line = new Line();
            Tuple<double, double> p1 = plotcanvas.Nomalize(0, 0);
            Tuple<double, double> p2 = plotcanvas.Nomalize(30, 40);

            line.X1 = p1.Item1;
            line.Y1 = p1.Item2;

            line.X2 = p2.Item1;
            line.Y2 = p2.Item2;
            line.Stroke = Brushes.Red;

            cv.Children.Add(line);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            plotcanvas.xMin = Convert.ToDouble(txt_x1min.Text);
            plotcanvas.yMin = Convert.ToDouble(txt_y1min.Text);
            plotcanvas.xMax = Convert.ToDouble(txt_x2max.Text);
            plotcanvas.yMax = Convert.ToDouble(txt_y2max.Text);
            draw();
        }
    }
}
