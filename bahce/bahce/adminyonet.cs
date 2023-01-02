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
    public partial class adminyonet : Form
    {
        public adminyonet()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; uid=root;pwd=12345678;database=admins");

        public void verigoster(string veriler) 
        {
             MySqlDataAdapter da = new MySqlDataAdapter(veriler, con);
             DataSet dtgrv = new DataSet();
            da.Fill(dtgrv);

            dataGridView1.DataSource = dtgrv.Tables[0];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            adminekle admekle = new adminekle();
            admekle.Show();
            this.Hide();
        }

        private void adminyonet_Load(object sender, EventArgs e)
        {
            verigoster("SELECT * FROM admin");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE from admin where id=@id", con);
            cmd.Parameters.AddWithValue("@id",textBox1.Text);
            cmd.ExecuteNonQuery();
            verigoster("SELECT * FROM admin");
            con.Close();
            textBox1.Clear();
        }
              private void button4_Click(object sender, EventArgs e)
              {
            panel pnl = new panel();
            this.Hide();
            pnl.Show();
              }

        private void button3_Click(object sender, EventArgs e)
        {
            //bos
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
    }
}
