namespace project01
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            btnCreateCustomer = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 105);
            label1.Name = "label1";
            label1.Size = new Size(115, 26);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 173);
            label2.Name = "label2";
            label2.Size = new Size(46, 26);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(202, 108);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(314, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(202, 173);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(314, 23);
            txtCustomerEmail.TabIndex = 3;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = Color.Silver;
            btnCreateCustomer.FlatStyle = FlatStyle.Flat;
            btnCreateCustomer.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateCustomer.ForeColor = Color.FromArgb(64, 0, 0);
            btnCreateCustomer.Location = new Point(287, 230);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(167, 34);
            btnCreateCustomer.TabIndex = 4;
            btnCreateCustomer.Text = "Create Customer";
            btnCreateCustomer.UseVisualStyleBackColor = false;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(240, 9);
            label3.Name = "label3";
            label3.Size = new Size(311, 29);
            label3.TabIndex = 5;
            label3.Text = "Customer Registration";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnCreateCustomer);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "Customer Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private Button btnCreateCustomer;
        private Label label3;
    }
}