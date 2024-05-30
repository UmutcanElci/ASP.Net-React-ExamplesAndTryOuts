using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                Students = DatabaseHelper.GetStudents();
                StudentListBox.ItemsSource = Students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenciler yüklenirken bir hata oluştu: {ex.Message}");
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

        private void StudentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentListBox.SelectedItem is Student selectedStudent)
            {
                StudentName.Text = selectedStudent.Name;
                StudentSurname.Text = selectedStudent.Surname;
                StudentAge.Text = selectedStudent.Age.ToString();
                StudentMotherName.Text = selectedStudent.MotherName;
                StudentFatherName.Text = selectedStudent.FatherName;
                StudentBirthDate.Text = selectedStudent.BirthDate.ToString("yyyy-MM-dd");
                StudentMotherPhoneNumber.Text = selectedStudent.MotherPhoneNumber;
            }
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
        public int Age { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MotherPhoneNumber { get; set; }
    }

    public static class DatabaseHelper
    {
        public static ObservableCollection<Student> GetStudents()
        {
            var students = new ObservableCollection<Student>();
            string connectionString = ConfigurationManager.ConnectionStrings["StudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Veritabanı bağlantı dizesi bulunamadı.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Students";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                MotherName = reader["MotherName"].ToString(),
                                FatherName = reader["FatherName"].ToString(),
                                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                MotherPhoneNumber = reader["MotherPhoneNumber"].ToString()
                            });
                        }
                    }
                }
            }

            return students;
        }
    }
}
