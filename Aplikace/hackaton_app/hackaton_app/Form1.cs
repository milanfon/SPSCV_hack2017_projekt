using MSXML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hackaton_app
{
    public partial class Form1 : Form
    {
        private float Odpor;
        private float Naplneni;
        private float Vlhkost;
        private float Teplota;
        private bool WiFi = true;

        SerialPort sp = new SerialPort("COM7", 9600);

        public Form1()
        {
            InitializeComponent();
            
        }

        private void stavNádržeToolStripMenuItem_Click(object sender, EventArgs e) //Kolonka ,,Stav nádrže"
        {

            ConnectToModule();
            button_vypnuti.Visible = false;
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

            float stav_nadrze  = this.Naplneni; //SEM VLOŽIT PROMĚNOU, JEŽ URČUJE HLADINU VODY
            obsah.Visible = true;
             if(stav_nadrze==100)
             {nadoba_ctvrt.Visible=false;
              nadoba_polovina.Visible=false;
              nadoba_trictvrte.Visible=false;
              nadoba_plna.Visible=true;
                nadoba_prazdna.Visible = false;
              obsah.Text = (stav_nadrze).ToString()+"%";
             }
             if(stav_nadrze==75)
             {nadoba_ctvrt.Visible=false;
              nadoba_polovina.Visible=false;
              nadoba_trictvrte.Visible=true;
              nadoba_plna.Visible=false;
                nadoba_prazdna.Visible = false;
                obsah.Text = (stav_nadrze).ToString() + "%";
             }
              if(stav_nadrze==50)
             {nadoba_ctvrt.Visible=false;
              nadoba_polovina.Visible=true;
              nadoba_trictvrte.Visible=false;
              nadoba_plna.Visible=false;
                nadoba_prazdna.Visible = false;
                obsah.Text = (stav_nadrze).ToString() + "%";
             }
              if(stav_nadrze==25)
             {nadoba_ctvrt.Visible=true;
              nadoba_polovina.Visible=false;
              nadoba_trictvrte.Visible=false;
              nadoba_plna.Visible=false;
                nadoba_prazdna.Visible = false;
                obsah.Text = (stav_nadrze).ToString() + "%";
             }
              if (stav_nadrze == 0)
              {
                  nadoba_ctvrt.Visible = false;
                  nadoba_polovina.Visible = false;
                  nadoba_trictvrte.Visible = false;
                  nadoba_plna.Visible = false;
                  nadoba_prazdna.Visible = true;
                  obsah.Text = (stav_nadrze).ToString() + "%";
              }
        }

        private void Form1_Load(object sender, EventArgs e) //Spuštění
        {

            stavNádržeToolStripMenuItem_Click(null,null);

            Naplneni = 0;
            Vlhkost = 0;
            Teplota = 0;
            Odpor = 0;

            ConnectToModule();

            stavNádržeToolStripMenuItem_Click(null, null);
        }

        private void počasíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectToModule();
            button_vypnuti.Visible = false;
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

            float harryhoSestra = this.Vlhkost; //JSEM PROMĚNÁ URČUJÍCÍ VLHKOST
            float teplota = this.Teplota; //SEM PROMĚNOU TEPLOTY

            teplota_cislo.Text = teplota.ToString() + "°C";
            vlhkost_cislo.Text = (harryhoSestra ).ToString() + "%";

            if (harryhoSestra > 50.01)
            {
                 if (teplota < 0) snih.Visible = true;
                 else dest.Visible = true;
            }
            else slunce.Visible = true;

        }

        private void zavlažováníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_vypnuti.Visible = true;
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
          
            button_vypnuti.Visible = false;
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
                SendToTS(4);
            }
        }

        private void button_zavlazeni_Click(object sender, EventArgs e)
        {
            if (zavlazovani_lehke.Checked)
            {
                SendToTS(1);
            }
            else if (zavlazovani_stredni.Checked)
            {
                SendToTS(2);
            }
            else if (zavlazovani_silne.Checked)
            {
                SendToTS(3);
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

        private void ReadFromArduino()
        {
            sp.Open();
            string input = sp.ReadLine();
            input = input.Replace("\r", string.Empty);
            input = input.Replace(",", ";");
            input = input.Replace(".", ",");
            string[] warray = input.Split(';');
            
            this.Odpor = float.Parse(warray[0]);
            this.Teplota = float.Parse(warray[1]);
            this.Vlhkost = float.Parse(warray[2]);
            this.Naplneni = float.Parse(warray[3]);

            sp.Close();
        }

        private void UpdateThingSpeak()
        {
            this.Odpor = getFromTS(1);
            this.Teplota = getFromTS(2);
            this.Vlhkost = getFromTS(3);
            this.Naplneni = getFromTS(4);
        }

        private float getFromTS(int fid)
        {
            const string READKEY = "6123BHFJB7WJY5HC";
            int channelID = 381221;
            string strReadBase = "http://api.thingspeak.com/channels/";
            string strReadURI = strReadBase + channelID + "/field/" + fid + "/last.txt?key=" + READKEY;
            HttpWebRequest ThingsSpeakReq;
            HttpWebResponse ThingsSpeakResp;

            ThingsSpeakReq = (HttpWebRequest)WebRequest.Create(strReadURI);

            ThingsSpeakResp = (HttpWebResponse)ThingsSpeakReq.GetResponse();

            Stream dataStream = ThingsSpeakResp.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string strResponse = reader.ReadToEnd();
            strResponse = strResponse.Replace(".", ",");
            return float.Parse(strResponse);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ConnectToModule();
            if(teplota_cislo.Visible==true)
            {
                počasíToolStripMenuItem_Click(null, null);
            }
            if(obsah.Visible==true)
            {
                stavNádržeToolStripMenuItem_Click(null, null);
            }
        }

        private void ConnectToModule()
        {
            if (WiFi)
            {
                UpdateThingSpeak();
            }
            else
            {
                ReadFromArduino();
            }
        }

        private void SendToTS(int input)
        {
            const string writeKEY = "AG9NU2DHLD00YR80";
            var HttpAgent = new XMLHTTPRequest();
            var URI = "http://api.thingspeak.com/update?key=" + writeKEY + "&field5=" + input;

            HttpAgent.open("POST", URI);
            HttpAgent.send();
        }
    }
}
