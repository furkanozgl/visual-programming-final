using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Xml;

namespace bahce
{
    public partial class panel : Form 
    {
        string hava_lnk = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";

        adminyonet admyonet = new adminyonet();
        public panel()
        {
            InitializeComponent();
        }


        private void panel_Load(object sender, EventArgs e)
        {


            XmlDocument doc1 = new XmlDocument();
            doc1.Load(hava_lnk);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");
            foreach (XmlNode node in nodes)
            {
                string ili = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string max_scaklk = node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ili;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = max_scaklk;
                dataGridView1.Rows.Add(row);

            }

            timer1.Start();


            string ytk = label3.Text.ToString();
            if (ytk == "1")
            {
                button5.Visible = true;
                label3.Text = "YÖNETİCİ ADMİN";

            }
            else 
            {
                label3.Text = "ADMİN";
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tohumstok thm = new tohumstok();
            thm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dekorstok dkrstok = new dekorstok();
            dkrstok.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aletstok altstk = new aletstok();
            altstk.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admyonet.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mavibahce mavibahce = new mavibahce();
            mavibahce.Show();
            this.Close();
        }
    }
}
