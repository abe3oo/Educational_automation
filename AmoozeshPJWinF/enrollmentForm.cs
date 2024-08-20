using Amozesh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoozeshPJWinF
{
    public partial class enrollmentForm : Form
    {
        DBC denrollment = new DBC();
        List<string> personresult = new List<string>();
        List<string> courseresult = new List<string>();
        public enrollmentForm()
        {
            InitializeComponent();
        }

        private void WAgptxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReduceSaturation(PictureBox b1, float f1, int i1)
        {
            Image iconImage;

            if (i1 == 0)
            {
                iconImage = Properties.Resources.id25;
            }
            else if (i1 == 1)
            {
                iconImage = Properties.Resources.name25;
            }
            else if (i1 == 2)
            {
                iconImage = Properties.Resources.class25;
            }
            else
            {
                iconImage = Properties.Resources.barcode25;
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
        public string ExtractNumber(string input, int numberLength)
        {

            string pattern = @"\d{" + numberLength + @"}";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        public string Extractname(string input)
        {

            string pattern = @"\d*\s*([\u0600-\u06FFa-zA-Z\s]+)\s*\d*";
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {

                for (int i = 1; i < match.Groups.Count; i++)
                {
                    if (match.Groups[i].Success)
                    {
                        return match.Groups[i].Value;
                    }
                }
            }

            return "خالی";
        }
        private void courseIDtxb_TextChanged(object sender, EventArgs e)
        {
            if (courseIDtxb.AutoCompleteCustomSource.Contains(courseIDtxb.Text))
            {
                classidlbl.Text = ExtractNumber(courseIDtxb.Text, 8);
                classnamelbl.Text = Extractname(courseIDtxb.Text);
                courseIDtxb.Text = string.Empty;
                ReduceSaturation(classnamepictureBox, 1f, 2);
                ReduceSaturation(classidpictureBox, 1f, 3);
                classnamelbl.Visible = true;
                classidlbl.Visible = true;

                studentIDtxb.Focus();
            }
        }

        private void studentIDtxb_TextChanged(object sender, EventArgs e)
        {

            if (studentIDtxb.AutoCompleteCustomSource.Contains(studentIDtxb.Text))
            {
                studentidlbl.Text = ExtractNumber(studentIDtxb.Text, 10);
                studentnamelbl.Text = Extractname(studentIDtxb.Text);
                studentIDtxb.Text = string.Empty;
                ReduceSaturation(studentnamepictureBox, 1f, 1);
                ReduceSaturation(studentidpictureBox, 1f, 0);
                studentidlbl.Visible = true;
                studentnamelbl.Visible = true;

            }
        }

        private void courseIDtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void studentIDtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
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


            if ((denrollment.courseid_check(classidlbl.Text) == true) && (denrollment.studentid_check(studentidlbl.Text) == true))
            {
                if (classidlbl.Text != "" && studentidlbl.Text != "" && WAgptxb.Text != "" && datetxbd.Text != "" && datetxbm.Text != "" && datetxby.Text != "")
                {
                    Enrollment e1 = new Enrollment();

                    e1.courseid = classidlbl.Text;
                    e1.studentid = Convert.ToInt64(studentidlbl.Text);
                    e1.whatsappgp = WAgptxb.Text;
                    DateTime date3 = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    e1.dateofenrollment = date3;
                    string g1;
                    g1 = denrollment.enrollment_set(e1);
                    if (g1 == "11")
                    {
                        MessageBox.Show("ثبت با موفقیت انجام شد");

                        classidlbl.Text = "خالی";
                        studentidlbl.Text = "خالی";
                        classidlbl.Visible = false;
                        studentidlbl.Visible = false ;
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

        private void enrollmentForm_Load(object sender, EventArgs e)
        {
            studentIDtxb.Focus();
            //reduce saturation
            ReduceSaturation(studentnamepictureBox, 0.2f, 1);
            ReduceSaturation(studentidpictureBox, 0.2f, 0);
            ReduceSaturation(classnamepictureBox, 0.2f, 2);
            ReduceSaturation(classidpictureBox, 0.2f, 3);

            //course_suj
            courseIDtxb.AutoCompleteCustomSource = null;
            List<showcourse> s1 = new List<showcourse>();
            s1 = denrollment.show_all_courseid_name();
            foreach (showcourse s in s1)
            {
                string res1 = s.courseid + " " + s.coursename;
                string res2 = s.coursename + " " + s.courseid;
                courseresult.Add(res1);
                courseresult.Add(res2);
            }
            courseIDtxb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            courseIDtxb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection te = new AutoCompleteStringCollection();
            te.AddRange(courseresult.ToArray());
            courseIDtxb.AutoCompleteCustomSource = te;
            //student_suj
            studentIDtxb.AutoCompleteCustomSource = null;
            personresult = denrollment.get_all_students();


            studentIDtxb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentIDtxb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection tee = new AutoCompleteStringCollection();
            tee.AddRange(personresult.ToArray());
            studentIDtxb.AutoCompleteCustomSource = tee;
            studentIDtxb.Focus();
        }

        private void datetxby_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentidlbl_Click(object sender, EventArgs e)
        {

        }

        private void studentidlbl_TextChanged(object sender, EventArgs e)
        {
            if (studentidlbl.Text.Length == 10 && classidlbl.Text.Length == 8)
            {
                setbot.Enabled = true;

            }
            else
            {
                setbot.Enabled = false;
            }
        }

        private void classidlbl_TextChanged(object sender, EventArgs e)
        {
            if (studentidlbl.Text.Length == 10 && classidlbl.Text.Length == 8)
            {
                setbot.Enabled = true;

            }
            else
            {
                setbot.Enabled = false;
            }
        }
    }
}
