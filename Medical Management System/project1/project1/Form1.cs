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
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void btnf1login_Click(object sender, EventArgs e)  //LOGIN
        {
            //string f1_username = ;
           // string f1_password = ;

            //Host hs = new Host();
            //hs.Username = f1_username;

            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select * from tb_host where username = '{0}' and password = '{1}'", txtf1username.Text, txtf1password.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form3 form3 = new Form3(txtf1username.Text);
                this.Hide();
                form3.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            conn.Close();

        }

        private void btnf1notreg_Click(object sender, EventArgs e) //NOT REG
        {

            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

     
        
       

       
    }
}
