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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

        }
        public Form7(string message1, string message2)
        {
            InitializeComponent();
            txtf7_host.Text = message1;
              txtf7_id.Text = message2;
           
        }

        private List<Patienttest> f7gridview()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select testid, TestName, TestCode, TestPrice, PatientID from tb_patest where PatientID = (select PatientID from tb_patient where PatientName = '{0}') ; ", txtf7_name.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Patienttest> list = new List<Patienttest>();
            while (reader.Read())
            {
                Patienttest ptst = new Patienttest();
                ptst.testid = reader.GetInt32(reader.GetOrdinal("testid"));
                ptst.TestName = reader.GetString(reader.GetOrdinal("TestName"));
                ptst.TestCode = reader.GetString(reader.GetOrdinal("TestCode"));
                ptst.TestPrice = reader.GetInt32(reader.GetOrdinal("TestPrice"));
                ptst.PatientID = reader.GetInt32(reader.GetOrdinal("PatientID"));

                list.Add(ptst);

            }
            conn.Close();
            return list;

        }


        private void btnf7_search_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "select * from tb_patient;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtf7_name.Text = reader.GetString(reader.GetOrdinal("PatientName"));
                txtf7_gender.Text = reader.GetString(reader.GetOrdinal("Gender"));
                txtf7_age.Text = (reader.GetInt32(reader.GetOrdinal("Age"))).ToString();
                txtf7_phone.Text = (reader.GetInt64(reader.GetOrdinal("Phone"))).ToString();
                txtf7_address.Text = (reader.GetString(reader.GetOrdinal("Address"))).ToString();
            }

            var list = f7gridview();
            gridf7_patient.DataSource = list;

            loadcombotest();

        }

        public void loadcombotest()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "select test_name, price from tb_testdir;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Testdir> list = new List<Testdir>();
            while (reader.Read())
            {
                Testdir tdir = new Testdir();
                tdir.testname = reader.GetString(reader.GetOrdinal("test_name"));
                tdir.price = reader.GetInt32(reader.GetOrdinal("price"));
                int count = 1;
                tdir.ID = count;
                count++;

                list.Add(tdir);

            }
            combof7_test.DataSource = list;
            combof7_test.ValueMember = "ID";
            combof7_test.DisplayMember = "testname";

            conn.Close();

        }

        private void btnf7_add_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into tb_patest(TestName, TestCode, TestPrice, PatientID) values ('{0}',(select test_code from tb_testdir where test_name ='{0}'),(select Price from tb_testdir where test_name ='{0}'),(select PatientID from tb_patient where PatientName = '{1}'))", combof7_test.Text, txtf7_name.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("TestAdded");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            var list = f7gridview();
            gridf7_patient.DataSource = list;

        }

        private void btnf7_remove_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("delete from tb_patest where testid = {0} and PatientID = (select PatientID from tb_patient where PatientName = '{1}')", txtf7_testno.Text, txtf7_name.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Test Removed");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            var list = f7gridview();
            gridf7_patient.DataSource = list;

        }

        private void btnf7menu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(txtf7_host.Text);
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
