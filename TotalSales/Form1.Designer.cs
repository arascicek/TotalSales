namespace TotalSales
{
    partial class Form1
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
            saleListBox = new ListBox();
            salesListBox = new Label();
            label1 = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // saleListBox
            // 
            saleListBox.FormattingEnabled = true;
            saleListBox.Location = new Point(38, 44);
            saleListBox.Name = "saleListBox";
            saleListBox.Size = new Size(270, 124);
            saleListBox.TabIndex = 0;
            // 
            // salesListBox
            // 
            salesListBox.AutoSize = true;
            salesListBox.Location = new Point(143, 21);
            salesListBox.Name = "salesListBox";
            salesListBox.Size = new Size(43, 20);
            salesListBox.TabIndex = 1;
            salesListBox.Text = "Sales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 202);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(38, 235);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(270, 34);
            lblTotal.TabIndex = 3;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 300);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(salesListBox);
            Controls.Add(saleListBox);
            Name = "Form1";
            Text = "Sale Problem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox saleListBox;
        private Label salesListBox;
        private Label label1;
        private Label lblTotal;
    }
}
