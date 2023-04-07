
namespace OF5KAE
{
    partial class PaymentForm
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
            this.worksheetsNumberLabel = new System.Windows.Forms.Label();
            this.worksNumberLabel = new System.Windows.Forms.Label();
            this.materialCostLabel = new System.Windows.Forms.Label();
            this.serviceCostLabel = new System.Windows.Forms.Label();
            this.serviceTimeLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.worksheetsNumberValueLabel = new System.Windows.Forms.Label();
            this.worksNumberValueLabel = new System.Windows.Forms.Label();
            this.materialCostValueLabel = new System.Windows.Forms.Label();
            this.serviceCostValueLabel = new System.Windows.Forms.Label();
            this.serviceTimeValueLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // worksheetsNumberLabel
            // 
            this.worksheetsNumberLabel.AutoSize = true;
            this.worksheetsNumberLabel.Location = new System.Drawing.Point(43, 45);
            this.worksheetsNumberLabel.Name = "worksheetsNumberLabel";
            this.worksheetsNumberLabel.Size = new System.Drawing.Size(126, 25);
            this.worksheetsNumberLabel.TabIndex = 0;
            this.worksheetsNumberLabel.Text = "Worksheets";
            // 
            // worksNumberLabel
            // 
            this.worksNumberLabel.AutoSize = true;
            this.worksNumberLabel.Location = new System.Drawing.Point(43, 108);
            this.worksNumberLabel.Name = "worksNumberLabel";
            this.worksNumberLabel.Size = new System.Drawing.Size(73, 25);
            this.worksNumberLabel.TabIndex = 1;
            this.worksNumberLabel.Text = "Works";
            // 
            // materialCostLabel
            // 
            this.materialCostLabel.AutoSize = true;
            this.materialCostLabel.Location = new System.Drawing.Point(43, 169);
            this.materialCostLabel.Name = "materialCostLabel";
            this.materialCostLabel.Size = new System.Drawing.Size(139, 25);
            this.materialCostLabel.TabIndex = 2;
            this.materialCostLabel.Text = "Material Cost";
            // 
            // serviceCostLabel
            // 
            this.serviceCostLabel.AutoSize = true;
            this.serviceCostLabel.Location = new System.Drawing.Point(43, 231);
            this.serviceCostLabel.Name = "serviceCostLabel";
            this.serviceCostLabel.Size = new System.Drawing.Size(130, 25);
            this.serviceCostLabel.TabIndex = 3;
            this.serviceCostLabel.Text = "Service cost";
            // 
            // serviceTimeLabel
            // 
            this.serviceTimeLabel.AutoSize = true;
            this.serviceTimeLabel.Location = new System.Drawing.Point(43, 297);
            this.serviceTimeLabel.Name = "serviceTimeLabel";
            this.serviceTimeLabel.Size = new System.Drawing.Size(130, 25);
            this.serviceTimeLabel.TabIndex = 4;
            this.serviceTimeLabel.Text = "Service time";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(43, 366);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 25);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total";
            // 
            // worksheetsNumberValueLabel
            // 
            this.worksheetsNumberValueLabel.AutoSize = true;
            this.worksheetsNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worksheetsNumberValueLabel.ForeColor = System.Drawing.Color.Sienna;
            this.worksheetsNumberValueLabel.Location = new System.Drawing.Point(190, 36);
            this.worksheetsNumberValueLabel.Name = "worksheetsNumberValueLabel";
            this.worksheetsNumberValueLabel.Size = new System.Drawing.Size(36, 37);
            this.worksheetsNumberValueLabel.TabIndex = 0;
            this.worksheetsNumberValueLabel.Text = "0";
            // 
            // worksNumberValueLabel
            // 
            this.worksNumberValueLabel.AutoSize = true;
            this.worksNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worksNumberValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.worksNumberValueLabel.Location = new System.Drawing.Point(190, 99);
            this.worksNumberValueLabel.Name = "worksNumberValueLabel";
            this.worksNumberValueLabel.Size = new System.Drawing.Size(36, 37);
            this.worksNumberValueLabel.TabIndex = 1;
            this.worksNumberValueLabel.Text = "0";
            // 
            // materialCostValueLabel
            // 
            this.materialCostValueLabel.AutoSize = true;
            this.materialCostValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCostValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.materialCostValueLabel.Location = new System.Drawing.Point(190, 157);
            this.materialCostValueLabel.Name = "materialCostValueLabel";
            this.materialCostValueLabel.Size = new System.Drawing.Size(36, 37);
            this.materialCostValueLabel.TabIndex = 2;
            this.materialCostValueLabel.Text = "0";
            this.materialCostValueLabel.Click += new System.EventHandler(this.materialCostValueLabel_Click);
            // 
            // serviceCostValueLabel
            // 
            this.serviceCostValueLabel.AutoSize = true;
            this.serviceCostValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceCostValueLabel.ForeColor = System.Drawing.Color.Lime;
            this.serviceCostValueLabel.Location = new System.Drawing.Point(190, 222);
            this.serviceCostValueLabel.Name = "serviceCostValueLabel";
            this.serviceCostValueLabel.Size = new System.Drawing.Size(36, 37);
            this.serviceCostValueLabel.TabIndex = 3;
            this.serviceCostValueLabel.Text = "0";
            // 
            // serviceTimeValueLabel
            // 
            this.serviceTimeValueLabel.AutoSize = true;
            this.serviceTimeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceTimeValueLabel.ForeColor = System.Drawing.Color.Red;
            this.serviceTimeValueLabel.Location = new System.Drawing.Point(190, 288);
            this.serviceTimeValueLabel.Name = "serviceTimeValueLabel";
            this.serviceTimeValueLabel.Size = new System.Drawing.Size(36, 37);
            this.serviceTimeValueLabel.TabIndex = 4;
            this.serviceTimeValueLabel.Text = "0";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalValueLabel.ForeColor = System.Drawing.Color.Aqua;
            this.totalValueLabel.Location = new System.Drawing.Point(190, 354);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(36, 37);
            this.totalValueLabel.TabIndex = 5;
            this.totalValueLabel.Text = "0";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 464);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.serviceTimeValueLabel);
            this.Controls.Add(this.serviceCostValueLabel);
            this.Controls.Add(this.serviceTimeLabel);
            this.Controls.Add(this.materialCostValueLabel);
            this.Controls.Add(this.serviceCostLabel);
            this.Controls.Add(this.worksNumberValueLabel);
            this.Controls.Add(this.materialCostLabel);
            this.Controls.Add(this.worksheetsNumberValueLabel);
            this.Controls.Add(this.worksNumberLabel);
            this.Controls.Add(this.worksheetsNumberLabel);
            this.MaximumSize = new System.Drawing.Size(425, 535);
            this.MinimumSize = new System.Drawing.Size(425, 535);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label worksheetsNumberLabel;
        private System.Windows.Forms.Label worksNumberLabel;
        private System.Windows.Forms.Label materialCostLabel;
        private System.Windows.Forms.Label serviceCostLabel;
        private System.Windows.Forms.Label serviceTimeLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label worksheetsNumberValueLabel;
        private System.Windows.Forms.Label worksNumberValueLabel;
        private System.Windows.Forms.Label materialCostValueLabel;
        private System.Windows.Forms.Label serviceCostValueLabel;
        private System.Windows.Forms.Label serviceTimeValueLabel;
        private System.Windows.Forms.Label totalValueLabel;
    }
}