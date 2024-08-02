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
    public partial class enrollmentForm : Form
    {
        public enrollmentForm()
        {
            InitializeComponent();
        }

        private void WAgptxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseIDtxb_TextChanged(object sender, EventArgs e)
        {
            if (studentIDtxb.Text == "")
            {
                setbot.Enabled = false;
            }
            else
            {
                setbot.Enabled = true;
            }
        }

        private void studentIDtxb_TextChanged(object sender, EventArgs e)
        {

            if (studentIDtxb.Text == "")
            {
                setbot.Enabled = false;
            }
            else
            {
                setbot.Enabled = true;
            }
        }

        private void courseIDtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void studentIDtxb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void setbot_Click(object sender, EventArgs e)
        {
            DBC denrollment = new DBC();

            if ((denrollment.courseid_check(courseIDtxb.Text) == true) && (denrollment.studentid_check(studentIDtxb.Text) == true))
            {
                if (courseIDtxb.Text != "" && studentIDtxb.Text != "" && WAgptxb.Text != "" && datetxbd.Text != "" && datetxbm.Text != "" && datetxby.Text != "")
                {
                    Enrollment e1 = new Enrollment();

                    e1.courseid = Convert.ToInt64(courseIDtxb.Text);
                    e1.studentid = Convert.ToInt64(studentIDtxb.Text);
                    e1.whatsappgp = WAgptxb.Text;
                    DateTime date3 = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    e1.dateofenrollment = date3;
                    string g1;
                    g1 = denrollment.enrollment_set(e1);
                    if (g1 == "1")
                    {
                        MessageBox.Show("ثبت با موفقیت انجام شد");

                        clear_textbox(courseIDtxb);
                        clear_textbox(studentIDtxb);
                        clear_textbox(datetxby);
                        clear_textbox(datetxbm);
                        clear_textbox(datetxbd);
                        clear_textbox(WAgptxb);
                    }
                    else
                    {
                        MessageBox.Show("ثبت انجام نشد.");
                    }


                }
                else
                {
                    MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                }
            }
            else
            {
                MessageBox.Show("کد ملی یا کد درس موجود نیست!!!");
            }
        }
    }
}
