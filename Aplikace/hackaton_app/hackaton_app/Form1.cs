using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackaton_app
{
    public partial class Form1 : Form
    {
        private float Naplneni;
        private float Vlhkost;
        private float Teplota;

        public Form1()
        {
            InitializeComponent();
        }

        private void stavNádržeToolStripMenuItem_Click(object sender, EventArgs e) //Kolonka ,,Stav nádrže"
        {
           
            vlhost_napis.Visible = false;
            vlhkost_cislo.Visible = false;
            teplota_napis.Visible = false;
            teplota_cislo.Visible = false;
            slunce.Visible=false;         
            dest.Visible=false;
            snih.Visible=false;
            zavlazeni.Visible = false;
            pojistka.Visible = false;
            button_odcerpani.Visible = false;
            button_manualnizavlazeni.Visible=false;
            button_zavlazeni.Visible = false;

            float stav_nadrze  = 0f; //SEM VLOŽIT PROMĚNOU, JEŽ URČUJE HLADINU VODY
            obsah.Visible = true;
             if(stav_nadrze==1)
             {nadoba_ctvrt.Visible=false;
              nadoba_polovina.Visible=false;
              nadoba_trictvrte.Visible=false;
              nadoba_plna.Visible=true;
              obsah.Text = (stav_nadrze*100).ToString()+"%";
             }
             if(stav_nadrze==0.75)
             {nadoba_ctvrt.Visible=false;
              nadoba_polovina.Visible=false;
              nadoba_trictvrte.Visible=true;
              nadoba_plna.Visible=false;
              obsah.Text = (stav_nadrze * 100).ToString() + "%";
             }
              if(stav_nadrze==0.5)
             {nadoba_ctvrt.Visible=false;
              nadoba_polovina.Visible=true;
              nadoba_trictvrte.Visible=false;
              nadoba_plna.Visible=false;
              obsah.Text = (stav_nadrze * 100).ToString() + "%";
             }
              if(stav_nadrze==0.25)
             {nadoba_ctvrt.Visible=true;
              nadoba_polovina.Visible=false;
              nadoba_trictvrte.Visible=false;
              nadoba_plna.Visible=false;
              obsah.Text = (stav_nadrze * 100).ToString() + "%";
             }
              if (stav_nadrze == 0)
              {
                  nadoba_ctvrt.Visible = false;
                  nadoba_polovina.Visible = false;
                  nadoba_trictvrte.Visible = false;
                  nadoba_plna.Visible = false;
                  nadoba_prazdna.Visible = true;
                  obsah.Text = (stav_nadrze * 100).ToString() + "%";
              }
        }

        private void Form1_Load(object sender, EventArgs e) //Spuštění
        {
            stavNádržeToolStripMenuItem_Click(null,null);

            Naplneni = 0;
            Vlhkost = 0;
            Teplota = 0;
        }

        private void počasíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nadoba_prazdna.Visible = false;
            nadoba_polovina.Visible = false;
            nadoba_trictvrte.Visible = false;
            nadoba_plna.Visible = false;
            nadoba_ctvrt.Visible = false;
            obsah.Visible = false;
            vlhost_napis.Visible = true;
            vlhkost_cislo.Visible = true;
            teplota_napis.Visible = true;
            teplota_cislo.Visible = true;
            slunce.Visible=false;
            dest.Visible=false;
            snih.Visible=false;
            zavlazeni.Visible = false;
            pojistka.Visible = false;
            button_odcerpani.Visible = false;
            button_manualnizavlazeni.Visible = false;
            button_odcerpani.Visible = false;
            button_zavlazeni.Visible = false;

            float harryhoSestra = 0.55f; //JSEM PROMĚNÁ URČUJÍCÍ VLHKOST
            float teplota = -5f; //SEM PROMĚNOU TEPLOTY

            teplota_cislo.Text = teplota.ToString() + "°C";
            vlhkost_cislo.Text = (harryhoSestra * 100).ToString() + "%";

            if (harryhoSestra > 0.51)
            {
                 if (teplota < 0) snih.Visible = true;
                 else dest.Visible = true;
            }
            else slunce.Visible = true;

        }

        private void zavlažováníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_zavlazeni.Visible = true;
            vlhost_napis.Visible = false;
            vlhkost_cislo.Visible = false;
            teplota_napis.Visible = false;
            teplota_cislo.Visible = false;
            slunce.Visible = false;
            dest.Visible = false;
            snih.Visible = false;
            nadoba_prazdna.Visible = false;
            nadoba_polovina.Visible = false;
            nadoba_trictvrte.Visible = false;
            nadoba_plna.Visible = false;
            nadoba_ctvrt.Visible = false;
            obsah.Visible = false;
            pojistka.Visible = false;
            button_odcerpani.Visible = false;

            zavlazovani_lehke.Checked = true;
            zavlazeni.Visible = true;
            button_manualnizavlazeni.Visible = true;
           
        
        }

       

        private void očerpáníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_zavlazeni.Visible = false;
            vlhost_napis.Visible = false;
            vlhkost_cislo.Visible = false;
            teplota_napis.Visible = false;
            teplota_cislo.Visible = false;
            slunce.Visible = false;
            dest.Visible = false;
            snih.Visible = false;
            zavlazeni.Visible = false;
            nadoba_prazdna.Visible = false;
            nadoba_polovina.Visible = false;
            nadoba_trictvrte.Visible = false;
            nadoba_plna.Visible = false;
            nadoba_ctvrt.Visible = false;
            obsah.Visible = false;
            pojistka.Visible = true;
            button_manualnizavlazeni.Visible = false;
            button_odcerpani.Visible = false;

        }

        private void button_pojistka_Click(object sender, EventArgs e)
        {
            if (check_jistota.Checked) button_odcerpani.Visible = true;
        }

        private void button_odcerpani_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chcete opravdu odčerpat veškerou vodu do kanalizace ?", "Potvrzení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //Fce odčerpání
            }
        }

        private void button_zavlazeni_Click(object sender, EventArgs e)
        {
            if (zavlazovani_lehke.Checked)
            {
                //Proveď fce
            }
            else if (zavlazovani_stredni.Checked)
            {
                //Proveď fce
            }
            else if (zavlazovani_silne.Checked)
            {
                //Proveď fce
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chcete opravdu ukončit ?", "Upozornění", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
