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
    public partial class PaymentForm2 : Form
    {
        public PaymentForm pf;
        SearchForm sf = new SearchForm();
        public PaymentForm2()
        {
            InitializeComponent();
            sf.pf2 = this;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sf.Show();
        }

        private void PaymentForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pf.listbox1.item.add(textBox1);
        }


    }
}
