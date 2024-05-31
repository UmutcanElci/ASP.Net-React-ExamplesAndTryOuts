using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using System.Net.Http.Json;
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

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private HttpClient _httpClient;

    public MainWindow()
    {
        InitializeComponent();
        _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5030/api/") };
        LoadTeachers();
    }

    private async void LoadTeachers()
    {
        try
        {
            var teachers = await _httpClient.GetFromJsonAsync<List<Teacher>>("Teacher/GetAllTeachersAsync");
            TeacherListBox.ItemsSource = teachers;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading teachers: {ex.Message}");
        }
    }

    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        // Optional: Add a property to display the full name in the ListBox
        
    }
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(11)]
        public string StudentNumber { get; set; }

        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        
        public Teacher Teacher { get; set; }
    }
}