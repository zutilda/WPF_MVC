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

namespace WPF_MVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Models.tbOne = One;
            Models.tbTwo = Two;
            Models.tbOperation = Operation;


        }

        private void cbOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Models.Combo = cbOperation.SelectedIndex;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Models.ResultOne = Convert.ToDouble(One.Text);
            Models.ResultTwo = Convert.ToDouble(Two.Text);
            Models.Result = cbOperation.SelectedIndex;
        }
    }
}
