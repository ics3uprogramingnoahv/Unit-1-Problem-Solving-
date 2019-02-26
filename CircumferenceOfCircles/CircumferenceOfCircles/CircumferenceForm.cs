using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceOfCircles
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
            this.lblAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare the local variables and concstants

            double circumference, radius;
            //declare other variables
            radius = double.Parse(txtInput.Text);
            const double PI = 3.14159265358;
            circumference = 2 * PI * radius;
            this.lblAnswer.Text = "The Circumference is  " + Convert.ToString(circumference);
            
            // show answer

            this.lblAnswer.Show();






        }

        private void frmCircumference_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
