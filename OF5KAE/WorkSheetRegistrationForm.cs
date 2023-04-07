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
    public partial class WorkSheetRegistrationForm : Form
    {
        private List<Work> Works { get; }
        public Payment Payment { get; private set; } 

        public WorkSheetRegistrationForm(List<Work> works)
        {
            Works = works;
            InitializeComponent();
        }

        private void WorkSheetRegistrationForm_Load(object sender, EventArgs e)
        {
            var nameColumn = new DataGridViewColumn
            {
                ReadOnly = true,
                Name = "name",
                HeaderText = "",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 200
            };

            var materialCostsColumn = new DataGridViewColumn
            {
                ReadOnly = true,
                Name = "material costs",
                HeaderText = "Material Costs",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var timeColumn = new DataGridViewColumn
            {
                ReadOnly = true,
                Name = "time",
                HeaderText = "Time",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell(),
                Width = 50
            };

            var selectColumn = new DataGridViewColumn
            {
                CellTemplate = new DataGridViewCheckBoxCell(),
                Name = "selected",
                HeaderText = "",
                Frozen = true,
                Width = 30
            };

            var totalCostsColumn = new DataGridViewColumn
            {
                ReadOnly = true,
                Name = "total costs",
                HeaderText = "Total Costs",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            worksheetDataGridView.BackgroundColor = SystemColors.Control;
            worksheetDataGridView.AllowUserToAddRows = false;
            worksheetDataGridView.RowHeadersVisible = false;
            worksheetDataGridView.CellContentClick += new DataGridViewCellEventHandler(worksheetDataGridView_CellContentClick);
            worksheetDataGridView.CellValueChanged += new DataGridViewCellEventHandler(worksheetDataGridView_CellValueChanged);
        

        worksheetDataGridView.Columns.Add(nameColumn);
            worksheetDataGridView.Columns.Add(materialCostsColumn);
            worksheetDataGridView.Columns.Add(timeColumn);
            worksheetDataGridView.Columns.Add(selectColumn);
            worksheetDataGridView.Columns.Add(totalCostsColumn);

            foreach (var work in Works)
            {
                worksheetDataGridView.Rows.Add(
                    work.Name,
                    work.MaterialCost.ToString() + " Ft",
                    work.GetTimeHours() == 0 ? work.GetTimeMinutes().ToString() + " m" : work.GetTimeHours().ToString() + " h " + work.GetTimeMinutes().ToString() + " m",
                    false,
                    ""
                    );
            }

        }

        private void worksheetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            worksheetDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void worksheetDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            uint materialCosts = 0;
            uint timeCosts = 0;

            foreach (DataGridViewRow row in worksheetDataGridView.Rows)
            {
                if ((bool)row.Cells["selected"].Value)
                {
                    row.Cells["total costs"].Value = Works[row.Index].GetTimeCost() + " Ft";
                    materialCosts += Works[row.Index].MaterialCost;
                    timeCosts += Works[row.Index].GetTimeCost();
                }
                else
                {
                    row.Cells["total costs"].Value = "";
                }
            }

            materialCostsValueLabel.Text = materialCosts.ToString() + " Ft";
            timeCostsValueLabel.Text = timeCosts.ToString() + " Ft";
        }

        private void WorkSheetRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Payment != null)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show(
               "Are you sure you want to quit worksheet registration?",
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            uint materialCosts = 0;
            uint timeCosts = 0;
            uint worksCount = 0;
            uint time = 0;

            foreach (DataGridViewRow row in worksheetDataGridView.Rows)
            {
                if ((bool)row.Cells["selected"].Value)
                {
                    materialCosts += Works[row.Index].MaterialCost;
                    timeCosts += Works[row.Index].GetTimeCost();
                    time += Works[row.Index].Time;
                    worksCount += 1;
                }
            }

            Payment = new Payment(
                worksCount,
                materialCosts,
                timeCosts,
                time
                );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
