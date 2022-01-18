using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Task_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckBox1.IsChecked = true;
            CheckBox2.IsChecked = false;
            CheckBox3.IsChecked = null;
        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox1.Content = "Checked";
            if (CheckBox2.IsChecked == true)
            {
                CheckBox3.IsChecked = true;
                CheckBox3.Content = "Checked";
            }
            else
            {
                CheckBox3.IsChecked = null;
                CheckBox3.Content = "Indeterminate";
            }
        }

        private void CheckBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox1.Content = "Unchecked";
            if (CheckBox2.IsChecked == true)
            {
                CheckBox3.IsChecked = null;
                CheckBox3.Content = "Indeterminate";
            }
            else
            {
                CheckBox3.IsChecked = false;
                CheckBox3.Content = "Unchecked";
            }
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox2.Content = "Checked";
            if (CheckBox1.IsChecked == true)
            {
                CheckBox3.IsChecked = true;
                CheckBox3.Content = "Checked";
            }
            else
            {
                CheckBox3.IsChecked = null;
                CheckBox3.Content = "Indeterminate";
            }
        }

        private void CheckBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox2.Content = "Unchecked";
            if (CheckBox1.IsChecked == true)
            {
                CheckBox3.IsChecked = null;
                CheckBox3.Content = "Indeterminate";
            }
            else
            {
                CheckBox3.IsChecked = false;
                CheckBox3.Content = "Unchecked";
            }
        }

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox1.IsChecked = true;
            CheckBox2.IsChecked = true;
            CheckBox3.Content = "Checked";
        }

        private void CheckBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox1.IsChecked = false;
            CheckBox2.IsChecked = false;
            CheckBox3.Content = "Unchecked";
        }
    }
}
