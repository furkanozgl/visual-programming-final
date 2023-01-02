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
    public partial class thmguncelle : Form
    {

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=urunler;user=root;Pwd=12345678;");

        public thmguncelle()
        {
            InitializeComponent();
        }
        public void verigoster(string veriler)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, con);
            DataSet dtgrv = new DataSet();
            da.Fill(dtgrv);

            dataGridView1.DataSource = dtgrv.Tables[0];
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = AccessibleDefaultActionDescription.ToString();
            verigoster("Select * fron tohum where tohumid=@id");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
