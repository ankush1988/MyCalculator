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

namespace MyCalulator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblResult.Content = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            result = Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text);
            lblResult.Content = result.ToString();
        }
    }
}
