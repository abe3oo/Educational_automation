namespace AmoozeshPJWinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
