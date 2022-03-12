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
    public partial class dashboard : Form
    {
        //when the window has been created it will store user name and send as arrgument
        public dashboard(string role)
        {
            InitializeComponent();
            label1.Text = role;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //pressing this button will take the user to driver payments ui
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pressing this button will take the user to operator ui
        }
    }
}
