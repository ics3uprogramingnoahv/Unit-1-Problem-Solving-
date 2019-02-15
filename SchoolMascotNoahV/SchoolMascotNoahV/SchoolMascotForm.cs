/*
 * Created by: Noah Voroney
 * Created on: feb 12 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Name of Program
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotNoahV
{
    public partial class frmSchoolMascot : System.Windows.Forms.Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void northCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchool.Text = " North Carolina School of the Arts";
            lblMascot.Text = "The Fighting Pickle";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void immaculataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata HighSchool";
            lblMascot.Text = "The saints";
        }

        private void stJoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "St Joesephs";
            lblMascot.Text = "A Hawk";
        }

        private void stMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "St Marks";
            lblMascot.Text = "The lions";
        }
    }
}
