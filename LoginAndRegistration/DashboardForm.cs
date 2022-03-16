using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistration
{
    public partial class DashboardForm : Form
    {
        string username;
        string role;
        public DashboardForm(String[] user)
        {
            InitializeComponent();
             username = user[0];
             role = user[2];

            label5.Text = UppercaseFirst(role);
            label3.Text = role;
            //if its driver it will display the driver button 
            if (role == "driver")
            {
                button1.Show();
                button2.Hide();
            }
            //if its operator it will display the operator button 
            else if (role == "operator")
            {
                button2.Show();
                button1.Hide();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserData().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PayToll(username).Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
