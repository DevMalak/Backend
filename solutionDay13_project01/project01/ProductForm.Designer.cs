namespace project01
{
    partial class ProductForm
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
            label3 = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            btnAddProduct = new Button();
            lstProducts = new ListBox();
            btnNextToOrder = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 85);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 6;
            label3.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(131, 88);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(309, 23);
            txtProductName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 161);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(131, 161);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(309, 23);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 224);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 10;
            label5.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(130, 224);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(310, 23);
            txtQuantity.TabIndex = 11;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.ControlDarkDark;
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.FromArgb(64, 0, 0);
            btnAddProduct.Location = new Point(203, 284);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(137, 39);
            btnAddProduct.TabIndex = 12;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(530, 88);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(222, 79);
            lstProducts.TabIndex = 13;
            // 
            // btnNextToOrder
            // 
            btnNextToOrder.BackColor = SystemColors.ControlDarkDark;
            btnNextToOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextToOrder.ForeColor = Color.FromArgb(64, 0, 0);
            btnNextToOrder.Location = new Point(592, 284);
            btnNextToOrder.Name = "btnNextToOrder";
            btnNextToOrder.Size = new Size(99, 39);
            btnNextToOrder.TabIndex = 15;
            btnNextToOrder.Text = "Next";
            btnNextToOrder.UseVisualStyleBackColor = false;
            btnNextToOrder.Click += btnNextToOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 37);
            label1.TabIndex = 16;
            label1.Text = "Product Information";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNextToOrder);
            Controls.Add(lstProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtProductName;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtQuantity;
        private Button btnAddProduct;
        private ListBox lstProducts;
        private Button btnNextToOrder;
        private Label label1;
    }
}