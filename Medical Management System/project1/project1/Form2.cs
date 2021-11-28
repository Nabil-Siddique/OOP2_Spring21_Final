using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnf2register_Click(object sender, EventArgs e) //register
        {
            string f2_name = txtf2name.Text;
            string f2_username = txtf2username.Text;
            string f2_department = txtf2department.Text;
            string f2_password = txtf2password.Text;
            string f2_confirmpass = txtf2confirmpass.Text;

            var conn = Database.ConnectDB();
            conn.Open();
            if (txtf2password.Text == txtf2confirmpass.Text)
            {
                string query = string.Format("insert into tb_host values ('{0}','{1}','{2}','{3}')", f2_name, f2_username, f2_department, f2_password);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Host Registered");
                }
                else
                {
                    MessageBox.Show("Couldn't insert given data");
                }
            }
            else
            {
                MessageBox.Show("Password dont match.");
            }
            conn.Close();
            var form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btnf2alreadyreg_Click(object sender, EventArgs e) //already reg
        {
            var form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
