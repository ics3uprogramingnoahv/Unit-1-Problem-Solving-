namespace MovingCatNoahV
{
    partial class frmMovinCat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.filleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picCat = new System.Windows.Forms.PictureBox();
            this.dieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dieToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filleToolStripMenuItem,
            this.catToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(661, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            this.mnuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuStrip_ItemClicked);
            // 
            // filleToolStripMenuItem
            // 
            this.filleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dieToolStripMenuItem,
            this.dieToolStripMenuItem1,
            this.dieToolStripMenuItem2});
            this.filleToolStripMenuItem.Name = "filleToolStripMenuItem";
            this.filleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.filleToolStripMenuItem.Text = "Fille";
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.catToolStripMenuItem.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(152, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click_1);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(152, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatNoahV.Properties.Resources.cat1;
            this.picCat.Location = new System.Drawing.Point(0, 27);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(661, 455);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 2;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.picCat_Click);
            // 
            // dieToolStripMenuItem
            // 
            this.dieToolStripMenuItem.Name = "dieToolStripMenuItem";
            this.dieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dieToolStripMenuItem.Text = "leave";
            this.dieToolStripMenuItem.Click += new System.EventHandler(this.dieToolStripMenuItem_Click);
            // 
            // dieToolStripMenuItem1
            // 
            this.dieToolStripMenuItem1.Name = "dieToolStripMenuItem1";
            this.dieToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dieToolStripMenuItem1.Text = "Leave";
            this.dieToolStripMenuItem1.Click += new System.EventHandler(this.dieToolStripMenuItem1_Click);
            // 
            // dieToolStripMenuItem2
            // 
            this.dieToolStripMenuItem2.Name = "dieToolStripMenuItem2";
            this.dieToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.dieToolStripMenuItem2.Text = "Leave";
            this.dieToolStripMenuItem2.Click += new System.EventHandler(this.dieToolStripMenuItem2_Click);
            // 
            // frmMovinCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 478);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmMovinCat";
            this.Text = "Moving Cat y Noah Voroney";
            this.Load += new System.EventHandler(this.MovinCatForm_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.ToolStripMenuItem filleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.ToolStripMenuItem dieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dieToolStripMenuItem2;
    }
}

