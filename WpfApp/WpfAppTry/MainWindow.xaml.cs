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

namespace WpfAppTry;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Login_Click(object sender, RoutedEventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Password;

        if (username == "admin" && password == "admin")
        {
            MessageBox.Show("Login successful!");
            // Navigate to the main application window or perform further actions
        }
        else
        {
            MessageBox.Show("Invalid username or password. Please try again.");
        }
    }
}