
namespace Total_Sales
{
    partial class SalesFourm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesList = new System.Windows.Forms.ListBox();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalesList
            // 
            this.SalesList.FormattingEnabled = true;
            this.SalesList.ItemHeight = 15;
            this.SalesList.Location = new System.Drawing.Point(237, 42);
            this.SalesList.Name = "SalesList";
            this.SalesList.Size = new System.Drawing.Size(332, 244);
            this.SalesList.TabIndex = 0;
            this.SalesList.SelectedIndexChanged += new System.EventHandler(this.SalesList_SelectedIndexChanged);
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(384, 9);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(33, 15);
            this.SalesLabel.TabIndex = 1;
            this.SalesLabel.Text = "Sales";
            this.SalesLabel.Click += new System.EventHandler(this.SalesLabel_Click);
            // 
            // SalesFourm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.SalesList);
            this.Name = "SalesFourm";
            this.Text = "TotalSales";
            this.Load += new System.EventHandler(this.SalesFourm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SalesList;
        private System.Windows.Forms.Label SalesLabel;
    }
}

