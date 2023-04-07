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
    public partial class Form1 : Form
    {
        private List<Work> WorkSheet { get; set; }
        private Payment Payment { get; set; } 

        public Form1()
        {
            InitializeComponent();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;

            var parser = new WorkParser();
            paymentToolStripMenuItem.Enabled = false;
            Payment = null;
            WorkSheet = Loader<Work>.LoadFile(filename, parser);
            worksheetToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure you want to quit?",
                "Attention",
                MessageBoxButtons.YesNo
            );

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToShortDateString() + "\nOF5KAE", "About");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure you want to quit?",
                "Attention",
                MessageBoxButtons.YesNo
            );

            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var worksheetRegistrationForm = new WorkSheetRegistrationForm(WorkSheet);
            var result = worksheetRegistrationForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Payment == null) {
                    Payment = new Payment();
                    paymentToolStripMenuItem.Enabled = true;
                }

                Payment += worksheetRegistrationForm.Payment;
            }
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var paymentForm = new PaymentForm(Payment);
            paymentForm.Show();
        }
    }
}
