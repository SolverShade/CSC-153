
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
            this.label1 = new System.Windows.Forms.Label();
            this.SecondFallenTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CalculateDistanceButton = new System.Windows.Forms.Button();
            this.DistanceTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter time fallen in seconds";
            // 
            // SecondFallenTextbox
            // 
            this.SecondFallenTextbox.Location = new System.Drawing.Point(156, 13);
            this.SecondFallenTextbox.Name = "SecondFallenTextbox";
            this.SecondFallenTextbox.Size = new System.Drawing.Size(100, 20);
            this.SecondFallenTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distance fallen";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(2, 129);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status:";
            // 
            // CalculateDistanceButton
            // 
            this.CalculateDistanceButton.Location = new System.Drawing.Point(79, 54);
            this.CalculateDistanceButton.Name = "CalculateDistanceButton";
            this.CalculateDistanceButton.Size = new System.Drawing.Size(138, 23);
            this.CalculateDistanceButton.TabIndex = 5;
            this.CalculateDistanceButton.Text = "Calculate Distance";
            this.CalculateDistanceButton.UseVisualStyleBackColor = true;
            this.CalculateDistanceButton.Click += new System.EventHandler(this.CalculateDistanceButton_Click);
            // 
            // DistanceTextbox
            // 
            this.DistanceTextbox.Location = new System.Drawing.Point(79, 106);
            this.DistanceTextbox.Name = "DistanceTextbox";
            this.DistanceTextbox.Size = new System.Drawing.Size(138, 20);
            this.DistanceTextbox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 151);
            this.Controls.Add(this.DistanceTextbox);
            this.Controls.Add(this.CalculateDistanceButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondFallenTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Falling Distance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondFallenTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button CalculateDistanceButton;
        private System.Windows.Forms.TextBox DistanceTextbox;
    }
}

