namespace SchoolMascotNoahV
{
    partial class frmSchoolMascot
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
            this.mnustrip = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immaculataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stJoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.northCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbinformation = new System.Windows.Forms.GroupBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.mnustrip.SuspendLayout();
            this.grbinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnustrip
            // 
            this.mnustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolsToolStripMenuItem});
            this.mnustrip.Location = new System.Drawing.Point(0, 0);
            this.mnustrip.Name = "mnustrip";
            this.mnustrip.Size = new System.Drawing.Size(437, 24);
            this.mnustrip.TabIndex = 0;
            this.mnustrip.Text = "schools";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // schoolsToolStripMenuItem
            // 
            this.schoolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.immaculataToolStripMenuItem,
            this.stJoesToolStripMenuItem,
            this.stMarksToolStripMenuItem,
            this.northCarToolStripMenuItem});
            this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
            this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.schoolsToolStripMenuItem.Text = "Schools";
            // 
            // immaculataToolStripMenuItem
            // 
            this.immaculataToolStripMenuItem.Name = "immaculataToolStripMenuItem";
            this.immaculataToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.immaculataToolStripMenuItem.Text = "Immaculata";
            this.immaculataToolStripMenuItem.Click += new System.EventHandler(this.immaculataToolStripMenuItem_Click);
            // 
            // stJoesToolStripMenuItem
            // 
            this.stJoesToolStripMenuItem.Name = "stJoesToolStripMenuItem";
            this.stJoesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.stJoesToolStripMenuItem.Text = "St Joes";
            this.stJoesToolStripMenuItem.Click += new System.EventHandler(this.stJoesToolStripMenuItem_Click);
            // 
            // stMarksToolStripMenuItem
            // 
            this.stMarksToolStripMenuItem.Name = "stMarksToolStripMenuItem";
            this.stMarksToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.stMarksToolStripMenuItem.Text = "St Marks";
            this.stMarksToolStripMenuItem.Click += new System.EventHandler(this.stMarksToolStripMenuItem_Click);
            // 
            // northCarToolStripMenuItem
            // 
            this.northCarToolStripMenuItem.Name = "northCarToolStripMenuItem";
            this.northCarToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.northCarToolStripMenuItem.Text = " North Carolina School of the Arts";
            this.northCarToolStripMenuItem.Click += new System.EventHandler(this.northCarToolStripMenuItem_Click);
            // 
            // grbinformation
            // 
            this.grbinformation.Controls.Add(this.lblMascot);
            this.grbinformation.Controls.Add(this.lblSchool);
            this.grbinformation.Location = new System.Drawing.Point(12, 52);
            this.grbinformation.Name = "grbinformation";
            this.grbinformation.Size = new System.Drawing.Size(378, 144);
            this.grbinformation.TabIndex = 2;
            this.grbinformation.TabStop = false;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(53, 28);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(139, 42);
            this.lblSchool.TabIndex = 0;
            this.lblSchool.Text = "School";
            this.lblSchool.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(55, 85);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(82, 25);
            this.lblMascot.TabIndex = 1;
            this.lblMascot.Text = "Mascot";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 289);
            this.Controls.Add(this.grbinformation);
            this.Controls.Add(this.mnustrip);
            this.MainMenuStrip = this.mnustrip;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot By Noah voroney";
            this.mnustrip.ResumeLayout(false);
            this.mnustrip.PerformLayout();
            this.grbinformation.ResumeLayout(false);
            this.grbinformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnustrip;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immaculataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stJoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem northCarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbinformation;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblSchool;
    }
}

