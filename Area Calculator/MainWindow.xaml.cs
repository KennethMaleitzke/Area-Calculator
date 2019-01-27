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

namespace Area_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            double totalCost;
            double area;

            if (validateInputs())
            {
                area = double.Parse(TextBox_Length.Text) + double.Parse(TextBox_Width.Text);
                totalCost = double.Parse(TextBox_Budget.Text) / area;

                TextBox_Cost.Text = totalCost.ToString();
            }
        }

        private bool validateInputs()
        {
            bool validInputs = true;

            if (
                !double.TryParse(TextBox_Length.Text, out double length) ||
                !double.TryParse(TextBox_Width.Text, out double width) ||
                !double.TryParse(TextBox_Budget.Text, out double budget)
                )
            {
                MessageBox.Show("Please enter numbers for each field");
                validInputs = false;
                ResetInputs();
            }
            return validInputs;
        }
        
        private void ResetInputs()
        {
            TextBox_Length.Text = "";
            TextBox_Width.Text = "";
            TextBox_Budget.Text = "";
            TextBox_Length.Focus();
        }

        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.ShowDialog();
        }
        private void Volume_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
