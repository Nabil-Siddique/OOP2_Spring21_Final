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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(string message)
        {
            InitializeComponent();
            txtf6_host.Text = message;
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
                txtf6_totpat.Text = totpat.ToString();
            }
            conn.Close();
        }

        private List<Patient> gridviewpatient()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "Select PatientID, Serial, PatientName, Gender, Age, Phone, Address, HostName from tb_patient p INNER JOIN tb_host h ON p.HostID = h.HostID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Patient> list = new List<Patient>();
            while (reader.Read())
            {
                Patient pat = new Patient();
                pat.PatientID = reader.GetInt32(reader.GetOrdinal("PatientID"));
                pat.Serial = reader.GetInt32(reader.GetOrdinal("Serial"));
                pat.PatientName = reader.GetString(reader.GetOrdinal("PatientName"));
                pat.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                pat.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                pat.phone = reader.GetInt64(reader.GetOrdinal("Phone"));
                pat.HostName = reader.GetString(reader.GetOrdinal("HostName"));
                pat.Address = reader.GetString(reader.GetOrdinal("Address"));


                list.Add(pat);

            }
            conn.Close();
            return list;

        }

        private void txtf6_totpat_TextChanged(object sender, EventArgs e) { } //ignore this

        private void Form6_Load(object sender, EventArgs e)
        {
            totalpat();

            var list = gridviewpatient();
            gridf6_patient.DataSource = list;


        }

        private void btnf6_remove_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("delete from tb_patest where PatientID = {0};", txtf6_patientid.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            string query1 = string.Format("delete from tb_patient where PatientID = {0};", txtf6_patientid.Text);
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            int r = cmd1.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Patient Removed");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            totalpat();

            var list = gridviewpatient();
            gridf6_patient.DataSource = list;
        }

        private void btnf6_check_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(txtf6_host.Text, txtf6_patientid.Text);
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void btnf8_menu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(txtf6_host.Text);
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
