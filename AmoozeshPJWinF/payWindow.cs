using Amozesh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoozeshPJWinF
{
    public partial class payWindow : Form
    {
        public payWindow()
        {
            InitializeComponent();
        }

        private void tractimetxbH_TextChanged(object sender, EventArgs e)
        {

        }

        private void payWindow_Load(object sender, EventArgs e)
        {

        }

        private void tracTypeCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void useridtbx_TextChanged(object sender, EventArgs e)
        {
            if (useridtbx.Text == "")
            {
                setbot.Enabled = false;
            }
            else { setbot.Enabled = true; }
        }

        private void useridtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void datetxby_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar))
            {
                int number;
                if (int.TryParse(datetxby.Text + e.KeyChar, out number))
                {
                    if (number < 1 || number > 3000)
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        private void datetxbm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar))
            {
                int number;
                if (int.TryParse(datetxbm.Text + e.KeyChar, out number))
                {
                    if (number < 1 || number > 12)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void datetxbd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar))
            {
                int number;
                if (int.TryParse(datetxbd.Text + e.KeyChar, out number))
                {
                    if (number < 1 || number > 31)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void amounttxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tractimetxbH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tractimetxbM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tracCodetxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void userID_Click(object sender, EventArgs e)
        {

        }

        private void typePay_Click(object sender, EventArgs e)
        {

        }

        private void amount_Click(object sender, EventArgs e)
        {

        }

        private void amounttxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void hourupdown_ValueChanged(object sender, EventArgs e)
        {
            if (hourupdown.Value < 0)
            {
                hourupdown.Value = 23;
            }
            else if (hourupdown.Value >= 24)
            {
                hourupdown.Value = 0;
            }
        }

        private void minupdown_ValueChanged(object sender, EventArgs e)
        {
            if (minupdown.Value < 0)
            {
                minupdown.Value = 59;
            }
            else if (minupdown.Value >= 60)
            {
                minupdown.Value = 0;
            }
        }

        private void setbot_Click(object sender, EventArgs e)
        {
            DBC dpay = new DBC();
            if (dpay.id_check(useridtbx.Text) == true)
            {

                if (useridtbx.Text != "" && datetxby.Text != "" && datetxbm.Text != "" && datetxbd.Text != "" && termCobox.Text != "" && amounttxb.Text != ""
                       && tracTypeCbox.Text != "" &&
                      tracCodetxb.Text != "")
                {
                    Payment p1 = new Payment();

                    p1.userid = Convert.ToInt64(useridtbx.Text);
                    DateTime date = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    p1.dateofpayment = date;
                    if (termCobox.SelectedIndex == 0)
                    {
                        p1.term = 1;
                    }
                    else if (termCobox.SelectedIndex == 1)
                    {
                        p1.term = 2;
                    }
                    else if (termCobox.SelectedIndex == 2)
                    {
                        p1.term = 3;
                    }
                    else if (termCobox.SelectedIndex == 3)
                    {
                        p1.term = 4;
                    }

                    p1.amount = Convert.ToInt64(amounttxb.Text);
                    p1.accountbalance = dpay.acc_bl_reader(useridtbx.Text);
                    if (tracTypeCbox.SelectedIndex == 0)
                    {
                        p1.transactionstatus = false;
                        p1.accountbalance = p1.accountbalance - p1.amount;
                    }
                    else if (tracTypeCbox.SelectedIndex == 1)
                    {
                        p1.transactionstatus = true;
                        p1.accountbalance = p1.accountbalance + p1.amount;
                    }
                    TimeSpan time = new TimeSpan(Convert.ToInt16(hourupdown.Value), Convert.ToInt16(minupdown.Value), 0);
                    p1.tarckingtime = time;
                    p1.trackingcode = Convert.ToInt64(tracCodetxb.Text);
                    p1.description = statustxb.Text;
                    string result = "";
                    if (tracTypeCbox.SelectedIndex == 0)
                    {
                        result = dpay.pay_set(p1);
                    }
                    else
                    {
                        result = dpay.pay_set(p1, "-");
                    }
                    if (result.Length > 0)
                    {
                        MessageBox.Show("پرداخت با موفقیت انجام شد.");

                        clear_textbox(useridtbx);
                        clear_textbox(datetxby);
                        clear_textbox(datetxbm);
                        clear_textbox(datetxbd);
                        clear_textbox(amounttxb);
                        hourupdown.Value = 0;
                        minupdown.Value = 0;
                        clear_textbox(tracCodetxb);
                        clear_textbox(statustxb);
                        termCobox.Text = string.Empty;
                        tracTypeCbox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("پرداخت نا موفق بود.");
                    }



                }
                else
                {
                    MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                }

            }
            else
            {
                MessageBox.Show("کد ملی موجود نیست!!!");
            }

        }
    }
}
