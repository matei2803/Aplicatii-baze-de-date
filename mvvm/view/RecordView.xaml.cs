using expences.mvvm.viewmodel;
using expences.User;
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

namespace expences.mvvm.view
{
    /// <summary>
    /// Interaction logic for RecordView.xaml
    /// </summary>
    public partial class RecordView : UserControl
    {
        private List<Expense> expenses = new List<Expense>();

        public RecordView()
        {
            InitializeComponent();
        }

        // Define the Expense class
        private class Expense
        {
            public string Description { get; set; }
            public double Amount { get; set; }
            public DateTime Date { get; set; }
            public string Category { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtDescription.ContentStringFormat = null;
            txtAmount.ContentStringFormat = null;
            dpDate.SelectedDate = null;
            txtCategory.ContentStringFormat = null;
        }

        // Event handler for recording expenses
        private void RecordExpense_Click(object sender, RoutedEventArgs e)
        {
            string description = txtDescription.ContentStringFormat;
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description for the expense.");
                return;
            }

            if (!double.TryParse(txtAmount.ContentStringFormat, out double amount))
            {
                MessageBox.Show("Please enter a valid amount for the expense.");
                return;
            }

            DateTime date = dpDate.SelectedDate ?? DateTime.Now;
            string category = txtCategory.ContentStringFormat;

            // Create a new Expense object
            var expense = new Expense
            {
                Description = description,
                Amount = amount,
                Date = date,
                Category = category
            };

            expenses.Add(expense);

            // Optionally, you can clear the input fields
            txtDescription.ContentStringFormat = string.Empty;
            txtAmount.ContentStringFormat = string.Empty;
            dpDate.SelectedDate = null;
            txtCategory.ContentStringFormat = string.Empty;

            MessageBox.Show("Expense recorded successfully.");
        }

    }
}
