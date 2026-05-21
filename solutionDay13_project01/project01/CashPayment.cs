using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace project01
{
    public class CashPayment : IPayable
    {
        public void Pay(double amount)
        {
            MessageBox.Show("Paid with Cash: " + amount);
        }
    }
}