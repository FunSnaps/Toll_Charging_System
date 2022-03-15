using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistration
{
    public partial class userData : Form
    {
        public userData()
        {
            InitializeComponent();
        }

        List<users> list = new List<users>();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void userData_Load(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetValue(2).ToString() == "driver")
                {
                    list.Add(new users() { Name = dr.GetValue(0).ToString(), Paid = (bool)dr.GetValue(4), Car = dr.GetValue(3).ToString() });
                }
            }
            con.Close();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            foreach(users u in list)
            {
                listBox1.Items.Add(u.Name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = list[listBox1.SelectedIndex].Name.ToString();
            label2.Text = list[listBox1.SelectedIndex].Paid.ToString();
            label3.Text = list[listBox1.SelectedIndex].Car.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
