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

        public void loadData()
        {
            DataTable dt = d1.get_nonzero_balance();
            balancelistview.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["firstname"].ToString());
                item.SubItems.Add(row["lastname"].ToString());
                item.SubItems.Add(row["account_balance"].ToString());
                balancelistview.Items.Add(item);

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void showForm_Load(object sender, EventArgs e)
        {

        }

        private void userradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userradioButton.Checked == true)
            {
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

        private void showbot_Click(object sender, EventArgs e)
        {
            if (userradioButton.Checked == true)
            {

                if (d1.id_check(textBox1.Text) == true)
                {
                    if (d1.teacherid_check(textBox1.Text) == false)
                    {
                        groupBoxsame.Visible = true;
                        groupBoxSt.Visible = true;
                        groupBoxTch.Visible = false;
                        GetStudent s1 = new GetStudent();
                        s1 = d1.St_Reader(textBox1.Text);
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
                        wanumberlblshow.Text = s1.whatsappnumber.ToString();
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
                    }
                    else
                    {
                        groupBoxsame.Visible = true;
                        groupBoxSt.Visible = false;
                        groupBoxTch.Visible = true;
                        GetTeacher s1 = new GetTeacher();
                        s1 = d1.Pr_Reader(textBox1.Text);
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

                    }
                }
            }
            else if (classradioButton.Checked == true)
            {
                string thisid = ExtractNumber(textBox1.Text, 8);
                if (d1.courseid_check(thisid) == true)
                {
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
                }
                else
                {
                    MessageBox.Show("آی دی کلاس نا معتبر است.");
                }
            }
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
            if (balanceradiobot.Checked == true)
            {
                showbalancebot.Visible = true;
            }
            else
            {
                showbalancebot.Visible = false;
            }
        }

        private void showbalancebot_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
