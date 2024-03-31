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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        public void clear_textbox(TextBox t1)
        {
            t1.Text = string.Empty;
        }
        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DBC dcourse = new DBC();

            if (dcourse.teacherid_check(teacherIDtxb.Text) == true)
            {
                if (courseIDtxb.Text != "" && teacherIDtxb.Text != "" && courseNametxb.Text != "" && costtxb.Text != "" && datetxby.Text != "")
                {
                    Course c1 = new Course();

                    c1.courseid = Convert.ToInt64(courseIDtxb.Text);
                    c1.teacherid = Convert.ToInt64(teacherIDtxb.Text);
                    c1.coursename = courseNametxb.Text;
                    c1.cost = Convert.ToInt64(costtxb.Text);
                    DateTime date2 = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    c1.dateofstart = date2;

                    dcourse.course_set(c1);

                    MessageBox.Show("ثبت با موفقیت انجام شد");

                    clear_textbox(courseIDtxb);
                    clear_textbox(teacherIDtxb);
                    clear_textbox(datetxby);
                    clear_textbox(datetxbm);
                    clear_textbox(datetxbd);
                    clear_textbox(costtxb);
                    clear_textbox(courseNametxb);

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

        private void courseIDtxb_TextChanged(object sender, EventArgs e)
        {
            if (courseIDtxb.Text == "")
            {
                acceptButton.Enabled = false;
            }
            else
            { acceptButton.Enabled = true; }
        }

        private void teacherIDtxb_TextChanged(object sender, EventArgs e)
        {
            if (teacherIDtxb.Text == "")
            {
                acceptButton.Enabled = false;
            }
            else
            { acceptButton.Enabled = true; }
        }

        private void costtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetxby_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetxbm_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetxbd_TextChanged(object sender, EventArgs e)
        {
        }

        private void courseIDtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teacherIDtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void costtxb_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void datetxbm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void datetxbd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}