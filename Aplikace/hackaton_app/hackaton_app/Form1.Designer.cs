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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stavNádržeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.počasíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavlažováníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.očerpáníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadoba_plna = new System.Windows.Forms.PictureBox();
            this.nadoba_trictvrte = new System.Windows.Forms.PictureBox();
            this.nadoba_polovina = new System.Windows.Forms.PictureBox();
            this.nadoba_ctvrt = new System.Windows.Forms.PictureBox();
            this.obsah = new System.Windows.Forms.Label();
            this.vlhost_napis = new System.Windows.Forms.Label();
            this.vlhkost_cislo = new System.Windows.Forms.Label();
            this.teplota_napis = new System.Windows.Forms.Label();
            this.teplota_cislo = new System.Windows.Forms.Label();
            this.nadoba_prazdna = new System.Windows.Forms.PictureBox();
            this.slunce = new System.Windows.Forms.PictureBox();
            this.dest = new System.Windows.Forms.PictureBox();
            this.snih = new System.Windows.Forms.PictureBox();
            this.zavlazovani_lehke = new System.Windows.Forms.RadioButton();
            this.zavlazovani_stredni = new System.Windows.Forms.RadioButton();
            this.zavlazovani_silne = new System.Windows.Forms.RadioButton();
            this.zavlazeni = new System.Windows.Forms.GroupBox();
            this.button_odcerpani = new System.Windows.Forms.Button();
            this.pojistka = new System.Windows.Forms.GroupBox();
            this.check_jistota = new System.Windows.Forms.CheckBox();
            this.button_pojistka = new System.Windows.Forms.Button();
            this.button_manualnizavlazeni = new System.Windows.Forms.Button();
            this.button_zavlazeni = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_vypnuti = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_plna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_trictvrte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_polovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_ctvrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_prazdna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slunce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snih)).BeginInit();
            this.zavlazeni.SuspendLayout();
            this.pojistka.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stavNádržeToolStripMenuItem,
            this.počasíToolStripMenuItem,
            this.zavlažováníToolStripMenuItem,
            this.očerpáníToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stavNádržeToolStripMenuItem
            // 
            this.stavNádržeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stavNádržeToolStripMenuItem.Name = "stavNádržeToolStripMenuItem";
            this.stavNádržeToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.stavNádržeToolStripMenuItem.Text = "Stav nádrže";
            this.stavNádržeToolStripMenuItem.Click += new System.EventHandler(this.stavNádržeToolStripMenuItem_Click);
            // 
            // počasíToolStripMenuItem
            // 
            this.počasíToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.počasíToolStripMenuItem.Name = "počasíToolStripMenuItem";
            this.počasíToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.počasíToolStripMenuItem.Text = "Počasí";
            this.počasíToolStripMenuItem.Click += new System.EventHandler(this.počasíToolStripMenuItem_Click);
            // 
            // zavlažováníToolStripMenuItem
            // 
            this.zavlažováníToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.zavlažováníToolStripMenuItem.Name = "zavlažováníToolStripMenuItem";
            this.zavlažováníToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.zavlažováníToolStripMenuItem.Text = "Zavlažování";
            this.zavlažováníToolStripMenuItem.Click += new System.EventHandler(this.zavlažováníToolStripMenuItem_Click);
            // 
            // očerpáníToolStripMenuItem
            // 
            this.očerpáníToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.očerpáníToolStripMenuItem.Name = "očerpáníToolStripMenuItem";
            this.očerpáníToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.očerpáníToolStripMenuItem.Text = "Odčerpání";
            this.očerpáníToolStripMenuItem.Click += new System.EventHandler(this.očerpáníToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
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
            this.obsah.BackColor = System.Drawing.Color.Transparent;
            this.obsah.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obsah.ForeColor = System.Drawing.Color.White;
            this.obsah.Location = new System.Drawing.Point(150, 100);
            this.obsah.Name = "obsah";
            this.obsah.Size = new System.Drawing.Size(179, 73);
            this.obsah.TabIndex = 5;
            this.obsah.Text = "-------";
            // 
            // vlhost_napis
            // 
            this.vlhost_napis.AutoSize = true;
            this.vlhost_napis.BackColor = System.Drawing.Color.DimGray;
            this.vlhost_napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vlhost_napis.ForeColor = System.Drawing.Color.White;
            this.vlhost_napis.Location = new System.Drawing.Point(282, 143);
            this.vlhost_napis.Name = "vlhost_napis";
            this.vlhost_napis.Size = new System.Drawing.Size(138, 39);
            this.vlhost_napis.TabIndex = 6;
            this.vlhost_napis.Text = "Vlhkost:";
            // 
            // vlhkost_cislo
            // 
            this.vlhkost_cislo.AutoSize = true;
            this.vlhkost_cislo.BackColor = System.Drawing.Color.Transparent;
            this.vlhkost_cislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vlhkost_cislo.ForeColor = System.Drawing.Color.White;
            this.vlhkost_cislo.Location = new System.Drawing.Point(449, 152);
            this.vlhkost_cislo.Name = "vlhkost_cislo";
            this.vlhkost_cislo.Size = new System.Drawing.Size(83, 39);
            this.vlhkost_cislo.TabIndex = 7;
            this.vlhkost_cislo.Text = "------";
            // 
            // teplota_napis
            // 
            this.teplota_napis.AutoSize = true;
            this.teplota_napis.BackColor = System.Drawing.Color.DimGray;
            this.teplota_napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teplota_napis.ForeColor = System.Drawing.Color.White;
            this.teplota_napis.Location = new System.Drawing.Point(280, 84);
            this.teplota_napis.Name = "teplota_napis";
            this.teplota_napis.Size = new System.Drawing.Size(140, 39);
            this.teplota_napis.TabIndex = 8;
            this.teplota_napis.Text = "Teplota:";
            // 
            // teplota_cislo
            // 
            this.teplota_cislo.AutoSize = true;
            this.teplota_cislo.BackColor = System.Drawing.Color.Transparent;
            this.teplota_cislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teplota_cislo.ForeColor = System.Drawing.Color.White;
            this.teplota_cislo.Location = new System.Drawing.Point(449, 82);
            this.teplota_cislo.Name = "teplota_cislo";
            this.teplota_cislo.Size = new System.Drawing.Size(83, 39);
            this.teplota_cislo.TabIndex = 9;
            this.teplota_cislo.Text = "------";
            // 
            // nadoba_prazdna
            // 
            this.nadoba_prazdna.BackColor = System.Drawing.Color.Transparent;
            this.nadoba_prazdna.Image = ((System.Drawing.Image)(resources.GetObject("nadoba_prazdna.Image")));
            this.nadoba_prazdna.Location = new System.Drawing.Point(12, 44);
            this.nadoba_prazdna.Name = "nadoba_prazdna";
            this.nadoba_prazdna.Size = new System.Drawing.Size(97, 192);
            this.nadoba_prazdna.TabIndex = 11;
            this.nadoba_prazdna.TabStop = false;
            // 
            // slunce
            // 
            this.slunce.BackColor = System.Drawing.Color.Transparent;
            this.slunce.Image = ((System.Drawing.Image)(resources.GetObject("slunce.Image")));
            this.slunce.Location = new System.Drawing.Point(-11, 44);
            this.slunce.Name = "slunce";
            this.slunce.Size = new System.Drawing.Size(190, 160);
            this.slunce.TabIndex = 12;
            this.slunce.TabStop = false;
            // 
            // dest
            // 
            this.dest.BackColor = System.Drawing.Color.Transparent;
            this.dest.Image = ((System.Drawing.Image)(resources.GetObject("dest.Image")));
            this.dest.Location = new System.Drawing.Point(29, 55);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(150, 177);
            this.dest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dest.TabIndex = 13;
            this.dest.TabStop = false;
            // 
            // snih
            // 
            this.snih.BackColor = System.Drawing.Color.Transparent;
            this.snih.Image = ((System.Drawing.Image)(resources.GetObject("snih.Image")));
            this.snih.Location = new System.Drawing.Point(38, 55);
            this.snih.Name = "snih";
            this.snih.Size = new System.Drawing.Size(132, 136);
            this.snih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.snih.TabIndex = 14;
            this.snih.TabStop = false;
            // 
            // zavlazovani_lehke
            // 
            this.zavlazovani_lehke.AutoSize = true;
            this.zavlazovani_lehke.BackColor = System.Drawing.Color.Transparent;
            this.zavlazovani_lehke.ForeColor = System.Drawing.Color.White;
            this.zavlazovani_lehke.Location = new System.Drawing.Point(6, 19);
            this.zavlazovani_lehke.Name = "zavlazovani_lehke";
            this.zavlazovani_lehke.Size = new System.Drawing.Size(256, 35);
            this.zavlazovani_lehke.TabIndex = 16;
            this.zavlazovani_lehke.TabStop = true;
            this.zavlazovani_lehke.Text = "Lehké zavlažování";
            this.zavlazovani_lehke.UseVisualStyleBackColor = false;
            // 
            // zavlazovani_stredni
            // 
            this.zavlazovani_stredni.AutoSize = true;
            this.zavlazovani_stredni.BackColor = System.Drawing.Color.Transparent;
            this.zavlazovani_stredni.ForeColor = System.Drawing.Color.White;
            this.zavlazovani_stredni.Location = new System.Drawing.Point(5, 67);
            this.zavlazovani_stredni.Name = "zavlazovani_stredni";
            this.zavlazovani_stredni.Size = new System.Drawing.Size(268, 35);
            this.zavlazovani_stredni.TabIndex = 17;
            this.zavlazovani_stredni.TabStop = true;
            this.zavlazovani_stredni.Text = "Střední zavlažování";
            this.zavlazovani_stredni.UseVisualStyleBackColor = false;
            // 
            // zavlazovani_silne
            // 
            this.zavlazovani_silne.AutoSize = true;
            this.zavlazovani_silne.BackColor = System.Drawing.Color.Transparent;
            this.zavlazovani_silne.ForeColor = System.Drawing.Color.White;
            this.zavlazovani_silne.Location = new System.Drawing.Point(6, 113);
            this.zavlazovani_silne.Name = "zavlazovani_silne";
            this.zavlazovani_silne.Size = new System.Drawing.Size(242, 35);
            this.zavlazovani_silne.TabIndex = 18;
            this.zavlazovani_silne.TabStop = true;
            this.zavlazovani_silne.Text = "Silné zavlažování";
            this.zavlazovani_silne.UseVisualStyleBackColor = false;
            // 
            // zavlazeni
            // 
            this.zavlazeni.BackColor = System.Drawing.Color.Transparent;
            this.zavlazeni.Controls.Add(this.zavlazovani_lehke);
            this.zavlazeni.Controls.Add(this.zavlazovani_silne);
            this.zavlazeni.Controls.Add(this.zavlazovani_stredni);
            this.zavlazeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zavlazeni.ForeColor = System.Drawing.Color.White;
            this.zavlazeni.Location = new System.Drawing.Point(7, 33);
            this.zavlazeni.Name = "zavlazeni";
            this.zavlazeni.Size = new System.Drawing.Size(285, 158);
            this.zavlazeni.TabIndex = 19;
            this.zavlazeni.TabStop = false;
            // 
            // button_odcerpani
            // 
            this.button_odcerpani.BackColor = System.Drawing.Color.DimGray;
            this.button_odcerpani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_odcerpani.ForeColor = System.Drawing.Color.White;
            this.button_odcerpani.Location = new System.Drawing.Point(289, 55);
            this.button_odcerpani.Name = "button_odcerpani";
            this.button_odcerpani.Size = new System.Drawing.Size(285, 52);
            this.button_odcerpani.TabIndex = 19;
            this.button_odcerpani.Text = "Odčerpat veškerou vodu";
            this.button_odcerpani.UseVisualStyleBackColor = false;
            this.button_odcerpani.Click += new System.EventHandler(this.button_odcerpani_Click);
            // 
            // pojistka
            // 
            this.pojistka.BackColor = System.Drawing.Color.Transparent;
            this.pojistka.Controls.Add(this.check_jistota);
            this.pojistka.Controls.Add(this.button_pojistka);
            this.pojistka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pojistka.ForeColor = System.Drawing.Color.White;
            this.pojistka.Location = new System.Drawing.Point(64, 196);
            this.pojistka.Name = "pojistka";
            this.pojistka.Size = new System.Drawing.Size(468, 108);
            this.pojistka.TabIndex = 20;
            this.pojistka.TabStop = false;
            // 
            // check_jistota
            // 
            this.check_jistota.AutoSize = true;
            this.check_jistota.Location = new System.Drawing.Point(19, 18);
            this.check_jistota.Name = "check_jistota";
            this.check_jistota.Size = new System.Drawing.Size(443, 29);
            this.check_jistota.TabIndex = 1;
            this.check_jistota.Text = "Jste si jistí, že chcete odčerpat veškerou vodu ?";
            this.check_jistota.UseVisualStyleBackColor = true;
            // 
            // button_pojistka
            // 
            this.button_pojistka.BackColor = System.Drawing.Color.DimGray;
            this.button_pojistka.Location = new System.Drawing.Point(363, 59);
            this.button_pojistka.Name = "button_pojistka";
            this.button_pojistka.Size = new System.Drawing.Size(99, 43);
            this.button_pojistka.TabIndex = 0;
            this.button_pojistka.Text = "Potvrdit";
            this.button_pojistka.UseVisualStyleBackColor = false;
            this.button_pojistka.Click += new System.EventHandler(this.button_pojistka_Click);
            // 
            // button_manualnizavlazeni
            // 
            this.button_manualnizavlazeni.BackColor = System.Drawing.Color.DimGray;
            this.button_manualnizavlazeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_manualnizavlazeni.ForeColor = System.Drawing.Color.White;
            this.button_manualnizavlazeni.Location = new System.Drawing.Point(377, 242);
            this.button_manualnizavlazeni.Name = "button_manualnizavlazeni";
            this.button_manualnizavlazeni.Size = new System.Drawing.Size(226, 62);
            this.button_manualnizavlazeni.TabIndex = 16;
            this.button_manualnizavlazeni.Text = "Automatické zavlažování";
            this.button_manualnizavlazeni.UseVisualStyleBackColor = false;
            // 
            // button_zavlazeni
            // 
            this.button_zavlazeni.BackColor = System.Drawing.Color.DimGray;
            this.button_zavlazeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zavlazeni.ForeColor = System.Drawing.Color.White;
            this.button_zavlazeni.Location = new System.Drawing.Point(362, 100);
            this.button_zavlazeni.Name = "button_zavlazeni";
            this.button_zavlazeni.Size = new System.Drawing.Size(155, 60);
            this.button_zavlazeni.TabIndex = 21;
            this.button_zavlazeni.Text = "Proveď";
            this.button_zavlazeni.UseVisualStyleBackColor = false;
            this.button_zavlazeni.Click += new System.EventHandler(this.button_zavlazeni_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_vypnuti
            // 
            this.button_vypnuti.BackColor = System.Drawing.Color.DimGray;
            this.button_vypnuti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_vypnuti.ForeColor = System.Drawing.Color.White;
            this.button_vypnuti.Location = new System.Drawing.Point(20, 242);
            this.button_vypnuti.Name = "button_vypnuti";
            this.button_vypnuti.Size = new System.Drawing.Size(190, 60);
            this.button_vypnuti.TabIndex = 22;
            this.button_vypnuti.Text = "Vypnout zavlažování";
            this.button_vypnuti.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 320);
            this.Controls.Add(this.button_vypnuti);
            this.Controls.Add(this.button_zavlazeni);
            this.Controls.Add(this.pojistka);
            this.Controls.Add(this.button_odcerpani);
            this.Controls.Add(this.button_manualnizavlazeni);
            this.Controls.Add(this.zavlazeni);
            this.Controls.Add(this.snih);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.slunce);
            this.Controls.Add(this.nadoba_prazdna);
            this.Controls.Add(this.teplota_cislo);
            this.Controls.Add(this.teplota_napis);
            this.Controls.Add(this.vlhkost_cislo);
            this.Controls.Add(this.vlhost_napis);
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
            ((System.ComponentModel.ISupportInitialize)(this.nadoba_prazdna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slunce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snih)).EndInit();
            this.zavlazeni.ResumeLayout(false);
            this.zavlazeni.PerformLayout();
            this.pojistka.ResumeLayout(false);
            this.pojistka.PerformLayout();
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
        private System.Windows.Forms.Label vlhost_napis;
        private System.Windows.Forms.Label vlhkost_cislo;
        private System.Windows.Forms.Label teplota_napis;
        private System.Windows.Forms.Label teplota_cislo;
        private System.Windows.Forms.PictureBox nadoba_prazdna;
        private System.Windows.Forms.PictureBox slunce;
        private System.Windows.Forms.PictureBox dest;
        private System.Windows.Forms.PictureBox snih;
        private System.Windows.Forms.RadioButton zavlazovani_lehke;
        private System.Windows.Forms.RadioButton zavlazovani_stredni;
        private System.Windows.Forms.RadioButton zavlazovani_silne;
        private System.Windows.Forms.GroupBox zavlazeni;
        private System.Windows.Forms.Button button_odcerpani;
        private System.Windows.Forms.GroupBox pojistka;
        private System.Windows.Forms.CheckBox check_jistota;
        private System.Windows.Forms.Button button_pojistka;
        private System.Windows.Forms.Button button_manualnizavlazeni;
        private System.Windows.Forms.Button button_zavlazeni;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_vypnuti;
    }
}

