using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, List<string>> teachersByBranch;
        private Dictionary<string, int> classLimits = new Dictionary<string, int>
        {
            {"3rd Grade", 20},
            {"4th Grade", 20},
            {"5th Grade", 20},
            {"6th Grade", 20},
            {"7th Grade", 20},
            {"8th Grade", 20}
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            teachersByBranch = new Dictionary<string, List<string>>();
            string[] branches = { "Mathematics", "Physics", "Chemistry", "Biology", "Turkish", "History", "Geography", "English", "German", "French", "Music", "Art", "Physical Education", "Religious Education", "Philosophy", "Computer Science", "Science", "Class Teacher" };
            foreach (var branch in branches)
            {
                teachersByBranch[branch] = new List<string>();
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

        private void ClassList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (ClassListBox.SelectedItem != null)
                {
                    SubClassPanel.Visibility = Visibility.Visible;
                    ClassDetailsPanel.Visibility = Visibility.Collapsed;
                    SubClassListBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SubClassList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (SubClassListBox.SelectedItem != null)
                {
                    string selectedClass = (ClassListBox.SelectedItem as ListBoxItem)?.Content.ToString();
                    string selectedSubClass = (SubClassListBox.SelectedItem as ListBoxItem)?.Content.ToString();
                    if (!string.IsNullOrEmpty(selectedClass) && !string.IsNullOrEmpty(selectedSubClass))
                    {
                        ClassDetailsPanel.Visibility = Visibility.Visible;
                        // Örnek öğrenci sayısı ve limit verileri
                        int studentCount = new Random().Next(0, classLimits[selectedClass]);
                        StudentCount.Text = $"Students: {studentCount}";
                        ClassLimit.Text = $"Limit: {classLimits[selectedClass]}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UnassignedStudentsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (UnassignedStudentsListBox.SelectedItem != null)
                {
                    string selectedStudent = (UnassignedStudentsListBox.SelectedItem as ListBoxItem)?.Content.ToString();
                    if (!string.IsNullOrEmpty(selectedStudent))
                    {
                        StudentDetailsPanel.Visibility = Visibility.Visible;
                        // Örnek öğrenci detayları, SQL'den veri alınacak
                        StudentName.Text = $"Name: {selectedStudent}";
                        StudentSurname.Text = "Surname: Example";
                        MotherName.Text = "Mother's Name: Example";
                        FatherName.Text = "Father's Name: Example";
                        StudentNumber.Text = "Student Number: 12345";
                        MotherPhone.Text = "Mother's Phone: 123-456-7890";
                        FatherPhone.Text = "Father's Phone: 098-765-4321";
                        Address.Text = "Address: Example Street, Example City";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveTeacher_Click(object sender, RoutedEventArgs e)
        {
            string teacherName = TeacherName.Text;
            string selectedBranch = (BranchComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (!string.IsNullOrEmpty(teacherName) && !string.IsNullOrEmpty(selectedBranch))
            {
                teachersByBranch[selectedBranch].Add(teacherName);
                MessageBox.Show($"{teacherName} has been registered to the {selectedBranch} branch.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please enter the teacher name and select a branch.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteTeacher_Click(object sender, RoutedEventArgs e)
        {
            string teacherName = TeacherName.Text;
            string selectedBranch = (BranchComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (!string.IsNullOrEmpty(teacherName) && !string.IsNullOrEmpty(selectedBranch))
            {
                if (teachersByBranch[selectedBranch].Remove(teacherName))
                {
                    MessageBox.Show($"{teacherName} has been removed from the {selectedBranch} branch.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"{teacherName} not found in the {selectedBranch} branch.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the teacher name and select a branch.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BranchList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BranchListBox.SelectedItem != null)
            {
                string selectedBranch = (BranchListBox.SelectedItem as ListBoxItem)?.Content.ToString();
                if (!string.IsNullOrEmpty(selectedBranch))
                {
                    TeacherListBox.Items.Clear();
                    foreach (var teacher in teachersByBranch[selectedBranch])
                    {
                        TeacherListBox.Items.Add(new ListBoxItem { Content = teacher });
                    }
                }
            }
        }

        private void SaveClassChanges_Click(object sender, RoutedEventArgs e)
        {
            // Sınıf değişikliklerini kaydetmek için kod
        }

        private void DeleteClass_Click(object sender, RoutedEventArgs e)
        {
            // Sınıfı silmek için kod
        }

        private void ChangeClass_Click(object sender, RoutedEventArgs e)
        {
            // Sınıf değiştirmek için kod
        }
    }
}
