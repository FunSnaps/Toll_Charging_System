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
    public partial class PayToll : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        string username;
        public PayToll(string name)
        {
            InitializeComponent();
            paymentBtn.Hide();
            username = name;

            con.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbl_payments", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetString(0) == username)
                    {
                        reciptList.Items.Add(new Recipt(dr.GetString(1), dr.GetString(2), dr.GetString(3)));
                    }
                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Update Error!");
                Console.WriteLine(err);
                con.Close();
            }
        }


        private void paymentBtn_Click(object sender, EventArgs e)
        {
            Recipt recipt = (Recipt)reciptList.SelectedItem;
            recipt.setPaid();
            paymentBtn.Visible = false;
            paymentMadeLbl.Text = "Paid : " + recipt.getPaid().ToString();

            con.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE tbl_payments SET paid = '" + recipt.getPaid().ToString() + "' WHERE journeydate = '" + recipt.getDate().ToString("G") + "'", con);
                Console.WriteLine(cmd);
                //cmd = new OleDbCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Update Error!");
                Console.WriteLine(err);
                con.Close();
            }
        }

        private void reciptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipt recipt = (Recipt)reciptList.SelectedItem;
            if (recipt.getPaid().ToString() == "True")
            {
                paymentBtn.Hide();
            }
            paymentBtn.Show();
            try
            {
                priceLbl.Text = "Price : " + recipt.getCost().ToString("c");
                dateLbl.Text = "Date of Journey : " + recipt.getDate().ToString("g");
                paymentMadeLbl.Text = "Paid : " + recipt.getPaid().ToString();

                if (recipt.getPaid().ToString() == "True")
                {
                    paymentBtn.Hide();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Please click on a payment");
                Console.WriteLine(err);
            }
            
        }
        private void simulateToll_Click(object sender, EventArgs e)
        {
            Recipt recipt = new Recipt();
            reciptList.Items.Add(recipt);

            con.Open();
            try
            {
                string payments = $"INSERT INTO tbl_payments VALUES ('{username}', '{recipt.getDate().ToString("G")}', '{recipt.getCost().ToString("c")}', '{recipt.getPaid().ToString()}')";
                cmd = new OleDbCommand(payments, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Save Error!");
                Console.WriteLine(err);
                con.Close();
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        Point lastPoint;

        private void PayToll_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void PayToll_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}


public class Recipt
{
    //recipt class..
    Random rand = new Random();
    DateTime date;
    double cost;
    bool paid;


    public override string ToString()
    {
        return date.ToString("d");
    }
    public Recipt()
    {
        generateCost();
        generateDate();
        paid = false;
    }

    public Recipt(string inDate, string inCost, string inPaid)
    {
        date = DateTime.Parse(inDate);
        cost = Double.Parse(inCost, System.Globalization.NumberStyles.Currency);
        paid = Convert.ToBoolean(inPaid);
    }

    public double getCost()
    {
        return cost;
    }

    private void generateCost()
    {
        cost = rand.NextDouble(5.00, 12.00);
    }

    private void generateDate()
    {
        DateTime from = new DateTime(2020, 1, 1);
        DateTime to = DateTime.Now;

        TimeSpan range = new TimeSpan(to.Ticks - from.Ticks);
        date = from + new TimeSpan((long)(range.Ticks * rand.NextDouble()));
    }

    public DateTime getDate()
    {
        return date;
    }


    public void setPaid()
    {
        paid = true;
    }

    public bool getPaid()
    {
        return paid;
    }
}

public static class RandomExtensions
{
    //just extending the random functionality so i can get random prices.
    public static double NextDouble(
        this Random random,
        double minValue,
        double maxValue)
    {
        return random.NextDouble() * (maxValue - minValue) + minValue;
    }
}