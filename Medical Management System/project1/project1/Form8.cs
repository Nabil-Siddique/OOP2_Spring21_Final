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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public Form8(string message)
        {
            InitializeComponent();
            txtf8_host.Text = message;

        }

        private List<Testdir> gridf8view()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "select * from tb_testdir;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Testdir> list = new List<Testdir>();
            while (reader.Read())
            {
                Testdir tdir1 = new Testdir();

                tdir1.ID = reader.GetInt32(reader.GetOrdinal("Testdir_id"));
                tdir1.testname = reader.GetString(reader.GetOrdinal("test_name"));
                tdir1.price = reader.GetInt32(reader.GetOrdinal("Price"));
                tdir1.testcode = reader.GetString(reader.GetOrdinal("test_code"));

                list.Add(tdir1);
            }
            conn.Close();

            return list;
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            var list = gridf8view();
            gridf8_testdir.DataSource = list;

        }

        private void btnf8_addtest_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into tb_testdir(test_name, test_code, price) values ('{0}','{1}',{2})", txtf8_addname.Text, txtf8_code.Text, txtf8_addprice.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("New Test Added In Directory");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            var list = gridf8view();
            gridf8_testdir.DataSource = list;


        }

        private void btnf8_search_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select test_name, test_code, price from tb_testdir where Testdir_id = '{0}';",txtf8_testid.Text) ;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtf8_updname.Text = reader.GetString(reader.GetOrdinal("test_name"));
                txtf8_updcode.Text = reader.GetString(reader.GetOrdinal("test_code"));
                txtf8_updprice.Text = (reader.GetInt32(reader.GetOrdinal("price"))).ToString();
            }

        }

        private void btnf8_update_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("update tb_testdir set test_name = '{0}', test_code='{1}', price={2} where Testdir_id='{3}'", txtf8_updname.Text, txtf8_updcode.Text, txtf8_updprice.Text, txtf8_testid.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Test Updated In Directory");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            var list = gridf8view();
            gridf8_testdir.DataSource = list;
        }

        private void btnf8_menu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(txtf8_host.Text);
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void btnf8_remove_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("delete from tb_testdir where Testdir_id = '{0}'", txtf8_testid.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Test Removed from Directory");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            var list = gridf8view();
            gridf8_testdir.DataSource = list;
        }
    }
}
