using Amozesh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private void ReduceSaturation(PictureBox b1, float f1, int i1)
        {
            Image iconImage;

            if (i1 == 1)
            {
                iconImage = Properties.Resources.id25;
            }
            else
            {
                iconImage = Properties.Resources.name25;
            }

            float saturation = f1; // مقدار اشباع (0 = سیاه و سفید، 1 = رنگ اصلی)
            float r = 0.3086f * (1 - saturation);
            float g = 0.6094f * (1 - saturation);
            float b = 0.0820f * (1 - saturation);

            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
            new float[] {r + saturation, r, r, 0, 0},
            new float[] {g, g + saturation, g, 0, 0},
            new float[] {b, b, b + saturation, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
            });


            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);


            Bitmap bmp = new Bitmap(iconImage.Width, iconImage.Height);

            using (Graphics g222 = Graphics.FromImage(bmp))
            {
                g222.DrawImage(iconImage, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, iconImage.Width, iconImage.Height, GraphicsUnit.Pixel, imageAttributes);
            }


            b1.Image = bmp;

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            ReduceSaturation(idpictureBox, 0f, 1);
            ReduceSaturation(namepictureBox, 0f, 0);

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DBC dcourse = new DBC();

            if (dcourse.teacherid_check(idlabel.Text) == true)
            {
                if (termcombobox.Text != "" && idlabel.Text != "" && courseNametxb.Text != "" && costtxb.Text != "" && datetxbd.Text != "" && datetxbm.Text != "" && datetxby.Text != "")
                {

                    Course c1 = new Course();

                    try
                    {
                        c1.teacherid = Convert.ToInt64(idlabel.Text);
                    }
                    catch
                    {
                        MessageBox.Show("کد ملی نا معتبر است.");
                    }
                    c1.coursename = courseNametxb.Text;
                    c1.cost = Convert.ToInt64(costtxb.Text);
                    DateTime date2 = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    c1.dateofstart = date2;
                    string hourupdowntxt;
                    string minupdowntxt;
                    if (hourUpDown.Value.ToString().Length == 1)
                    {
                        hourupdowntxt = "0" + hourUpDown.Value.ToString();
                    }
                    else
                    {
                        hourupdowntxt = hourUpDown.Value.ToString();
                    }
                    if (minUpDown.Value.ToString().Length == 1)
                    {
                        minupdowntxt = "0" + minUpDown.Value.ToString();
                    }
                    else
                    {
                        minupdowntxt = minUpDown.Value.ToString();
                    }
                    string id = datetxby.Text.Substring(2, 2) + (termcombobox.SelectedIndex + 1).ToString() + ((uint)date2.DayOfWeek + 1).ToString() + hourupdowntxt + minupdowntxt;
                    c1.courseid = id;
                    if (dcourse.courseid_check(id) == false)
                    {
                        string s = dcourse.course_set(c1);

                        List<DateTime> l1 = dcourse.data_course_creator(date2, Convert.ToInt32(numberofcoursebox.Text));
                        foreach (DateTime dt in l1)
                        {
                            Course_holding c2 = new Course_holding();
                            c2.courseid = id;
                            c2.dateOfsection = dt;
                            c2.teacherid = c1.teacherid = Convert.ToInt64(idlabel.Text);
                            c2.holding_state = true;
                            dcourse.course_holding_set(c2);
                        }
                        if (s == "1")
                        {
                            MessageBox.Show($"کلاس با کد {id} ثبت شد.");
                            dcourse.clear_textbox(teacherIDtxb);
                            dcourse.clear_textbox(datetxby);
                            dcourse.clear_textbox(datetxbm);
                            dcourse.clear_textbox(datetxbd);
                            dcourse.clear_textbox(costtxb);
                            dcourse.clear_textbox(courseNametxb);
                            dcourse.clear_textbox(numberofcoursebox);
                            idlabel.Text = string.Empty;
                            namelabel.Text = string.Empty;
                            ReduceSaturation(idpictureBox, 0f, 1);
                            ReduceSaturation(namepictureBox, 0f, 0);
                            termcombobox.SelectedIndex = -1;
                            hourUpDown.Value = 0;
                            minUpDown.Value = 0;
                            teacherIDtxb.Focus();
                        }
                        else
                        {
                            MessageBox.Show("ثبت انجام نشد!!!");
                        }
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

            if (teacherIDtxb.Text.Length > 10)
            {
                idlabel.Text = teacherIDtxb.Text.Substring(0, 10);
                namelabel.Text = teacherIDtxb.Text.Substring(11);
                teacherIDtxb.Text = string.Empty;
                idlabel.Visible = true;
                namelabel.Visible = true;
                idpictureBox.Visible = true;
                namepictureBox.Visible = true;
                ReduceSaturation(idpictureBox, 1f, 1);
                ReduceSaturation(namepictureBox, 1f, 0);
            }


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

        private void numberofcoursebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberofcoursebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void idlabel_TextChanged(object sender, EventArgs e)
        {
            if(idlabel.Text.Length == 10)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }
        }
    }
}