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
using System.Xml;

namespace bahce
{
    public partial class panel : Form 
    {

        adminyonet admyonet = new adminyonet();
        public panel()
        {
            InitializeComponent();
        }


        private void panel_Load(object sender, EventArgs e)
        {
            
           /* string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();

            string eskigun = "http://www.tcmb.gov.tr/kurlar/201501/31122022";

            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                
            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@kod='USD']/BanknoteSelling").InnerXml;
            label1.Text = string.Format("Tarih {0} USD; {1}", tarih.ToShortDateString(), USD);

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@kod='EUR']/BanknoteSelling").InnerXml;
            label1.Text = string.Format("Tarih {0} EURO; {1}", tarih.ToShortDateString(), EURO);*/


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
    }
}
