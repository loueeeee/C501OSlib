using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtArrival.KeyPress += new KeyPressEventHandler(txtArrival_KeyPress);
            this.txtBurst.KeyPress += new KeyPressEventHandler(txtBurst_KeyPress);

            
        }
        int ctr = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            

            if (txtArrival.Text == "" || txtBurst.Text == "")
            {
                MessageBox.Show("Please enter a value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctr++;
                if (ctr == 10) 
                {
                btnEnter.Enabled = false;
                txtArrival.Enabled = false;
                txtBurst.Enabled = false;
                }
                string firstColum = txtArrival.Text;
                string secondColum = txtBurst.Text;
                string zeroColum = "P" + ctr;
                string[] row = { zeroColum, firstColum, secondColum };
                dataInitial.Rows.Add(row);

                txtArrival.Text = "";
                txtBurst.Text = "";
            }
        }
        
        int time = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            time++;
            string timee = time.ToString();
            lblTime.Text = timee;
        }

        private void txtArrival_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtBurst_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
