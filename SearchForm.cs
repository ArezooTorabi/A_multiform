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
    public partial class SearchForm : Form
    {
        public PaymentForm2 pf2;
        public SearchForm()
        {
            InitializeComponent();
        }
        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "Arezoo")
            {
              pf2.textbox2.text = "140112028037";
                this.Hide();
            } 
        }

    }
}
