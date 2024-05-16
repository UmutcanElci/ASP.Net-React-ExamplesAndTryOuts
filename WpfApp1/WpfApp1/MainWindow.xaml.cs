using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            this.DragMove();
        }
    }

    private void Dashboard_Click(object sender, RoutedEventArgs e)
    {
        DashboardContent.Visibility = Visibility.Visible;
        RegisterContent.Visibility = Visibility.Collapsed;
        ClassContent.Visibility = Visibility.Collapsed;
        TeacherContent.Visibility = Visibility.Collapsed;
        InfoContent.Visibility = Visibility.Collapsed;
    }

    private void Users_Click(object sender, RoutedEventArgs e)
    {
        DashboardContent.Visibility = Visibility.Collapsed;
        RegisterContent.Visibility = Visibility.Visible;
        ClassContent.Visibility = Visibility.Collapsed;
        TeacherContent.Visibility = Visibility.Collapsed;
        InfoContent.Visibility = Visibility.Collapsed;
    }
    
    private void Class_Click(object sender, RoutedEventArgs e)
    {
        DashboardContent.Visibility = Visibility.Collapsed;
        RegisterContent.Visibility = Visibility.Collapsed;
        ClassContent.Visibility = Visibility.Visible;
        TeacherContent.Visibility = Visibility.Collapsed;
        InfoContent.Visibility = Visibility.Collapsed;
    }
    
    private void Teacher_Click(object sender, RoutedEventArgs e)
    {
        DashboardContent.Visibility = Visibility.Collapsed;
        RegisterContent.Visibility = Visibility.Collapsed;
        ClassContent.Visibility = Visibility.Collapsed;
        TeacherContent.Visibility = Visibility.Visible;
        InfoContent.Visibility = Visibility.Collapsed;
    }
    private void Info_Click(object sender, RoutedEventArgs e)
    {
        DashboardContent.Visibility = Visibility.Collapsed;
        RegisterContent.Visibility = Visibility.Collapsed;
        ClassContent.Visibility = Visibility.Collapsed;
        TeacherContent.Visibility = Visibility.Collapsed;
        InfoContent.Visibility = Visibility.Visible;
    }
    
}