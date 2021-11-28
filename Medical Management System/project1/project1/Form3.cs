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
    public partial class Form3 : Form
    {

        public Form3() {
            InitializeComponent();
        }

        public Form3(string message1)
        {

            InitializeComponent();
            txtf3_host.Text = message1;

        }

        public void totalpat()
        {
            //totaloatient number 

            int totpat;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select count(PatientID) from tb_patient;");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                totpat = reader.GetInt32(0);
                txtf3_patient.Text = totpat.ToString();
            }
            conn.Close();
        }

        //public void totalcash() { }

        //public void totaldue() { }



        private void Form3_Load(object sender, EventArgs e)
        {
            totalpat();


        }

        private void btnf3_addpatient_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(txtf3_host.Text);
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void btnf3_viewpatient_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(txtf3_host.Text);
            this.Hide();
            form6.ShowDialog();
            this.Close();
        }

        private void btnf3_testdir_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(txtf3_host.Text);
            this.Hide();
            form8.ShowDialog();
            this.Close();
        }

        private void btnf3_signout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
