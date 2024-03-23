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

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int quantity;
            double price;
            int delivery = 25;
            int wrap = 5;
            double GST = 1.1;
            double total;

            try
            {
                quantity = int.Parse(quantityTextBox.Text);
                price = double.Parse(priceTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter data again", "Data Entry Error");
                return;
            }

            total = quantity * price;


            totalPaymentTextBlock.Text = total.ToString("C");
            totalChargeTextBlock.Text = (total + delivery).ToString("C");
            wrapChargeTextBlock.Text = (total + delivery + wrap).ToString("C");
            gstChargeTextBlock.Text = ((total + delivery + wrap) * GST).ToString("C");
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
