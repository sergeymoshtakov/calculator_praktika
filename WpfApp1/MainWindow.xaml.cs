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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculatorViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new CalculatorViewModel();
            this.DataContext = viewModel;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel = (CalculatorViewModel)this.DataContext;
            viewModel.Operation = (string)((ComboBox)sender).SelectedItem;
            viewModel.Result = viewModel.Calculate(viewModel.Operation);
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(TextBox1.Text, out int number))
            {
                viewModel = (CalculatorViewModel)this.DataContext;
                viewModel.Left_operand = number;
            }
        }
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(TextBox2.Text, out int number))
            {
                viewModel = (CalculatorViewModel)this.DataContext;
                viewModel.Right_operand = number;
            }
        }

    }
}
