using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace WpfApp1
{
    public class MainViewModel
    {
        public SeriesCollection OverallSeriesCollection { get; set; }
        public SeriesCollection Grade3SeriesCollection { get; set; }
        public SeriesCollection Grade4SeriesCollection { get; set; }
        public SeriesCollection Grade5SeriesCollection { get; set; }
        public SeriesCollection Grade6SeriesCollection { get; set; }
        public SeriesCollection Grade7SeriesCollection { get; set; }
        public SeriesCollection Grade8SeriesCollection { get; set; }

        public MainViewModel()
        {
            OverallSeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "3rd Grade", Values = new ChartValues<double> { 10 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0f4a0")) }, // Açık Yeşil
                new PieSeries { Title = "4th Grade", Values = new ChartValues<double> { 15 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#04a28b")) }, // Teal
                new PieSeries { Title = "5th Grade", Values = new ChartValues<double> { 12 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#fe6039")) }, // Turuncu
                new PieSeries { Title = "6th Grade", Values = new ChartValues<double> { 8 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#79bd8e")) }, // Yeşil
                new PieSeries { Title = "7th Grade", Values = new ChartValues<double> { 20 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eaf5df")) }, // Soluk Sarı
                new PieSeries { Title = "8th Grade", Values = new ChartValues<double> { 17 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#78c3a3")) }  // Açık Teal
            };

            Grade3SeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "A", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4D4D4D")) }, // Gri
                new PieSeries { Title = "B", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FE5F55")) }, // Kırmızı
                new PieSeries { Title = "C", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4D06F")) }, // Sarı
                new PieSeries { Title = "D", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }, // Mavi
                new PieSeries { Title = "E", Values = new ChartValues<double> { 2 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8CC084")) }, // Açık Yeşil
                new PieSeries { Title = "F", Values = new ChartValues<double> { 2 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }  // Teal
            };

            Grade4SeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "A", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4D4D4D")) }, // Gri
                new PieSeries { Title = "B", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FE5F55")) }, // Kırmızı
                new PieSeries { Title = "C", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4D06F")) }, // Sarı
                new PieSeries { Title = "D", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }, // Mavi
                new PieSeries { Title = "E", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8CC084")) }, // Açık Yeşil
                new PieSeries { Title = "F", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }  // Teal
            };

            Grade5SeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "A", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4D4D4D")) }, // Gri
                new PieSeries { Title = "B", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FE5F55")) }, // Kırmızı
                new PieSeries { Title = "C", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4D06F")) }, // Sarı
                new PieSeries { Title = "D", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }, // Mavi
                new PieSeries { Title = "E", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8CC084")) }, // Açık Yeşil
                new PieSeries { Title = "F", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }  // Teal
            };

            Grade6SeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "A", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4D4D4D")) }, // Gri
                new PieSeries { Title = "B", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FE5F55")) }, // Kırmızı
                new PieSeries { Title = "C", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4D06F")) }, // Sarı
                new PieSeries { Title = "D", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }, // Mavi
                new PieSeries { Title = "E", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8CC084")) }, // Açık Yeşil
                new PieSeries { Title = "F", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }  // Teal
            };

            Grade7SeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "A", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4D4D4D")) }, // Gri
                new PieSeries { Title = "B", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FE5F55")) }, // Kırmızı
                new PieSeries { Title = "C", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4D06F")) }, // Sarı
                new PieSeries { Title = "D", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }, // Mavi
                    new PieSeries { Title = "E", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8CC084")) }, // Açık Yeşil
                new PieSeries { Title = "F", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }  // Teal
            };

            Grade8SeriesCollection = new SeriesCollection
            {
                new PieSeries { Title = "A", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4D4D4D")) }, // Gri
                new PieSeries { Title = "B", Values = new ChartValues<double> { 4 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FE5F55")) }, // Kırmızı
                new PieSeries { Title = "C", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4D06F")) }, // Sarı
                new PieSeries { Title = "D", Values = new ChartValues<double> { 3 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }, // Mavi
                new PieSeries { Title = "E", Values = new ChartValues<double> { 5 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8CC084")) }, // Açık Yeşil
                new PieSeries { Title = "F", Values = new ChartValues<double> { 2 }, DataLabels = true, Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B9C9C")) }  // Teal
            };
            }
        }
    }
