using System;
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
using System.Collections.Generic;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, List<string>> teachersByBranch;

        public MainWindow()
        {
            InitializeComponent();
            // MainViewModel'i DataContext olarak ayarla.
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

        private void ClassList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (SubClassPanel != null)
                {
                    SubClassPanel.Visibility = Visibility.Visible;
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
    }
}
