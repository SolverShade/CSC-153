
namespace WinUI
{
    partial class Form1
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
            this.EnterWholeSalePriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterMarkUpPercentageTextBox = new System.Windows.Forms.TextBox();
            this.NetPriceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NetPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterWholeSalePriceTextBox
            // 
            this.EnterWholeSalePriceTextBox.Location = new System.Drawing.Point(147, 21);
            this.EnterWholeSalePriceTextBox.Name = "EnterWholeSalePriceTextBox";
            this.EnterWholeSalePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterWholeSalePriceTextBox.TabIndex = 0;
            this.EnterWholeSalePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter WholeSale Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Markup Percentage";
            // 
            // EnterMarkUpPercentageTextBox
            // 
            this.EnterMarkUpPercentageTextBox.Location = new System.Drawing.Point(147, 55);
            this.EnterMarkUpPercentageTextBox.Name = "EnterMarkUpPercentageTextBox";
            this.EnterMarkUpPercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnterMarkUpPercentageTextBox.TabIndex = 3;
            this.EnterMarkUpPercentageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NetPriceButton
            // 
            this.NetPriceButton.Location = new System.Drawing.Point(51, 98);
            this.NetPriceButton.Name = "NetPriceButton";
            this.NetPriceButton.Size = new System.Drawing.Size(219, 23);
            this.NetPriceButton.TabIndex = 4;
            this.NetPriceButton.Text = "Get Net Price";
            this.NetPriceButton.UseVisualStyleBackColor = true;
            this.NetPriceButton.Click += new System.EventHandler(this.NetPriceButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Net Price";
            // 
            // NetPriceTextBox
            // 
            this.NetPriceTextBox.Location = new System.Drawing.Point(108, 143);
            this.NetPriceTextBox.Name = "NetPriceTextBox";
            this.NetPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.NetPriceTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "%";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(1, 177);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 199);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NetPriceButton);
            this.Controls.Add(this.EnterMarkUpPercentageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterWholeSalePriceTextBox);
            this.Name = "Form1";
            this.Text = "Retail Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterWholeSalePriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterMarkUpPercentageTextBox;
        private System.Windows.Forms.Button NetPriceButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NetPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label5;
    }
}

