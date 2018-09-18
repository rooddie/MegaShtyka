using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace All_In_One
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Process.Start("calculator.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Calculator228.exe");
                check();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("15.exe");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("Calculator228");
            if (pname.Length == 0)
                MessageBox.Show("nothing");
            else
                MessageBox.Show("run");
        }

        private void check()
        {
                Process[] pname = Process.GetProcessesByName("Calculator228");
                if (pname.Length != 0)
                    this.Hide();
                else
                    MessageBox.Show("run");
        }
    }
}
