using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project01
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        // ========================
        // 📦 ADD PRODUCT TO ORDER
        // ========================
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // 1. التأكد من أن الحقول ليست فارغة
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter all product data");
                return;
            }

            double price;
            int quantity;

            // 2. التحقق من صحة الأرقام
            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity");
                return;
            }

            // 3. إنشاء كائن المنتج (OOP Concept)
            Product product = new Product
            {
                Name = txtProductName.Text,
                Price = price,
                Quantity = quantity
            };

            // 4. الإضافة للمخزن المشترك (GlobalData)
            GlobalData.CurrentOrder.Products.Add(product);

            // 5. العرض في القائمة
            lstProducts.Items.Add($"{product.Name} | {product.Price} x {product.Quantity} = {product.Price * product.Quantity}");

            // مسح الخانات للإضافة الجديدة
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        // ========================
        // ➡️ الانتقال للفورم الثالث
        // ========================
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (GlobalData.CurrentOrder.Products.Count == 0)
            {
                MessageBox.Show("Please add at least one product");
                return;
            }

            OrderForm oForm = new OrderForm();
            oForm.Show();
            this.Hide();
        }

        private void btnNextToOrder_Click(object sender, EventArgs e)
        {
            if (GlobalData.CurrentOrder.Products.Count == 0)
            {
                MessageBox.Show("Please add at least one product before proceeding.");
                return;
            }

            // فتح الفورم الثالث (OrderForm)
            OrderForm oForm = new OrderForm();
            oForm.Show();
            this.Hide();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {

        }
    }
}