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
                new PieSeries { Title = "3rd Grade", Values = new ChartValues<double> { 10 }, DataLabels = true, Fill = Brushes.Blue },
                new PieSeries { Title = "4th Grade", Values = new ChartValues<double> { 15 }, DataLabels = true, Fill = Brushes.Green },
                new PieSeries { Title = "5th Grade", Values = new ChartValues<double> { 12 }, DataLabels = true, Fill = Brushes.Red },
                new PieSeries { Title = "6th Grade", Values = new ChartValues<double> { 8 }, DataLabels = true, Fill = Brushes.Purple },
                new PieSeries { Title = "7th Grade", Values = new ChartValues<double> { 20 }, DataLabels = true, Fill = Brushes.Orange },
                new PieSeries { Title = "8th Grade", Values = new ChartValues<double> { 17 }, DataLabels = true, Fill = Brushes.Yellow }
            };
        }
    }
}