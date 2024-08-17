using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AmoozeshPJWinF
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = null;
        public List<Button> buttons1;
        DateTime click_date;
        DBC dbc = new DBC();
        public Form1()
        {
            InitializeComponent();
            StartTimer();
            buttons1 = new List<Button>() {day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
            day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26, day27, day28, day29, day30, day31};
        }

        public void get_classes(DateTime date)
        {
            List<string> idtoday = dbc.Course_holding_id_Reader_by_date(date);
            List<GetCourse> coursetoday = new List<GetCourse>();
            foreach (string id in idtoday)
            {
                coursetoday.Add(dbc.GetCourse_Reader_by_id(id, click_date));
            }
            if (coursetoday.Count > 0)
            {
                todayclasslabel.Text = "";
                coursetodayGridView.DataSource = coursetoday;
                button5.Enabled = true;
                classidcombo.Enabled = true;
                classidcombo.Items.Clear();
                button5.Enabled = true;

                foreach (GetCourse gid in coursetoday)
                {

                    classidcombo.Items.Add(gid.آی_دی_کلاس.ToString());
                }

            }
            else
            {
                todayclasslabel.Text = "امروز کلاسی ندارید.";
                coursetodayGridView.DataSource = null;
                button5.Enabled = false;
                button5.BackColor = Color.White;
                groupBox2.Visible = false;
            }
        }

        public void get_classes_for_bot(Button b1)
        {
            DateTime date = new DateTime(Convert.ToInt32(yearlabelcul.Text), Convert.ToInt32(monthlabelcul.Text), Convert.ToInt32(b1.Text));
            click_date = date;
            List<string> idtoday = dbc.Course_holding_id_Reader_by_date(date);
            List<GetCourse> coursetoday = new List<GetCourse>();
            foreach (string id in idtoday)
            {
                coursetoday.Add(dbc.GetCourse_Reader_by_id(id, date));
            }
            if (coursetoday.Count > 0)
            {
                todayclasslabel.Text = "";
                coursetodayGridView.DataSource = coursetoday;
                classidcombo.Enabled = true;
                classidcombo.Items.Clear();
                button5.Enabled = true;

                foreach (GetCourse gid in coursetoday)
                {

                    classidcombo.Items.Add(gid.آی_دی_کلاس.ToString());
                }
            }
            else
            {
                button5.Enabled = false;
                button5.BackColor = Color.White;
                groupBox2.Visible = false;
                todayclasslabel.Text = "امروز کلاسی ندارید.";
                coursetodayGridView.DataSource = null;
                classidcombo.Enabled = false;

            }
        }

        public void show_class_withbott(Button b1)
        {
            DateTime date = new DateTime(Convert.ToInt16(yearlabelcul.Text), Convert.ToInt16(monthlabelcul.Text), Convert.ToInt16(b1.Text));
            get_classes(date);
        }
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Enabled = true;
        }

        private void Adduser_Click(object sender, EventArgs e)
        {
            AddUserForm a1 = new AddUserForm();
            a1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payWindow n1 = new payWindow();
            n1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime d1 = DateTime.Now;

            string s1 = "clocklbl";
            yearlabelpr.Text = pc.GetYear(d1).ToString("0000");
            monthlabelpr.Text = pc.GetMonth(d1).ToString("00");
            daylabelpr.Text = pc.GetDayOfMonth(d1).ToString("00");
            clocklabel.Text = d1.Hour.ToString() + ":" + d1.Minute.ToString() + ":" + d1.Second.ToString();

            if (yearlabelcul.Text == "0000")
            {
                yearlabelcul.Text = yearlabelpr.Text;
                monthlabelcul.Text = monthlabelpr.Text;
            }
        }

        private void daylabelpr_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DateTime da = dbc.cul_converter(DateTime.Now);
            click_date = da;
            get_classes(da);
        }

        private void daylabelpr_TextChanged(object sender, EventArgs e)
        {

            foreach (Button b1 in buttons1)
            {
                if (daylabelpr.Text == b1.Text)
                {
                    b1.BackColor = Color.DeepSkyBlue;
                    yearlabelcul.Text = yearlabelpr.Text;
                    monthlabelcul.Text = monthlabelpr.Text;
                }
                else
                {
                    b1.BackColor = Color.White;
                }
            }
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            AddCourseForm c1 = new AddCourseForm();
            c1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthlabelcul_TextChanged(object sender, EventArgs e)
        {
            if (monthlabelcul.Text == "01" || monthlabelcul.Text == "02" || monthlabelcul.Text == "03" || monthlabelcul.Text == "04" || monthlabelcul.Text == "05" || monthlabelcul.Text == "06")
            {
                day31.Visible = true;
            }
            else
            {
                day31.Visible = false;
            }
            foreach (Button b1 in buttons1)
            {
                if (monthlabelpr.Text == monthlabelcul.Text && yearlabelpr.Text == yearlabelcul.Text)
                {
                    if (daylabelpr.Text == b1.Text)
                    {
                        b1.BackColor = Color.DeepSkyBlue;
                    }


                }
                else
                {
                    b1.BackColor = Color.White;
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(monthlabelcul.Text);
            int year = Convert.ToInt32(yearlabelcul.Text);
            string month2;

            month += 1;
            month2 = month.ToString();
            if (month > 12)
            {
                month = 1;
                year += 1;
                if (month >= 1 && month <= 9)
                {
                    month2 = "0" + month.ToString();
                }
                else
                {
                    month2 = month.ToString();
                }
                yearlabelcul.Text = year.ToString();
            }
            else if (month < 1)
            {
                month = 12;
                year -= 1;
                if (month >= 1 && month <= 9)
                {
                    month2 = "0" + month.ToString();
                }
                else
                {
                    month2 = month.ToString();
                }
                yearlabelcul.Text = year.ToString();
            }
            else
            {
                if (month >= 1 && month <= 9)
                {
                    month2 = "0" + month.ToString();
                }
                else
                {
                    month2 = month.ToString();
                }
            }

            monthlabelcul.Text = month2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(monthlabelcul.Text);
            int year = Convert.ToInt32(yearlabelcul.Text);
            string month2;

            month -= 1;
            month2 = month.ToString();
            if (month > 12)
            {
                month = 1;
                year += 1;
                if (month >= 1 && month <= 9)
                {
                    month2 = "0" + month.ToString();
                }
                else
                {
                    month2 = month.ToString();
                }
                yearlabelcul.Text = year.ToString();
            }
            else if (month < 1)
            {
                month = 12;
                year -= 1;
                if (month >= 1 && month <= 9)
                {
                    month2 = "0" + month.ToString();
                }
                else
                {
                    month2 = month.ToString();
                }
                yearlabelcul.Text = year.ToString();
            }
            else
            {
                if (month >= 1 && month <= 9)
                {
                    month2 = "0" + month.ToString();
                }
                else
                {
                    month2 = month.ToString();
                }
            }

            monthlabelcul.Text = month2;
        }

        private void todaybot_Click(object sender, EventArgs e)
        {
            monthlabelcul.Text = monthlabelpr.Text;
            yearlabelcul.Text = yearlabelpr.Text;
            foreach (Button b1 in buttons1)
            {
                if (daylabelpr.Text == b1.Text)
                {
                    b1.BackColor = Color.DeepSkyBlue;

                }
                else
                {
                    b1.BackColor = Color.White;
                }
            }
            get_classes(DateTime.Now);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enrollmentForm e1 = new enrollmentForm();
            e1.ShowDialog();
        }

        private void monthlabelpr_TextChanged(object sender, EventArgs e)
        {
            if (monthlabelpr.Text == "01" || monthlabelpr.Text == "02" || monthlabelpr.Text == "03" || monthlabelpr.Text == "04" || monthlabelpr.Text == "05" || monthlabelpr.Text == "06")
            {
                day31.Visible = true;
            }
            else
            {
                day31.Visible = false;
            }
        }

        private void day1_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day1);
        }

        private void day20_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day20);
        }

        private void day2_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day2);
        }

        private void day3_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day3);
        }

        private void day4_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day4);
        }

        private void day5_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day5);
        }

        private void day6_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day6);
        }

        private void day7_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day7);
        }

        private void day8_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day8);
        }

        private void day9_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day9);
        }

        private void day10_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day10);
        }

        private void day11_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day11);
        }

        private void day12_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day12);
        }

        private void day13_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day13);
        }

        private void day14_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day14);
        }

        private void day15_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day15);
        }

        private void day16_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day16);
        }

        private void day17_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day17);
        }

        private void day18_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day18);
        }

        private void day19_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day19);
        }

        private void day21_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day21);
        }

        private void day22_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day22);
        }

        private void day23_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day23);
        }

        private void day24_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day24);
        }

        private void day25_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day25);
        }

        private void day26_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day26);
        }

        private void day27_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day27);
        }

        private void day28_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day28);
        }

        private void day29_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day29);
        }

        private void day30_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day30);
        }

        private void day31_Click(object sender, EventArgs e)
        {
            get_classes_for_bot(day31);
        }

        private void showbot_Click(object sender, EventArgs e)
        {
            showForm s1 = new showForm();
            s1.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
                button5.BackColor = Color.AliceBlue;
            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                button5.BackColor = Color.White;
                classidcombo.SelectedIndex = -1;
            }
        }

        private void classidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classidcombo.SelectedIndex == -1)
            {
                truebot.Enabled = false;
                falsebot.Enabled = false;
            }
            else
            {
                truebot.Enabled = true;
                falsebot.Enabled = true;
            }


        }

        private void truebot_Click(object sender, EventArgs e)
        {

            bool thisstatus = dbc.check_course_holding_status(classidcombo.Text, click_date);

            if (thisstatus == false)
            {
                string s1 = dbc.course_holding_update(classidcombo.Text, click_date, true);
                if (s1 == "1")
                {
                    MessageBox.Show("تغییر وضعیت با موفقیت انجام شد.");
                    get_classes(click_date);
                }
                else
                {
                    MessageBox.Show("خطا در تغییر وضعیت.");
                }
            }
            else
            {
                MessageBox.Show("وضعیت کلاس (برگزار شده) است.");
            }
        }

        private void falsebot_Click(object sender, EventArgs e)
        {

            if (groupBox3.Visible == false)
            {
                groupBox3.Visible = true;
                falsebot.BackColor = Color.Red;
            }
            else
            {
                groupBox3.Visible = false;
                falsebot.BackColor = Color.White;
                yearremedical.Text = string.Empty;
                monthremedical.Text = string.Empty;
                dayremedical.Text = string.Empty;
                groupBox3.Visible = false;
            }

        }

        private void monthremedical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // بررسی اینکه ورودی عددی بین 1 و 12 باشد
            if (char.IsDigit(e.KeyChar))
            {
                int number;
                if (int.TryParse(monthremedical.Text + e.KeyChar, out number))
                {
                    if (number < 1 || number > 12)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void dayremedical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar))
            {
                int number;
                if (int.TryParse(dayremedical.Text + e.KeyChar, out number))
                {
                    if (number < 1 || number > 31)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void yearremedical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (char.IsDigit(e.KeyChar))
            {
                int number;
                if (int.TryParse(yearremedical.Text + e.KeyChar, out number))
                {
                    if (number < 1 || number > 3000)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void acceptbot_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                if (yearremedical.Text.Length != 4 || monthremedical.Text.Length == 0 || dayremedical.Text.Length == 0)
                {
                    MessageBox.Show("تاریخ جبرانی را به صورت صحیح وارد کنید.");
                }
                else
                {
                    bool thisstatus = dbc.check_course_holding_status(classidcombo.Text, click_date);

                    if (thisstatus == true)
                    {
                        DateTime remedicaldate = new DateTime(Convert.ToInt32(yearremedical.Text), Convert.ToInt32(monthremedical.Text), Convert.ToInt32(dayremedical.Text));
                        string s1 = dbc.course_holding_update(classidcombo.Text, click_date, false, remedicaldate);
                        if (s1 == "1")
                        {
                            MessageBox.Show("تغییر وضعیت با موفقیت انجام شد.");
                            yearremedical.Text = string.Empty;
                            monthremedical.Text = string.Empty;
                            dayremedical.Text = string.Empty;
                            groupBox3.Visible = false;
                            falsebot.BackColor = Color.White;
                            checkBox1.Checked = false;
                            get_classes(click_date);
                        }
                        else
                        {
                            MessageBox.Show("خطا در تغییر وضعیت.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("وضعیت کلاس (برگزار نشده) است.");
                    }
                }
            }
            else
            {
                bool thisstatus = dbc.check_course_holding_status(classidcombo.Text, click_date);

                if (thisstatus == true)
                {
                    
                    string s1 = dbc.course_holding_update(classidcombo.Text, click_date, false);
                    if (s1 == "1")
                    {
                        MessageBox.Show("تغییر وضعیت با موفقیت انجام شد.");
                        yearremedical.Text = string.Empty;
                        monthremedical.Text = string.Empty;
                        dayremedical.Text = string.Empty;
                        groupBox3.Visible = false;
                        falsebot.BackColor = Color.White;
                        checkBox1.Checked = false;
                        get_classes(click_date);
                    }
                    else
                    {
                        MessageBox.Show("خطا در تغییر وضعیت.");
                    }
                }
                else
                {
                    MessageBox.Show("وضعیت کلاس (برگزار نشده) است.");
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void todayclasslabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                yearremedical.Visible = true;
                monthremedical.Visible = true;
                dayremedical.Visible = true;
            }
            else
            {
                yearremedical.Text = string.Empty;
                monthremedical.Text = string.Empty;
                dayremedical.Text = string.Empty;
                yearremedical.Visible = false;
                monthremedical.Visible = false;
                dayremedical.Visible = false;

            }
        }
    }
}
