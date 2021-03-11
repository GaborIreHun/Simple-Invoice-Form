
namespace Form1
{
    partial class frmInvoice
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
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.TotalOfInvoices = new System.Windows.Forms.Label();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(169, 41);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(281, 20);
            this.txtSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount Percent";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(169, 89);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(281, 20);
            this.txtDiscountPercent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount Amount";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(169, 130);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(281, 20);
            this.txtDiscountAmount.TabIndex = 5;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.txtDiscountAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(169, 170);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(281, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(169, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(627, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Invoices";
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(627, 41);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(146, 20);
            this.txtNumberOfInvoices.TabIndex = 12;
            // 
            // TotalOfInvoices
            // 
            this.TotalOfInvoices.AutoSize = true;
            this.TotalOfInvoices.Location = new System.Drawing.Point(502, 89);
            this.TotalOfInvoices.Name = "TotalOfInvoices";
            this.TotalOfInvoices.Size = new System.Drawing.Size(88, 13);
            this.TotalOfInvoices.TabIndex = 13;
            this.TotalOfInvoices.Text = "Total Of Invoices";
            this.TotalOfInvoices.Click += new System.EventHandler(this.txtTotalOfInvoices_Click);
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(627, 89);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(146, 20);
            this.txtTotalOfInvoices.TabIndex = 14;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(627, 130);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(146, 20);
            this.txtInvoiceAverage.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Average Of Invoices";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(375, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 272);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.TotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoice";
            this.Text = "Invoice Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.Label TotalOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}

