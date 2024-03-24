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
            string s1 = "clocklbl";
            clocklbl.Text = DateTime.Now.ToString();
        }
    }
}
