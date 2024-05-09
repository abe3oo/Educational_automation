using System;
using System.Globalization;

namespace AmoozeshPJWinF
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = null;
        public List<Button> buttons1;
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
            List<long> idtoday = dbc.Course_holding_id_Reader_by_date(date);
            List<GetCourse> coursetoday = new List<GetCourse>();
            foreach (long id in idtoday)
            {
                coursetoday.Add(dbc.GetCourse_Reader_by_id(id));
            }
            if (coursetoday.Count > 0)
            {
                todayclasslabel.Text = "کلاس های امروز:";
                coursetodayGridView.DataSource = coursetoday;
            }
            else
            {
                todayclasslabel.Text = "امروز کلاسی ندارید.";

            }
        }

        public void show_class_withbott(Button b1)
        {
            DateTime date = new DateTime(Convert.ToInt16(yearlabelcul.Text),Convert.ToInt16(monthlabelcul.Text),Convert.ToInt16(b1.Text));
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
    }
}
