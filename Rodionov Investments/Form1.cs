using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodionov_Investments
{
    public partial class Form1 : Form
    {
        payment payForm = new payment();

        Currency dollar = new Currency(74.63, 0.01);
        Currency euro = new Currency(89.63, 0.02);
        Currency pound = new Currency(103.59, 0.05);
        Currency sheqel = new Currency(22.60, 0.1);

        Random rnd = new Random();

        double bal = 100;
        int count_dollar = 0;
        int count_euro = 0;
        int count_pound = 0;
        int count_sheqel = 0;

        int i;

        public Form1()
        {
            InitializeComponent();
            i = 0;
            label_ru.Text = "" + bal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (payForm.answer > 0) { bal += payForm.answer; payForm.answer = 0; label_ru.Text = "" + bal; }
            if (i >= 300)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                i = 0;
            }
            chart1.Series[0].Points.AddXY(i, dollar.nextvalue(rnd.NextDouble()));
            chart1.Series[1].Points.AddXY(i, euro.nextvalue(rnd.NextDouble()));
            chart1.Series[2].Points.AddXY(i, pound.nextvalue(rnd.NextDouble()));
            chart1.Series[3].Points.AddXY(i, sheqel.nextvalue(rnd.NextDouble()));
            i++;
        }



        // buy buttons
        private void button_buy_doll_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (bal >= dollar.value) { bal -= dollar.value; count_dollar++; }
            else { label_err.Visible = true; button_bal.Visible = true; }
            label_ru.Text = "" + bal;
            label_doll.Text = "" + count_dollar;
        }

        private void button_buy_eur_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (bal >= euro.value) { bal -= euro.value; count_euro++; }
            else { label_err.Visible = true; button_bal.Visible = true; }
            label_ru.Text = "" + bal;
            label_eur.Text = "" + count_euro;
        }

        private void button_buy_pou_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (bal >= pound.value) { bal -= pound.value; count_pound++; }
            else { label_err.Visible = true; button_bal.Visible = true; }
            label_ru.Text = "" + bal;
            label_pou.Text = "" + count_pound;
        }

        private void button_buy_she_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (bal >= sheqel.value) { bal -= sheqel.value; count_sheqel++; }
            else { label_err.Visible = true; button_bal.Visible = true; }
            label_ru.Text = "" + bal;
            label_she.Text = "" + count_sheqel;
        }



        // sell buttons
        private void button_sell_doll_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (count_dollar > 0) { bal += dollar.value; count_dollar--; }
            label_ru.Text = "" + bal;
            label_doll.Text = "" + count_dollar;
        }

        private void button_sell_eur_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (count_euro > 0) { bal += euro.value; count_euro--; }
            label_ru.Text = "" + bal;
            label_eur.Text = "" + count_euro;
        }

        private void button_sell_pou_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (count_pound > 0) { bal += pound.value; count_pound--; }
            label_ru.Text = "" + bal;
            label_pou.Text = "" + count_pound;
        }

        private void button_sell_she_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;
            if (count_sheqel > 0) { bal += sheqel.value; count_sheqel--; }
            label_ru.Text = "" + bal;
            label_she.Text = "" + count_sheqel;
        }

        private void button_bal_Click(object sender, EventArgs e)
        {
            label_err.Visible = false;

            payForm.ShowDialog();
        }
    }
}
