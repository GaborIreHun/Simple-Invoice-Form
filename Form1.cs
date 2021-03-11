using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class frmInvoice : Form
    {
        public int numberOfInvoice = 0;
        private decimal totalOfInvoices = 0;
        private decimal invoiceAverage = 0;
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;

            if(subtotal >=500)
            {
                discountPercent = .2m;            
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            numberOfInvoice++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoice;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtNumberOfInvoices.Text = numberOfInvoice.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            txtSubtotal.Focus();


        }

        private void txtTotalOfInvoices_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";
            txtDiscountPercent.Text = "";
            txtDiscountAmount.Text = "";
            txtTotal.Text = "";
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            numberOfInvoice = 0;
            totalOfInvoices = 0;
            invoiceAverage = 0;
        }
    }
}
