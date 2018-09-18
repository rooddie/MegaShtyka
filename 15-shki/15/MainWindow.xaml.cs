using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _15
{
    public partial class MainWindow : Window
    {
        int butNull;
        int step = 0;

        public MainWindow()
        {
            InitializeComponent();
            gif();
            buttonContent();
            
        }

        async void gif()
        {
            while (true)
            {
                player.Stop();
                player.Play();
                await Task.Delay(1000);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);

            string content = Convert.ToString(button(position));

            string[] words = content.Split(' ');
            try
            {
                if (buttonCoord(position)[0] - buttonCoord(butNull)[0] == -1 | buttonCoord(position)[0] - buttonCoord(butNull)[0] == 1)
                    if (buttonCoord(position)[1] - buttonCoord(butNull)[1] == 0)
                    {
                        button(butNull).Content = words[1];
                        button(butNull).Visibility = Visibility.Visible;
                        button(Convert.ToInt16(position.ToString())).Content = " ";
                        butNull = Convert.ToInt16(Convert.ToInt16(position.ToString()));
                        button(butNull).Visibility = Visibility.Hidden;
                        step++;
                        steps.Content = step.ToString();
                    }

                if (buttonCoord(position)[1] - buttonCoord(butNull)[1] == -1 | buttonCoord(position)[1] - buttonCoord(butNull)[1] == 1)
                    if (buttonCoord(position)[0] - buttonCoord(butNull)[0] == 0)
                    {
                        button(butNull).Content = words[1];
                        button(butNull).Visibility = Visibility.Visible;
                        button(Convert.ToInt16(position.ToString())).Content = " ";
                        butNull = Convert.ToInt16(Convert.ToInt16(position.ToString()));
                        button(butNull).Visibility = Visibility.Hidden;
                        step++;
                        steps.Content = step.ToString();
                    }

            }
            catch { }
        }

        private void buttonContent()
        {
            string[] data = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "  " };
            var random = new Random(DateTime.Now.Millisecond);
            data = data.OrderBy(x => random.Next()).ToArray();

            for (int i = 0; i < 16; i++)
            {
                button(i).Content = data[i];

                if (data[i] == "  ")
                {
                    butNull = i;
                    button(butNull).Visibility = Visibility.Hidden;
                }

            }
        }

        private Button button(int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }

        private int[] buttonCoord(int position)
        {
            switch (position)
            {
                case 0: return new int[2] { 0, 0 };
                case 1: return new int[2] { 0, 1 };
                case 2: return new int[2] { 0, 2 };
                case 3: return new int[2] { 0, 3 };
                case 4: return new int[2] { 1, 0 };
                case 5: return new int[2] { 1, 1 };
                case 6: return new int[2] { 1, 2 };
                case 7: return new int[2] { 1, 3 };
                case 8: return new int[2] { 2, 0 };
                case 9: return new int[2] { 2, 1 };
                case 10: return new int[2] { 2, 2 };
                case 11: return new int[2] { 2, 3 };
                case 12: return new int[2] { 3, 0 };
                case 13: return new int[2] { 3, 1 };
                case 14: return new int[2] { 3, 2 };
                case 15: return new int[2] { 3, 3 };
                default: return null;
            }
        }

        async private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int delay = 0;
            step = 0;
            steps.Content = step.ToString();
            for (int i = 0; i < 50; i++)
            {
                await Task.Delay(delay);
                button(butNull).Visibility = Visibility.Visible;
                buttonContent();
                delay += 1;

            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            grid2.Visibility = Visibility.Hidden;
        }
    }
}
