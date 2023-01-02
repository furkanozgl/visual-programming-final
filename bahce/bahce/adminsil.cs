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
    public partial class adminsil : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;


        public adminsil()
        {
            InitializeComponent();
        }

        private void adminsil_Load(object sender, EventArgs e)
        {

        }
    }
}
