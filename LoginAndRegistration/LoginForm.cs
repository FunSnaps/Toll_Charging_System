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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            LoginTxtUsername.Text = "";
            LoginTxtPassword.Text = "";
            LoginTxtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + LoginTxtUsername.Text + "' and password= '" + LoginTxtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                //After checking user login will pass the user obj and get their roles
                try
                {
                    String[] user = new string[5];
                    dr.GetValues(user);
                    new DashboardForm(user).Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginTxtUsername.Text = "";
                LoginTxtPassword.Text = "";
                LoginTxtUsername.Focus();
                con.Close();
            }
            
        }

        private void CheckboxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxShowPas.Checked)
            {
                LoginTxtPassword.PasswordChar = '\0';         
            }
            else
            {
                LoginTxtPassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonlistener(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
