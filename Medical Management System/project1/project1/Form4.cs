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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
          
        }

        public Form4(string message)
        {
            InitializeComponent();
            txtf4_host.Text = message;
        }




        private void Form4_Load(object sender, EventArgs e)
        {
         
        }

        private void btnf4_proceedtest_Click(object sender, EventArgs e) //info taken and put into patient database
        {
            int f4_patientserial = Int32.Parse(txtf4_pserial.Text);
            string f4_patientname = txtf4_pname.Text;
            string f4_gender = combof4_gender.Text;
            int f4_patientage = Int32.Parse(txtf4_age.Text);
            string f4_address = rtxtf4_address.Text;
            long f4_phone = Int64.Parse(txtf4_phone.Text);

            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into tb_patient(Serial,PatientName, Gender, Age, Phone, Address, HostID) values ({0},'{1}','{2}',{3},{4},'{5}',(select HostID from tb_host where Username = '{6}'))", f4_patientserial, f4_patientname, f4_gender, f4_patientage, f4_phone, f4_address, txtf4_host.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Patient Created. Insert Tests");
                Form5 form5 = new Form5(txtf4_host.Text, txtf4_pserial.Text, txtf4_pname.Text, txtf4_age.Text);
                this.Hide();
                form5.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Couldn't insert given data. Try again.");
            }


        }

        private void btnf4_menu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(txtf4_host.Text);
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
