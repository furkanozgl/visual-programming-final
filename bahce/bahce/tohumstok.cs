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
    public partial class tohumstok : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
         MySqlConnection con = new MySqlConnection("Server=localhost;Database=urunler;user=root;Pwd=12345678;");
        panel pnl = new panel();
        
        public tohumstok()
        {
            InitializeComponent();
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            pnl.Show();
            
        }

        public void verigoster(string veriler)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, con);
            DataSet dtgrv = new DataSet();
            da.Fill(dtgrv);

            dataGridView1.DataSource = dtgrv.Tables[0];
        }
        private void tohumstok_Load(object sender, EventArgs e)
        {
            verigoster("SELECT * FROM tohum");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tohumekle thmekle = new tohumekle();
            this.Hide();
            thmekle.Show();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE from tohum where tohumid=@id", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            verigoster("SELECT * FROM tohum");
            con.Close();
            textBox1.Clear();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox2.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thmguncelle thmgnc = new thmguncelle();
            this.Hide();
            thmgnc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("update tohum set adet='" + textBox5.Text + "',fiyat='" + textBox4.Text + "' where tohumid='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir.", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            verigoster("SELECT * FROM tohum");
            con.Close();
            textBox1.Clear();
        }
    }
}
