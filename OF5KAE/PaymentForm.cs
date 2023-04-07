using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF5KAE
{
    public partial class PaymentForm : Form
    {
        private Payment Payment { get; set; }

        public PaymentForm(Payment payment)
        {
            Payment = payment;
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            worksheetsNumberValueLabel.Text = Payment.WorksheetNumber.ToString();
            worksNumberValueLabel.Text = Payment.WorksNumber.ToString();
            materialCostValueLabel.Text = Payment.MaterialCost.ToString() + " Ft";
            serviceCostValueLabel.Text = Payment.ServiceCost.ToString() + " Ft";
            serviceTimeValueLabel.Text = (Payment.ServiceTime / 60).ToString() + " h " + (Payment.ServiceTime - 60 * (Payment.ServiceTime / 60)).ToString() + " m";
            totalValueLabel.Text = Payment.TotalCost.ToString() + " Ft";
        }

        private void materialCostValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
