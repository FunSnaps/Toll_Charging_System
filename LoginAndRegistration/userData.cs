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
        private static List<paymenthistory> pList = new List<paymenthistory>();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string convertDate(DateTime date)
        {
            return date.ToString("dd/M/yyyy");
        }

        public static string findPayment(string date)
        {
            string temp = "";
            for (int x = 0; x < pList.Count; x++)
            {
                if (pList[x].invoiceDate == date)
                {
                    temp = x.ToString();
                }
            }
            return temp;
        }

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
                    list.Add(new users() { Name = dr.GetValue(0).ToString(), Paid = (bool)dr.GetValue(4), Car = dr.GetValue(3).ToString(), NumberPlate = RandomString(5) });
                }
            }
            con.Close();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label10.Text = "";
            foreach (users u in list)
            {
                listBox1.Items.Add(u.Name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            pList.RemoveAll(x => x.Name == list[listBox1.SelectedIndex].Name);
            con.Open();
            string login = "SELECT * FROM tbl_history";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetValue(1).ToString() == list[listBox1.SelectedIndex].Name.ToString())
                {
                    pList.Add(new paymenthistory() { Name = dr.GetValue(1).ToString(), Paid = (bool)dr.GetValue(4), invoiceDate = convertDate((DateTime)dr.GetValue(2)), Amount = dr.GetValue(3).ToString() });
                }
            }
            con.Close();

            foreach (paymenthistory p in pList)
            {
                if(p.Name == list[listBox1.SelectedIndex].Name.ToString())
                {
                    listBox2.Items.Add(p.invoiceDate);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = list[listBox1.SelectedIndex].Name;
            label3.Text = list[listBox1.SelectedIndex].Car;
            label10.Text = RandomString(5);
            label2.Text = pList[int.Parse(findPayment(listBox2.SelectedItem.ToString()))].Paid.ToString();
            label11.Text = "£" + pList[int.Parse(findPayment(listBox2.SelectedItem.ToString()))].Amount;
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
