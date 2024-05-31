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
        LoadStudents(); // Changed from LoadTeachers
    }

    private async void LoadStudents() // Changed from LoadTeachers
    {
        try
        {
            var students = await _httpClient.GetFromJsonAsync<List<Student>>("RegistrationConfirmation/StudentsWithoutStudentNumber"); // Changed from Teacher/GetAllTeachersAsync
            StudentListBox.ItemsSource = students;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading students: {ex.Message}");
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? StudentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public int? ParentId { get; set; }
        public Parent? Parent { get; set; }
        
    }
    public class Parent
    {
        public int Id { get; set; }
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
   
}

    
   