using System.Globalization;

namespace AmoozeshPJWinF
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = null;
        public List<Button> buttons1;

        public Form1()
        {
            InitializeComponent();
            StartTimer();
            buttons1 = new List<Button>() {day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13,
            day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26, day27, day28, day29, day30, day31};
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
        }

        private void daylabelpr_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void daylabelpr_TextChanged(object sender, EventArgs e)
        {
            foreach (Button b1 in buttons1)
            {
                if (daylabelpr.Text == b1.Text)
                {
                    b1.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
