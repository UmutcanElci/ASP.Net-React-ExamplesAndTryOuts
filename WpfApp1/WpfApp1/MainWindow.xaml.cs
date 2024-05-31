using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; }
        private HttpClient _httpClient;
        public MainWindow()
        {
            InitializeComponent();
            _httpClient = new HttpClient{BaseAddress = new Uri("http://localhost:5030/api")};
            DataContext = this;
            LoadStudents();
        }

        private async void LoadStudents()
        {
            try
            {
                var students = await _httpClient.GetFromJsonAsync<List<Student>>("RegistrationConfirmation/StudentsWithoutStudentNumber");
                StudentListBox.ItemsSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenciler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }
        private void StudentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = (Student)StudentListBox.SelectedItem;
            if (selectedStudent != null)
            {
                StudentName.Text = $"{selectedStudent.Name} {selectedStudent.Surname}";
                StudentMotherName.Text = selectedStudent.Parent?.MotherName ?? "N/A";
                StudentFatherName.Text = selectedStudent.Parent?.FatherName ?? "N/A";
                StudentAddress.Text = selectedStudent.Address;
                StudentGender.Text = selectedStudent.Gender ? "Male" : "Female";
                StudentBirthDate.Text = selectedStudent.DateOfBirth.ToShortDateString();
                StudentEmail.Text = selectedStudent.Email;
            }
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

       

        private void ConfirmStudent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Öğrenci onaylandı!");
        }

        private void SaveClass_Click(object sender, RoutedEventArgs e)
        {
            // Sınıf kaydetme işlemi burada gerçekleştirilecek
            MessageBox.Show("Sınıf kaydedildi!");
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
