/*
 * Created by: Noah Voroney
 * Created on: feb 14 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 -  Moving Cat
 * This program display 2 different cats and you can nanavigate between the two by a menu strip 
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

namespace MovingCatNoahV
{
    public partial class frmMovinCat : Form
    {
        public frmMovinCat()
        {
            InitializeComponent();
        }

        private void MovinCatForm_Load(object sender, EventArgs e)
        {

        }

        private void picCat_Click(object sender, EventArgs e)
        {

        }
        // switch to cat 1
        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mnuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // switch to cat 2
        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
        // switch to cat 1
        private void mniCat1_Click_1(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }
        // close app
        private void dieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // close app
        private void dieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // close app
        private void dieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
