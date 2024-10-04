using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace AmoozeshPJWinF
{
    public partial class showForm : Form
    {
        List<string> personresult = new List<string>();
        List<string> courseresult = new List<string>();
        DBC d1 = new DBC();
        public showForm()
        {
            InitializeComponent();
        }

        private void show()
        {
            if (textBox1.AutoCompleteCustomSource.Contains(textBox1.Text))
            {
                if (userradioButton.Checked == true)
                {
                    string thisid = ExtractNumber(textBox1.Text, 10);
                    if (d1.id_check(thisid) == true)
                    {
                        if (d1.teacherid_check(thisid) == false)
                        {
                            panelsame.Visible = true;
                            panelSt.Visible = true;
                            panelTch.Visible = false;
                            GetStudent s1 = new GetStudent();
                            s1 = d1.St_Reader(thisid);
                            idlblshow.Text = s1.personalcode;
                            typelblshow.Text = "دانشجو";
                            fnamelblshow.Text = s1.firstname;
                            lnamelblshow.Text = s1.lastname;
                            agelblshow.Text = s1.age.ToString();
                            numberlblshow.Text = s1.number.ToString();
                            if (s1.number != s1.whatsappnumber)
                            {
                                wanumberlblshow.Text = s1.whatsappnumber.ToString();
                            }
                            else
                            {
                                wanumberlblshow.Text = "ندارد";
                            }
                            fieldlblshow.Text = s1.fieled_of_study;
                            eductionlblshow.Text = s1.education.ToString();
                            educationlabel.Text = "سطح تحصیلات :";
                            if (s1.education == 0)
                            {
                                eductionlblshow.Text = "دانش آموز";
                            }
                            else if (s1.education == 1)
                            {
                                eductionlblshow.Text = "سیکل";
                            }
                            else if (s1.education == 2)
                            {
                                eductionlblshow.Text = "دیپلم";
                            }
                            else if (s1.education == 3)
                            {
                                eductionlblshow.Text = "فوق دیپلم";
                            }
                            else if (s1.education == 4)
                            {
                                eductionlblshow.Text = "لیسانس";
                            }
                            else if (s1.education == 5)
                            {
                                eductionlblshow.Text = "فوق لیسانس";
                            }
                            else if (s1.education == 6)
                            {
                                eductionlblshow.Text = "دکترا";
                            }
                            if (s1.maritalstatus == false)
                            {
                                maritalstatuslblshow.Text = "مجرد";
                            }
                            else if (s1.maritalstatus == true)
                            {
                                maritalstatuslblshow.Text = "متاهل";
                            }
                            citylblshow.Text = s1.city;
                            joblblshow.Text = s1.job;
                            if (s1.classtype == true)
                            {
                                classtypelblshow.Text = "حضوری";
                            }
                            else if (s1.classtype == false)
                            {
                                classtypelblshow.Text = "مجازی";
                            }
                            if (s1.account_balance > 0)
                            {
                                peymentstlbl.Text = "بستانکار :";
                                peymentstlblshow.Text = Math.Abs(Convert.ToDecimal(s1.account_balance)).ToString();

                            }
                            else if (s1.account_balance < 0)
                            {
                                peymentstlbl.Text = "بدهکار :";
                                peymentstlblshow.Text = Math.Abs(Convert.ToDecimal(s1.account_balance)).ToString();
                            }
                            else
                            {
                                peymentstlbl.Text = "پرداختی :";
                                peymentstlblshow.Text = "0";
                            }
                            pictureBox1.Image = d1.pic_reader(s1.personalcode);
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            panelsame.Visible = true;
                            panelSt.Visible = false;
                            panelTch.Visible = true;
                            GetTeacher s1 = new GetTeacher();
                            s1 = d1.Pr_Reader(thisid);
                            idlblshow.Text = s1.personalcode;
                            typelblshow.Text = "استاد";
                            fnamelblshow.Text = s1.firstname;
                            lnamelblshow.Text = s1.lastname;
                            agelblshow.Text = s1.age.ToString();
                            numberlblshow.Text = s1.number.ToString();
                            if (s1.number != s1.whatsappnumber)
                            {
                                wanumberlblshow.Text = s1.whatsappnumber.ToString();
                            }
                            wanumberlblshow.Text = s1.whatsappnumber.ToString();
                            fieldlblshow.Text = s1.fieled_of_study;
                            educationlabel.Text = "مدرک تحصیلی :";
                            if (s1.degree_of_education == 0)
                            {
                                eductionlblshow.Text = "دانش آموز";
                            }
                            else if (s1.degree_of_education == 1)
                            {
                                eductionlblshow.Text = "سیکل";
                            }
                            else if (s1.degree_of_education == 2)
                            {
                                eductionlblshow.Text = "دیپلم";
                            }
                            else if (s1.degree_of_education == 3)
                            {
                                eductionlblshow.Text = "فوق دیپلم";
                            }
                            else if (s1.degree_of_education == 4)
                            {
                                eductionlblshow.Text = "لیسانس";
                            }
                            else if (s1.degree_of_education == 5)
                            {
                                eductionlblshow.Text = "فوق لیسانس";
                            }
                            else if (s1.degree_of_education == 6)
                            {
                                eductionlblshow.Text = "دکترا";
                            }
                            Presencerecordlblshow.Text = s1.presence_record.ToString();
                            string strdate = s1.date_of_entry.Year.ToString() + "/" + s1.date_of_entry.Month.ToString() + "/" + s1.date_of_entry.Day.ToString();
                            entrylblshow.Text = strdate;
                            pictureBox1.Image = d1.pic_reader(s1.personalcode);
                            if (s1.account_balance > 0)
                            {
                                peymentlbl.Text = "بستانکار :";
                                peymentlblshow.Text = Math.Abs(Convert.ToDecimal(s1.account_balance)).ToString();

                            }
                            else if (s1.account_balance < 0)
                            {
                                peymentlbl.Text = "بدهکار :";
                                peymentlblshow.Text = Math.Abs(Convert.ToDecimal(s1.account_balance)).ToString();
                            }
                            else
                            {
                                peymentlbl.Text = "پرداختی :";
                                peymentlblshow.Text = "0";
                            }
                            textBox1.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("کد ملی نا معتبر!");
                    }
                }
                else if (classradioButton.Checked == true)
                {
                    string thisid = ExtractNumber(textBox1.Text, 8);
                    if (d1.courseid_check(thisid) == true)
                    {
                        classpanel.Visible = true;
                        showcourse c = new showcourse();
                        c = d1.show_course(thisid);
                        course_namelblshow.Text = c.coursename;
                        teachernamelblshow.Text = c.teachername;
                        teacheridlblshow.Text = c.teacherid.ToString();
                        termlblshow.Text = c.term;
                        string strdate = c.start_date.Year.ToString() + "/" + c.start_date.Month.ToString() + "/" + c.start_date.Day.ToString();
                        dateofstartlblshow.Text = strdate;
                        costlblshow.Text = c.cost.ToString();
                        clocklblshow.Text = c.clock;
                        textBox1.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("آی دی کلاس نا معتبر است.");
                    }
                }
            }
        }
        private void ReduceSaturationforbot(System.Windows.Forms.Button b1, float f1, int i1)
        {
            Image iconImage;

            if (i1 == 0)
            {
                iconImage = Properties.Resources.teachercolor;
            }
            else if (i1 == 1)
            {
                iconImage = Properties.Resources.classroom40;
            }
            else if (i1 == 2)
            {
                iconImage = Properties.Resources.money40;
            }
            else if (i1 == 3)
            {
                iconImage = Properties.Resources.bede25;
            }
            else
            {
                iconImage = Properties.Resources.besta25;
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
        public void loadData()
        {
            DataTable dt = d1.get_nonzero_balance();
            balancelistview.Items.Clear();
            if (filterbalancecombo.SelectedIndex == 2)
            {

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["firstname"].ToString());
                    item.SubItems.Add(row["lastname"].ToString());
                    item.SubItems.Add(row["account_balance"].ToString());
                    balancelistview.Items.Add(item);

                }
            }
            else if (filterbalancecombo.SelectedIndex == 0)
            {
                sumtxtlbl.Text = "مجموع بدهی ها :";
                sumnumberlbl.Text = "0";
                if (balancelistview.Columns.Count > 0)
                {
                    ColumnHeader columnHeader = balancelistview.Columns[3];
                    columnHeader.Text = "بدهکاری";

                }
                long sum = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt64(row["account_balance"]) < 0)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["firstname"].ToString());
                        item.SubItems.Add(row["lastname"].ToString());
                        item.SubItems.Add(Math.Abs(Convert.ToInt32(row["account_balance"])).ToString());

                        balancelistview.Items.Add(item);
                        sum = sum + Math.Abs(Convert.ToInt64(row["account_balance"]));


                        sumnumberlbl.Text = sum.ToString();
                    }


                }
            }
            else if (filterbalancecombo.SelectedIndex == 1)
            {
                sumtxtlbl.Text = "مجموع بستانکاری ها :";
                sumnumberlbl.Text = "0";
                if (balancelistview.Columns.Count > 0)
                {
                    ColumnHeader columnHeader = balancelistview.Columns[3];
                    columnHeader.Text = "بستانکاری";

                }
                long sum = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt64(row["account_balance"]) > 0)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["firstname"].ToString());
                        item.SubItems.Add(row["lastname"].ToString());

                        item.SubItems.Add(row["account_balance"].ToString());
                        balancelistview.Items.Add(item);

                        sum = sum + Convert.ToInt64(row["account_balance"]);

                        sumnumberlbl.Text = sum.ToString();
                    }
                }
            }


        }

        public void hide_all()
        {
            balancepanel.Visible = false;
            panelsame.Visible = false;
            classpanel.Visible = false;
            textBox1.Text = string.Empty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void showForm_Load(object sender, EventArgs e)
        {
            ReduceSaturationforbot(userbot, 0.2f, 0);
            ReduceSaturationforbot(classbot, 0.2f, 1);
            ReduceSaturationforbot(balancebot, 0.2f, 2);
        }

        private void userradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userradioButton.Checked == true)
            {
                hide_all();
                textBox1.AutoCompleteCustomSource = null;
                personresult = d1.get_all_users();
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection te = new AutoCompleteStringCollection();
                te.AddRange(personresult.ToArray());
                textBox1.AutoCompleteCustomSource = te;
            }
        }

        private void checkbot_Click(object sender, EventArgs e)
        {

        }



        private void savepicturebot_Click(object sender, EventArgs e)
        {
            d1.SaveImage(pictureBox1.Image, idlblshow.Text);
        }

        private void idlblshow_TextChanged(object sender, EventArgs e)
        {
            if (idlblshow.Text.Length == 10)
            {
                savepicturebot.Enabled = true;
            }
        }

        private void classradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (classradioButton.Checked == true)
            {
                hide_all();
                textBox1.AutoCompleteCustomSource = null;
                List<showcourse> s1 = new List<showcourse>();
                s1 = d1.show_all_courseid_name();
                foreach (showcourse s in s1)
                {
                    string res1 = s.courseid + " " + s.coursename;
                    string res2 = s.coursename + " " + s.courseid;
                    courseresult.Add(res1);
                    courseresult.Add(res2);
                }
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection te = new AutoCompleteStringCollection();
                te.AddRange(courseresult.ToArray());
                textBox1.AutoCompleteCustomSource = te;
            }
        }

        private void balanceradiobot_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void balancelistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userbot_Click(object sender, EventArgs e)
        {
            ReduceSaturationforbot(userbot, 1f, 0);
            ReduceSaturationforbot(classbot, 0.2f, 1);
            ReduceSaturationforbot(balancebot, 0.2f, 2);
            ReduceSaturationforbot(bedebot, 0.2f, 3);
            ReduceSaturationforbot(bestabot, 0.2f, 4);
            userradioButton.Checked = true;
            panelcolorselect.Visible = true;
            panelcolorselect.Width = userbot.Width;
            panelcolorselect.Left = userbot.Left;
            textBox1.Enabled = true;
            searchlabel.Visible = true;
            bedebot.Visible = false;

            bestabot.Visible = false;
        }

        private void classbot_Click(object sender, EventArgs e)
        {
            ReduceSaturationforbot(userbot, 0.2f, 0);
            ReduceSaturationforbot(classbot, 1f, 1);
            ReduceSaturationforbot(balancebot, 0.2f, 2);
            ReduceSaturationforbot(bedebot, 0.2f, 3);
            ReduceSaturationforbot(bestabot, 0.2f, 4);
            classradioButton.Checked = true;
            panelcolorselect.Visible = true;
            panelcolorselect.Width = classbot.Width;
            panelcolorselect.Left = classbot.Left;
            textBox1.Enabled = true;
            searchlabel.Visible = true;
            bedebot.Visible = false;

            bestabot.Visible = false;
        }

        private void balancebot_Click(object sender, EventArgs e)
        {
            hide_all();
            ReduceSaturationforbot(userbot, 0.2f, 0);
            ReduceSaturationforbot(classbot, 0.2f, 1);
            ReduceSaturationforbot(balancebot, 1f, 2);
            ReduceSaturationforbot(bedebot, 0.2f, 3);
            ReduceSaturationforbot(bestabot, 0.2f, 4);
            balanceradiobot.Checked = true;
            panelcolorselect.Visible = true;
            panelcolorselect.Width = balancebot.Width;
            panelcolorselect.Left = balancebot.Left;
            textBox1.Enabled = false;
            searchlabel.Visible = false;
            bedebot.Visible = true;

            bestabot.Visible = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                show();
            }
        }

        private void bedebot_Click(object sender, EventArgs e)
        {

            ReduceSaturationforbot(bedebot, 1f, 3);
            ReduceSaturationforbot(bestabot, 0.2f, 4);
            filterbalancecombo.SelectedIndex = 0;
            balancepanel.Visible = true;
            loadData();
        }

        private void bestabot_Click(object sender, EventArgs e)
        {

            ReduceSaturationforbot(bedebot, 0.2f, 3);
            ReduceSaturationforbot(bestabot, 1f, 4);
            filterbalancecombo.SelectedIndex = 1;
            balancepanel.Visible = true;
            loadData();
        }

        private void filterbalancecombo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void sumnumberlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
