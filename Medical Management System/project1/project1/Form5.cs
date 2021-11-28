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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(string host, string serial, string name, string age )
        { 
            InitializeComponent();
            txtf5_age.Text = age;
            txtf5_host.Text = host;
            txtf5_serial.Text = serial;
            txtf5_name.Text = name;
        }

        private void Form5_Load(object sender, EventArgs e)
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
            combof5_test.DataSource = list;
            combof5_test.ValueMember = "ID";
            combof5_test.DisplayMember = "testname";

            conn.Close();

        }

        private void combof5_test_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select  price from tb_testdir where test_name = '{0}'", combof5_test.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int pr = reader.GetInt32(reader.GetOrdinal("price"));
                txtf5_price.Text = pr.ToString();
            }
            conn.Close();
        }

        

      

        private List<Patienttest> gridview()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select testid, TestName, TestCode, TestPrice, PatientID from tb_patest where PatientID = (select PatientID from tb_patient where PatientName = '{0}') ; ", txtf5_name.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Patienttest> list = new List<Patienttest>();
            while (reader.Read())
            {
                Patienttest pt = new Patienttest();
                pt.testid = reader.GetInt32(reader.GetOrdinal("testid"));
                pt.TestName = reader.GetString(reader.GetOrdinal("TestName"));
                pt.TestCode = reader.GetString(reader.GetOrdinal("TestCode"));
                pt.TestPrice = reader.GetInt32(reader.GetOrdinal("TestPrice"));
                pt.PatientID = reader.GetInt32(reader.GetOrdinal("PatientID"));

                list.Add(pt);

            }
            conn.Close();
            return list;

        }

        private void btnf5_addtest_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into tb_patest(TestName, TestCode, TestPrice, PatientID) values ('{0}',(select test_code from tb_testdir where test_name ='{0}'),{1},(select PatientID from tb_patient where PatientName = '{2}'))", combof5_test.Text, txtf5_price.Text, txtf5_name.Text);
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

            var list = gridview();
            gridf5_test.DataSource = list;

            var subtot = total();
            txtf5_subtot.Text = subtot.ToString();

        }


        private void btnf5_removetest_Click(object sender, EventArgs e)
        {
            
         
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("delete from tb_patest where testid = {0} and PatientID = (select PatientID from tb_patient where PatientName = '{1}')", txtf5_remove.Text, txtf5_name.Text);
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

            var list = gridview();
            gridf5_test.DataSource = list;

            var subtot = total();
            txtf5_subtot.Text = subtot.ToString();

        }

        int subtotal;

        public int total()
        {
          
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select sum(TestPrice) from tb_patest where PatientID = (select PatientID from tb_patient where PatientName = '{0}') ;", txtf5_name.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               subtotal = reader.GetInt32(0);
            }
            conn.Close();
           return subtotal;
        }


        int discount;
        int nettotal;
        int paid;
        int balance;
       

        private void btnf5_updatepay_Click(object sender, EventArgs e)
        {
            

            discount = Int32.Parse(txtf5_discount.Text);


            nettotal = subtotal - discount;

            txtf5_netam.Text = nettotal.ToString();



            balance = nettotal - paid;

            txtf5_balance.Text = balance.ToString();

            
        }



        private void btnf5_menu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(txtf5_host.Text);
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void btnf5_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printed");
        }
    
    }
}
