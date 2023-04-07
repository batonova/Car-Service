
namespace OF5KAE
{
    partial class WorkSheetRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.worksheetDataGridView = new System.Windows.Forms.DataGridView();
            this.materialCostsLabel = new System.Windows.Forms.Label();
            this.materialCostsValueLabel = new System.Windows.Forms.Label();
            this.timeCostsLabel = new System.Windows.Forms.Label();
            this.timeCostsValueLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worksheetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // worksheetDataGridView
            // 
            this.worksheetDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.worksheetDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.worksheetDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.worksheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.worksheetDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.worksheetDataGridView.EnableHeadersVisualStyles = false;
            this.worksheetDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.worksheetDataGridView.Location = new System.Drawing.Point(12, 38);
            this.worksheetDataGridView.Name = "worksheetDataGridView";
            this.worksheetDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.worksheetDataGridView.RowHeadersWidth = 82;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            this.worksheetDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.worksheetDataGridView.RowTemplate.Height = 33;
            this.worksheetDataGridView.Size = new System.Drawing.Size(999, 466);
            this.worksheetDataGridView.TabIndex = 0;
            // 
            // materialCostsLabel
            // 
            this.materialCostsLabel.AutoSize = true;
            this.materialCostsLabel.Location = new System.Drawing.Point(19, 524);
            this.materialCostsLabel.Name = "materialCostsLabel";
            this.materialCostsLabel.Size = new System.Drawing.Size(150, 25);
            this.materialCostsLabel.TabIndex = 1;
            this.materialCostsLabel.Text = "Material Costs";
            // 
            // materialCostsValueLabel
            // 
            this.materialCostsValueLabel.AutoSize = true;
            this.materialCostsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCostsValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialCostsValueLabel.Location = new System.Drawing.Point(175, 518);
            this.materialCostsValueLabel.Name = "materialCostsValueLabel";
            this.materialCostsValueLabel.Size = new System.Drawing.Size(36, 37);
            this.materialCostsValueLabel.TabIndex = 2;
            this.materialCostsValueLabel.Text = "0\r\n";
            // 
            // timeCostsLabel
            // 
            this.timeCostsLabel.AutoSize = true;
            this.timeCostsLabel.Location = new System.Drawing.Point(361, 524);
            this.timeCostsLabel.Name = "timeCostsLabel";
            this.timeCostsLabel.Size = new System.Drawing.Size(120, 25);
            this.timeCostsLabel.TabIndex = 3;
            this.timeCostsLabel.Text = "Time Costs";
            // 
            // timeCostsValueLabel
            // 
            this.timeCostsValueLabel.AutoSize = true;
            this.timeCostsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeCostsValueLabel.ForeColor = System.Drawing.Color.Red;
            this.timeCostsValueLabel.Location = new System.Drawing.Point(487, 517);
            this.timeCostsValueLabel.Name = "timeCostsValueLabel";
            this.timeCostsValueLabel.Size = new System.Drawing.Size(36, 37);
            this.timeCostsValueLabel.TabIndex = 4;
            this.timeCostsValueLabel.Text = "0";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(835, 510);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(146, 40);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // WorkSheetRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.timeCostsValueLabel);
            this.Controls.Add(this.timeCostsLabel);
            this.Controls.Add(this.materialCostsValueLabel);
            this.Controls.Add(this.materialCostsLabel);
            this.Controls.Add(this.worksheetDataGridView);
            this.MaximumSize = new System.Drawing.Size(1049, 629);
            this.MinimumSize = new System.Drawing.Size(1049, 629);
            this.Name = "WorkSheetRegistrationForm";
            this.Text = "Worksheet registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSheetRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkSheetRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worksheetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView worksheetDataGridView;
        private System.Windows.Forms.Label materialCostsLabel;
        private System.Windows.Forms.Label materialCostsValueLabel;
        private System.Windows.Forms.Label timeCostsLabel;
        private System.Windows.Forms.Label timeCostsValueLabel;
        private System.Windows.Forms.Button registerButton;
    }
}