namespace Example
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauDeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionStandardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionScientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLeProgrammeCtrlxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatricesToolStripMenuItem,
            this.bureauDeChangeToolStripMenuItem,
            this.quitterLeProgrammeCtrlxToolStripMenuItem});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.programmesToolStripMenuItem.Text = "Programmes";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // calculatricesToolStripMenuItem
            // 
            this.calculatricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionStandardToolStripMenuItem,
            this.versionScientifiqueToolStripMenuItem});
            this.calculatricesToolStripMenuItem.Name = "calculatricesToolStripMenuItem";
            this.calculatricesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.calculatricesToolStripMenuItem.Text = "Calculatrices";
            // 
            // bureauDeChangeToolStripMenuItem
            // 
            this.bureauDeChangeToolStripMenuItem.Name = "bureauDeChangeToolStripMenuItem";
            this.bureauDeChangeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.bureauDeChangeToolStripMenuItem.Text = "Bureau de change";
            // 
            // versionStandardToolStripMenuItem
            // 
            this.versionStandardToolStripMenuItem.Name = "versionStandardToolStripMenuItem";
            this.versionStandardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionStandardToolStripMenuItem.Text = "Version Standard";
            this.versionStandardToolStripMenuItem.Click += new System.EventHandler(this.versionStandardToolStripMenuItem_Click);
            // 
            // versionScientifiqueToolStripMenuItem
            // 
            this.versionScientifiqueToolStripMenuItem.Name = "versionScientifiqueToolStripMenuItem";
            this.versionScientifiqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionScientifiqueToolStripMenuItem.Text = "Version Scientifique";
            // 
            // quitterLeProgrammeCtrlxToolStripMenuItem
            // 
            this.quitterLeProgrammeCtrlxToolStripMenuItem.Name = "quitterLeProgrammeCtrlxToolStripMenuItem";
            this.quitterLeProgrammeCtrlxToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quitterLeProgrammeCtrlxToolStripMenuItem.Text = "Quitter le Programme     Ctrl+x";
            this.quitterLeProgrammeCtrlxToolStripMenuItem.Click += new System.EventHandler(this.quitterLeProgrammeCtrlxToolStripMenuItem_Click);
            // 
            // manuelToolStripMenuItem
            // 
            this.manuelToolStripMenuItem.Name = "manuelToolStripMenuItem";
            this.manuelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manuelToolStripMenuItem.Text = "Manuel";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionStandardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionScientifiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bureauDeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLeProgrammeCtrlxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

