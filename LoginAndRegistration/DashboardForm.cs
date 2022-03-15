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
    }
}
