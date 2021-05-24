using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBill_TextChanged(object sender, EventArgs e)          //called when txtBill contents are changed 
        {
            Calculate();
        }


        private void txtTip_TextChanged(object sender, EventArgs e)         //called when txtTip contents are changed
        {
            Calculate();
        }

        private void txtPersons_TextChanged_1(object sender, EventArgs e)    //called when txtPersons contents are changed
        {
            Calculate();
        }

        void Calculate()           // function to validate the input boxes and display the output
        {
            if (String.IsNullOrEmpty(txtBill.Text) && String.IsNullOrEmpty(txtTip.Text) && String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtBill.Text) && String.IsNullOrEmpty(txtTip.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtTip.Text) && String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtBill.Text) && String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtBill.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtTip.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (Convert.ToDouble(txtPersons.Text) < 1)
            {
                txtResult1.Text = txtResult2.Text = null;
            }
            else
            {
        
                txtResult1.Text = "$" + Math.Round(((Convert.ToDouble(txtBill.Text) * (Convert.ToDouble(txtTip.Text) / 100)) / Convert.ToDouble(txtPersons.Text)),2).ToString("F");
                txtResult2.Text = "$" + Math.Round(((Convert.ToDouble(txtBill.Text) + Convert.ToDouble(txtBill.Text) * (Convert.ToDouble(txtTip.Text)/100)) / Convert.ToDouble(txtPersons.Text)),2).ToString("F");
            }

        }

        private void button2_Click(object sender, EventArgs e)     // when (-) button for txtTip is clicked
        {
            if(Convert.ToDouble(txtTip.Text) >= 1)
            {
                txtTip.Text = (Convert.ToDouble(txtTip.Text) - 1).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)     //when (+) button for txtTip is clicked
        {
            txtTip.Text = (Convert.ToDouble(txtTip.Text) + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)     //when (-) button for txtPersons is clicked
        {
            if(Convert.ToDouble(txtPersons.Text) >= 1)
            {
                txtPersons.Text = (Convert.ToDouble(txtPersons.Text) - 1).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)     //when (+) button for txtPersons is clicked
        {
            txtPersons.Text = (Convert.ToDouble(txtPersons.Text) + 1).ToString();
        }

       
    }
}
