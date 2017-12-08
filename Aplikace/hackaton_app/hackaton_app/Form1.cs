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
        public Form1()
        {
            InitializeComponent();
        }

        private void stavNádržeToolStripMenuItem_Click(object sender, EventArgs e) //Kolonka ,,Stav nádrže"
        {
            float stav_nadrze  = 0.25f; //SEM VLOŽIT PROMĚNOU, JEŽ URČUJE HLADINU VODY
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
            
        }

        private void Form1_Load(object sender, EventArgs e) //Spuštění
        {
            stavNádržeToolStripMenuItem_Click(null,null);
        }
    }
}
