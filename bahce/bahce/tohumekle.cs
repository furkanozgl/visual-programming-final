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
    public partial class tohumekle : Form
    {
        tohumstok thmstok =new tohumstok();

        
        MySqlDataReader dr;


        public tohumekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thmstok.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=urunler;user=root;Pwd=12345678;");
               // int fiyat = Convert.ToInt32(textBox3.Text);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                
                cmd.Connection = con;
                cmd.CommandText ="INSERT INTO tohum(tohumad,hakkinda,adet,fiyat) VALUES ('" + textBox1.Text + "', '" + textBox2.Text+ "', '" + textBox4.Text+ "', '" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                thmstok.Show();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }
    }
}
