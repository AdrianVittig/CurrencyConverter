using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    // F112519 Adrian Robert Vitig 
    public partial class Form1 : Form
    {
        // Fields for currency data and converter
        private CurrencyData currencyData;
        private CurrencyConverter currencyConverter;
        public Form1()
        {
            InitializeComponent();
            // Initialize currency data and converter
            currencyData = new CurrencyData();
            currencyConverter = new CurrencyConverter();


            // Fill the combo boxes with currency data
            var currencies = currencyData.GetAll();
            cmbFrom.DataSource = currencies.ToList();
            cmbTo.DataSource = currencies.ToList();
            cmbFrom.DisplayMember = "Code";
            cmbTo.DisplayMember = "Code";
        }

        //Event handler (button click) for converting the amount from one currency to another
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(txtAmount.Text);
                if(amount < 0)
                {
                    MessageBox.Show("Please enter a non-negative amount.", "Input Error");
                    return;
                }
                Currency fromCurr = (Currency)cmbFrom.SelectedItem;
                Currency toCurr = (Currency)cmbTo.SelectedItem;
                decimal convertedAmount = currencyConverter.Convert(amount, fromCurr, toCurr);
                lblResult.Text = $"{amount} {fromCurr.Code} = {convertedAmount:F2} {toCurr.Code}";

            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error");
            }
        }

        //Event handler (button click) for swapping the selected currencies in the combo boxes
        private void btnSwap_Click(object sender, EventArgs e)
        {
            var temp = cmbFrom.SelectedItem;
            cmbFrom.SelectedItem = cmbTo.SelectedItem;
            cmbTo.SelectedItem = temp;

        }
    }
}
