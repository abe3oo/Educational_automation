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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmoozeshPJWinF
{
    public partial class AddCourseForm : Form
    {
        DBC d1 = new DBC();
        List<GetTeacher> result = new List<GetTeacher>();
        List<string> course_string = new List<string>() { "amir", "ammar", "ali", "reza", "sara" };
        public AddCourseForm()
        {
            InitializeComponent();
            result = d1.All_teacher_reader();
            foreach (GetTeacher t in result)
            {
                string str = "";
                str = (t.personalcode + " " + t.firstname + " " + t.lastname);
                course_string.Add(str);
            }

            teacherIDtxb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            teacherIDtxb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection te = new AutoCompleteStringCollection();
            te.AddRange(course_string.ToArray());
            teacherIDtxb.AutoCompleteCustomSource = te;
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DBC dcourse = new DBC();

            if (dcourse.teacherid_check(teacherIDtxb.Text.Substring(0,10)) == true)
            {
                if (termcombobox.Text != "" && teacherIDtxb.Text != "" && courseNametxb.Text != "" && costtxb.Text != "" && datetxbd.Text != "" && datetxbm.Text != "" && datetxby.Text != "")
                {

                    Course c1 = new Course();

                    try
                    {
                        c1.teacherid = Convert.ToInt64(teacherIDtxb.Text.Substring(0, 10));
                    }
                    catch
                    {
                        MessageBox.Show("کد ملی نا معتبر  است.");
                    }
                    c1.coursename = courseNametxb.Text;
                    c1.cost = Convert.ToInt64(costtxb.Text);
                    DateTime date2 = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    c1.dateofstart = date2;
                    string id = datetxby.Text.Substring(2, 2) + (termcombobox.SelectedIndex + 1).ToString() + ((uint)date2.DayOfWeek + 2).ToString() + hourUpDown.Value.ToString() + minUpDown.Value.ToString();
                    c1.courseid = id;
                    if (dcourse.courseid_check(id) == false)
                    {
                        dcourse.course_set(c1);

                        MessageBox.Show($"کلاس با کد {id} ثبت شد.");


                        dcourse.clear_textbox(teacherIDtxb);
                        dcourse.clear_textbox(datetxby);
                        dcourse.clear_textbox(datetxbm);
                        dcourse.clear_textbox(datetxbd);
                        dcourse.clear_textbox(costtxb);
                        dcourse.clear_textbox(courseNametxb);
                        termcombobox.SelectedValue = -1;
                        hourUpDown.Value = 0;
                        minUpDown.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show($"این کلاس با کد {id} قبلا ثبت شده!");
                    }


                }
                else
                {
                    MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                }
            }
            else
            {
                MessageBox.Show("کد ملی استاد موجود نیست!!!");
            }

        }

        private void courseIDtxb_TextChanged(object sender, EventArgs e)
        {

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

        private void minUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (minUpDown.Value < 0)
            {
                minUpDown.Value = 45;
            }
            else if (minUpDown.Value >= 60)
            {
                minUpDown.Value = 0;
            }
        }

        private void hourUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (hourUpDown.Value < 0)
            {
                hourUpDown.Value = 23;
            }
            else if (hourUpDown.Value >= 24)
            {
                hourUpDown.Value = 0;
            }
        }

        
    }
}