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
        string username;
        public PayToll(string name)
        {
            InitializeComponent();
            paymentBtn.Enabled = false;
            username = name;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void paymentBtn_Click(object sender, EventArgs e)
        {
            Recipt recipt = (Recipt)reciptList.SelectedItem;
            recipt.setPaid();
            paymentBtn.Enabled = false;
            paymentMadeLbl.Text = "Paid : " + recipt.getPaid().ToString();

            con.Open();
            try
            {
                //string update = $"UPDATE tbl_payments SET paid = " & recipt.getPaid().ToString() & " WHERE date = " & recipt.getDate().ToString("G");
                cmd = new OleDbCommand("UPDATE tbl_payments SET paid = " + recipt.getPaid().ToString() + " WHERE journeydate = " + recipt.getDate().ToString("G"), con);
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
            paymentBtn.Enabled = !recipt.getPaid();
            priceLbl.Text = "Price : " + recipt.getCost().ToString("c");
            dateLbl.Text = "Date of Journey : " + recipt.getDate().ToString("g");
            paymentMadeLbl.Text = "Paid : " + recipt.getPaid().ToString();
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