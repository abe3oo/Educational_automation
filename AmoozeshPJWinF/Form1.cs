using System.Globalization;

namespace AmoozeshPJWinF
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = null;
        public Form1()
        {
            InitializeComponent();
            StartTimer();
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
    }
}
