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

namespace AmoozeshPJWinF
{
    public partial class showForm : Form
    {
        List<string> result = new List<string>();
        DBC d1 = new DBC();
        public showForm()
        {
            InitializeComponent();
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
                result = d1.get_all_users();
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection te = new AutoCompleteStringCollection();
                te.AddRange(result.ToArray());
                textBox1.AutoCompleteCustomSource = te;
            }
        }

        private void checkbot_Click(object sender, EventArgs e)
        {

        }

        private void showbot_Click(object sender, EventArgs e)
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
                result = d1.get_all_users();
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection te = new AutoCompleteStringCollection();
                te.AddRange(result.ToArray());
                textBox1.AutoCompleteCustomSource = te;
            }
        }
    }
}
