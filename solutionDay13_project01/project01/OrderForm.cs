using System;
using System.Windows.Forms;

namespace project01
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            double total = GlobalData.CurrentOrder.GetTotal();
            lblTotal.Text = $"Total: {total}";
            MessageBox.Show($"Order Created! Total: {total}");
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            double total = GlobalData.CurrentOrder.GetTotal();
            if (total <= 0) return;

            IPayable paymentMethod;
            string selectedPayment = cmbPayment?.SelectedItem?.ToString();

            if (selectedPayment == "PayPal")
                paymentMethod = new PayPalPayment();
            else
                paymentMethod = new CashPayment();

            paymentMethod.Pay(total);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbStatus?.SelectedItem != null)
            {
                string newStatus = cmbStatus.SelectedItem.ToString();
                lblStatus.Text = $"Status: {newStatus}";
            }
        }
    }
} 