namespace project01
{
    partial class OrderForm
    {
        
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
            btnCreateOrder = new Button();
            lblTotal = new Label();
            cmbPayment = new ComboBox();
            btnPay = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            btnUpdateStatus = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(17, 84);
            btnCreateOrder.Margin = new Padding(4, 4, 4, 4);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(193, 46);
            btnCreateOrder.TabIndex = 15;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(271, 98);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 19);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total: 0";
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Items.AddRange(new object[] { "Cash", "Credit Card", "PayPal" });
            cmbPayment.Location = new Point(17, 196);
            cmbPayment.Margin = new Padding(4, 4, 4, 4);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(315, 27);
            cmbPayment.TabIndex = 17;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(17, 265);
            btnPay.Margin = new Padding(4, 4, 4, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(193, 49);
            btnPay.TabIndex = 18;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPayNow_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Processing", "Shipped", "Delivered" });
            cmbStatus.Location = new Point(526, 196);
            cmbStatus.Margin = new Padding(4, 4, 4, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(315, 27);
            cmbStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(627, 247);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 19);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status: Pending";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(600, 271);
            btnUpdateStatus.Margin = new Padding(4, 4, 4, 4);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(193, 43);
            btnUpdateStatus.TabIndex = 21;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(361, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 22;
            label1.Text = "Order Details";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1143, 570);
            Controls.Add(label1);
            Controls.Add(btnUpdateStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnPay);
            Controls.Add(cmbPayment);
            Controls.Add(lblTotal);
            Controls.Add(btnCreateOrder);
            Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateOrder;
        private Label lblTotal;
        private ComboBox cmbPayment;
        private Button btnPay;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Button btnUpdateStatus;
        private Label label1;
    }
}