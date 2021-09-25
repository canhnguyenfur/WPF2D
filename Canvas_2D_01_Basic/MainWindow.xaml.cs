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

namespace Canvas_2D_01_Basic
{
    public class CanvasUtils
    {
        public double xMin { get; set; }
        public double yMin { get; set; }
        public double xMax { get; set; }
        public double yMax { get; set; }
        public Canvas plotCanvas { get; set; }
        public CanvasUtils(Canvas plotCanvas, double xMin, double yMin, double xMax, double yMax)
        {
            this.xMin = xMin;
            this.yMin = yMin;
            this.xMax = xMax;
            this.yMax = yMax;
            this.plotCanvas = plotCanvas;
        }
        public Tuple<double,double> Nomalize(double x, double y)
        {
            return new Tuple<double, double>(XNormalize(x), YNormalize(y));
        }
        private double XNormalize(double x)
        {
            double result = (x - xMin) * plotCanvas.ActualWidth / (xMax - xMin);
            return result;
        }
        private double YNormalize(double y)
        {
            double result = plotCanvas.ActualHeight - (y - yMin) * plotCanvas.ActualHeight / (yMax - yMin);
            return result;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
   
        }
    }
}
