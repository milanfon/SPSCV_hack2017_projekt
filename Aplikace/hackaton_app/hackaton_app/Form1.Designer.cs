namespace hackaton_app
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stavNádržeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.počasíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavlažováníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.očerpáníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadoba_plna = new System.Windows.Forms.PictureBox();
            this.nadoba_trictvrte = new System.Windows.Forms.PictureBox();
            this.nadoba_polovina = new System.Windows.Forms.PictureBox();
            this.nadoba_ctvrt = new System.Windows.Forms.PictureBox();
            this.obsah = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_plna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_trictvrte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_polovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_ctvrt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stavNádržeToolStripMenuItem,
            this.počasíToolStripMenuItem,
            this.zavlažováníToolStripMenuItem,
            this.očerpáníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stavNádržeToolStripMenuItem
            // 
            this.stavNádržeToolStripMenuItem.Name = "stavNádržeToolStripMenuItem";
            this.stavNádržeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.stavNádržeToolStripMenuItem.Text = "Stav nádrže";
            this.stavNádržeToolStripMenuItem.Click += new System.EventHandler(this.stavNádržeToolStripMenuItem_Click);
            // 
            // počasíToolStripMenuItem
            // 
            this.počasíToolStripMenuItem.Name = "počasíToolStripMenuItem";
            this.počasíToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.počasíToolStripMenuItem.Text = "Počasí";
            // 
            // zavlažováníToolStripMenuItem
            // 
            this.zavlažováníToolStripMenuItem.Name = "zavlažováníToolStripMenuItem";
            this.zavlažováníToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.zavlažováníToolStripMenuItem.Text = "Zavlažování";
            // 
            // očerpáníToolStripMenuItem
            // 
            this.očerpáníToolStripMenuItem.Name = "očerpáníToolStripMenuItem";
            this.očerpáníToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.očerpáníToolStripMenuItem.Text = "Očerpání";
            // 
            // nadoba_plna
            // 
            this.nadoba_plna.BackColor = System.Drawing.Color.Transparent;
            this.nadoba_plna.Image = ((System.Drawing.Image)(resources.GetObject("nadoba_plna.Image")));
            this.nadoba_plna.Location = new System.Drawing.Point(29, 55);
            this.nadoba_plna.Name = "nadoba_plna";
            this.nadoba_plna.Size = new System.Drawing.Size(97, 192);
            this.nadoba_plna.TabIndex = 1;
            this.nadoba_plna.TabStop = false;
            // 
            // nadoba_trictvrte
            // 
            this.nadoba_trictvrte.BackColor = System.Drawing.Color.Transparent;
            this.nadoba_trictvrte.Image = ((System.Drawing.Image)(resources.GetObject("nadoba_trictvrte.Image")));
            this.nadoba_trictvrte.Location = new System.Drawing.Point(29, 55);
            this.nadoba_trictvrte.Name = "nadoba_trictvrte";
            this.nadoba_trictvrte.Size = new System.Drawing.Size(97, 192);
            this.nadoba_trictvrte.TabIndex = 2;
            this.nadoba_trictvrte.TabStop = false;
            // 
            // nadoba_polovina
            // 
            this.nadoba_polovina.BackColor = System.Drawing.Color.Transparent;
            this.nadoba_polovina.Image = ((System.Drawing.Image)(resources.GetObject("nadoba_polovina.Image")));
            this.nadoba_polovina.Location = new System.Drawing.Point(29, 55);
            this.nadoba_polovina.Name = "nadoba_polovina";
            this.nadoba_polovina.Size = new System.Drawing.Size(97, 192);
            this.nadoba_polovina.TabIndex = 3;
            this.nadoba_polovina.TabStop = false;
            // 
            // nadoba_ctvrt
            // 
            this.nadoba_ctvrt.BackColor = System.Drawing.Color.Transparent;
            this.nadoba_ctvrt.Image = ((System.Drawing.Image)(resources.GetObject("nadoba_ctvrt.Image")));
            this.nadoba_ctvrt.Location = new System.Drawing.Point(29, 55);
            this.nadoba_ctvrt.Name = "nadoba_ctvrt";
            this.nadoba_ctvrt.Size = new System.Drawing.Size(97, 192);
            this.nadoba_ctvrt.TabIndex = 4;
            this.nadoba_ctvrt.TabStop = false;
            // 
            // obsah
            // 
            this.obsah.AutoSize = true;
            this.obsah.BackColor = System.Drawing.Color.White;
            this.obsah.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obsah.Location = new System.Drawing.Point(164, 114);
            this.obsah.Name = "obsah";
            this.obsah.Size = new System.Drawing.Size(77, 31);
            this.obsah.TabIndex = 5;
            this.obsah.Text = "-------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(296, 236);
            this.Controls.Add(this.obsah);
            this.Controls.Add(this.nadoba_ctvrt);
            this.Controls.Add(this.nadoba_polovina);
            this.Controls.Add(this.nadoba_trictvrte);
            this.Controls.Add(this.nadoba_plna);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rainator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_plna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_trictvrte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_polovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_ctvrt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stavNádržeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem počasíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavlažováníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem očerpáníToolStripMenuItem;
        private System.Windows.Forms.PictureBox nadoba_plna;
        private System.Windows.Forms.PictureBox nadoba_trictvrte;
        private System.Windows.Forms.PictureBox nadoba_polovina;
        private System.Windows.Forms.PictureBox nadoba_ctvrt;
        private System.Windows.Forms.Label obsah;
    }
}

