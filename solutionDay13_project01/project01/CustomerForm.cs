using System;
using System.Windows.Forms;

namespace project01
{
    public partial class CustomerForm : Form 
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

       
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerEmail.Text))
            {
                MessageBox.Show("Please enter customer name and email");
                return;
            }

            GlobalData.CurrentCustomer = new Customer
            {
                Name = txtCustomerName.Text,
                Email = txtCustomerEmail.Text
            };

            MessageBox.Show($"Customer Created Successfully: {GlobalData.CurrentCustomer.Name}");

            ProductForm pForm = new ProductForm();
            pForm.Show();
            this.Hide(); 
        }
    }
}