using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace WpfApp1
{
    public class MainViewModel
    {
        public SeriesCollection PieSeriesCollection { get; set; }

        public MainViewModel()
        {
            PieSeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "Students", Values = new ChartValues<double> { 10 }, DataLabels = true, Fill = Brushes.Blue },
                new PieSeries { Title = "Teachers", Values = new ChartValues<double> { 20 }, DataLabels = true, Fill = Brushes.Green },
                new PieSeries { Title = "Classes", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = Brushes.Red }
            };
        }
    }
}