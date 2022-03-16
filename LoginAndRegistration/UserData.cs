using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginAndRegistration
{
    public partial class UserData : Form
    {
        string username;
        string invoice;
        string price;
        string isPaid;
        public UserData()
        {
            InitializeComponent();
        }

        List<users> list = new List<users>();
        private static List<paymenthistory> pList = new List<paymenthistory>();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private static Random random = new Random();
        private paymenthistory[] payments;

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

        private void UserData_Load(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetValue(2).ToString() == "driver")
                {
                    list.Add(new users() { Name = dr.GetValue(0).ToString(), Car = dr.GetValue(3).ToString(), NumberPlate = RandomString(5) });
                }
            }
            con.Close();

            lblName.Text = "";
            lblPrice.Text = "";
            lblPaid.Text = "";
            lblDate.Text = "";
            foreach (users u in list)
            {
                listBox1.Items.Add(u.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            pList.RemoveAll(x => x.Name == list[listBox1.SelectedIndex].Name);
            con.Open();
            string login = "SELECT * FROM tbl_payments";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetString(0) == list[listBox1.SelectedIndex].Name.ToString())
                {
                    username = dr.GetString(0);
                    invoice = dr.GetString(1);
                    price = dr.GetString(2);
                    isPaid = dr.GetString(3);
                    pList.Add(new paymenthistory() { Name = dr.GetString(0), Paid = dr.GetString(3), invoiceDate = dr.GetString(1), Amount = dr.GetString(2)});
                }
            }
            con.Close();

            foreach (paymenthistory p in pList)
            {
                if (p.Name == list[listBox1.SelectedIndex].Name.ToString())
                {
                    listBox2.Items.Add(p);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            paymenthistory p = (paymenthistory)listBox2.SelectedItem;

            lblName.Text = p.Name;
            lblPrice.Text = p.Amount;
            lblDate.Text = p.invoiceDate;
            lblPaid.Text = p.Paid;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
