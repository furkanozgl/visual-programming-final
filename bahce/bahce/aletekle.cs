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
    public partial class aletekle : Form
    {
        aletstok aletstok = new aletstok();
        public aletekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            aletstok.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=urunler;user=root;Pwd=12345678;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO alet(aletad,hakkinda,adet,fiyat) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "','" +textBox4.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                aletstok.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
