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
    public partial class PayTollPg : Form
    {
        public PayTollPg()
        {
            InitializeComponent();
            paymentBtn.Enabled = false;
        }

        private void simulateToll_Click(object sender, EventArgs e)
        {
            Recipt recipt = new Recipt();
            reciptList.Items.Add(recipt);
        }

        private void reciptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipt recipt = (Recipt)reciptList.SelectedItem;
            paymentBtn.Enabled = !recipt.getPaid();
            priceLbl.Text = "Price : " + recipt.getCost().ToString("c");
            dateLbl.Text = "Date of Journey : " + recipt.getDate().ToString("g");
            paymentMadeLbl.Text = "Paid : " + recipt.getPaid().ToString();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            Recipt recipt = (Recipt)reciptList.SelectedItem;
            recipt.setPaid();
            paymentBtn.Enabled = false;
            paymentMadeLbl.Text = "Paid : " + recipt.getPaid().ToString();
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