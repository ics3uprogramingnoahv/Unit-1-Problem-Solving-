using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanginAreaPerNoahV
{
    public partial class frmChangingAreaPer : Form
    {
        public frmChangingAreaPer()
        {
            InitializeComponent();
        }

        private void ChangingAreaPerForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double length, width, area, perimiter;

            // convert to a string from  each text box to a double
            length = double.Parse(txtBoxLength.Text);
            width = double.Parse(txtBoxWidth.Text);

            //Calculate the Area and Perimiter\
            area = length * width;
            perimiter = 2 * (length + width);

            //insert the answers into the boxes
            this.lblAreaAnswer.Text = Convert.ToString(area) + " Squared meters";
            this.lblPerimiterAnswer.Text = Convert.ToString(perimiter) + " meters";

                // display the answer boxes
        }

        private void txtBoxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
