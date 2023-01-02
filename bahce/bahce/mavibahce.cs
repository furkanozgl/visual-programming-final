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

namespace bahce
{
    public partial class mavibahce : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;
        panel pnl = new panel();

        public mavibahce()
        {
            InitializeComponent();
           
            con = new MySqlConnection("Server=localhost;Database=admins;user=root;Pwd=12345678;");
        }
       
    
        private void mavibahce_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl.button5.Visible = false;

            con.Open();
            string yetki = pnl.label3.Text;
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admin where admin_adi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            
            try
            {
                if (dr.Read())
                {
                    pnl.label3.Text = dr["basadmin"].ToString();
                    pnl.Show();
                    this.Hide();
                    
                }
                

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bos
        }
    }
}
