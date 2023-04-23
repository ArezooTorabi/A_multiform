using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        PaymentForm2 pf2 = new PaymentForm2();
   private void button1_Click(object sender, EventArgs e)
        {
            pf2.Show();
        }
    }
}
