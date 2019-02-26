using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPrice
{
    public partial class frmPizzaPrice : Form
    {
        public frmPizzaPrice()
        {
            InitializeComponent();
        }

        private void PizzaPriceForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            double diameter, costBeforeTax, costAfterTax;
            diameter = (double)nudDiameter.Value;

            costBeforeTax = ((diameter * 0.50) + 0.75 + 0.99);
            costAfterTax = costBeforeTax * 1.13;
            lblSubtotal.Text = "Subtotal = " + Convert.ToString(costBeforeTax) + "$" ;
            lblTotal.Text = "Total = " + Convert.ToString(costAfterTax) + "$";
        }
    }
}
