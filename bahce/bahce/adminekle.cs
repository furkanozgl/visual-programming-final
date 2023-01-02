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
    public partial class adminekle : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;
        adminyonet ynt =new adminyonet();




        public adminekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminyonet admyonet = new adminyonet();

            int basAdmin;
            if (checkBox1.Checked == true)
            {
                basAdmin = 1;
            }
            else
            {
                basAdmin = 0;
            }
    
            try
            {

                con = new MySqlConnection("Server=localhost;Database=admins;user=root;Pwd=12345678;");
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO admin(admin_adi,sifre,basadmin) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + basAdmin + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                admyonet.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ynt.Show();
            this.Close();
        }
    }
}
