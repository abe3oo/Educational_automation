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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmoozeshPJWinF
{
    public partial class payWindow : Form
    {
        DBC dpay = new DBC();
        List<string> personresult = new List<string>();
        public payWindow()
        {
            InitializeComponent();
        }

        private void ReduceSaturationforbot(System.Windows.Forms.Button b1, float f1, int i1)
        {
            Image iconImage;

            if (i1 == 1)
            {
                iconImage = Properties.Resources.moneyup60;
            }
            else
            {
                iconImage = Properties.Resources.moneydown60;
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

        private void ReduceSaturationforpic(PictureBox b1, float f1, int i1)
        {
            Image iconImage;

            if (i1 == 1)
            {
                iconImage = Properties.Resources.name25;
            }
            else
            {
                iconImage = Properties.Resources.id25;
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
        private void tractimetxbH_TextChanged(object sender, EventArgs e)
        {

        }

        private void payWindow_Load(object sender, EventArgs e)
        {
            //user load
            useridtbx.AutoCompleteCustomSource = null;
            personresult = dpay.get_all_users();
            useridtbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            useridtbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection te = new AutoCompleteStringCollection();
            te.AddRange(personresult.ToArray());
            useridtbx.AutoCompleteCustomSource = te;
            //picturs
            ReduceSaturationforbot(daryaftbot, 0.2f, 1);
            ReduceSaturationforbot(pardakhtbot, 0.2f, 0);
            ReduceSaturationforpic(namepictureBox, 0.2f, 1);
            ReduceSaturationforpic(namepictureBox, 0.2f, 0);
        }

        private void tracTypeCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void useridtbx_TextChanged(object sender, EventArgs e)
        {
            if (useridtbx.AutoCompleteCustomSource.Contains(useridtbx.Text))
            {
                namelbl.Text = Extractname(useridtbx.Text);
                namelbl.Visible = true;
                idlbl.Text = ExtractNumber(useridtbx.Text, 10);
                idlbl.Visible = true;
                ReduceSaturationforpic(namepictureBox, 1f, 1);
                ReduceSaturationforpic(idpictureBox, 1f, 0);
                useridtbx.Text = string.Empty;
            }

        }

        private void useridtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void amounttxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tractimetxbH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tractimetxbM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tracCodetxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void userID_Click(object sender, EventArgs e)
        {

        }

        private void typePay_Click(object sender, EventArgs e)
        {

        }

        private void amount_Click(object sender, EventArgs e)
        {

        }

        private void amounttxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void hourupdown_ValueChanged(object sender, EventArgs e)
        {
            if (hourupdown.Value < 0)
            {
                hourupdown.Value = 23;
            }
            else if (hourupdown.Value >= 24)
            {
                hourupdown.Value = 0;
            }
        }

        private void minupdown_ValueChanged(object sender, EventArgs e)
        {
            if (minupdown.Value < 0)
            {
                minupdown.Value = 59;
            }
            else if (minupdown.Value >= 60)
            {
                minupdown.Value = 0;
            }
        }

        private void setbot_Click(object sender, EventArgs e)
        {

            if (dpay.id_check(idlbl.Text) == true)
            {

                if (idlbl.Text != "خالی" && datetxby.Text != "" && datetxbm.Text != "" && datetxbd.Text != "" && termCobox.Text != "" && amounttxb.Text != ""
                       && tracTypeCbox.Text != "" &&
                      tracCodetxb.Text != "")
                {
                    Payment p1 = new Payment();

                    p1.userid = Convert.ToInt64(idlbl.Text);
                    DateTime date = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    p1.dateofpayment = date;
                    if (termCobox.SelectedIndex == 0)
                    {
                        p1.term = 1;
                    }
                    else if (termCobox.SelectedIndex == 1)
                    {
                        p1.term = 2;
                    }
                    else if (termCobox.SelectedIndex == 2)
                    {
                        p1.term = 3;
                    }
                    else if (termCobox.SelectedIndex == 3)
                    {
                        p1.term = 4;
                    }

                    p1.amount = Convert.ToInt64(amounttxb.Text);
                    
                    
                    TimeSpan time = new TimeSpan(Convert.ToInt16(hourupdown.Value), Convert.ToInt16(minupdown.Value), 0);
                    p1.tarckingtime = time;
                    p1.trackingcode = Convert.ToInt64(tracCodetxb.Text);
                    p1.description = statustxb.Text;
                    string result;
                    if (tracTypeCbox.SelectedIndex == 0)
                    {
                        result = dpay.pay_set(p1);
                    }
                    else if (tracTypeCbox.SelectedIndex == 1)
                    {
                        result = dpay.pay_set(p1, "-");
                    }
                    else
                    {
                        result = "00";
                    }

                    if (result == "11")
                    {
                        MessageBox.Show("پرداخت با موفقیت انجام شد.");

                        idlbl.Text = "خالی";
                        namelbl.Text = "خالی";
                        clear_textbox(datetxby);
                        clear_textbox(datetxbm);
                        clear_textbox(datetxbd);
                        clear_textbox(amounttxb);
                        hourupdown.Value = 0;
                        minupdown.Value = 0;
                        clear_textbox(tracCodetxb);
                        clear_textbox(statustxb);
                        termCobox.Text = string.Empty;
                        tracTypeCbox.SelectedIndex = -1;
                        ReduceSaturationforpic(namepictureBox, 0.2f, 1);
                        ReduceSaturationforpic(idpictureBox, 0.2f, 0);
                        ReduceSaturationforbot(pardakhtbot, 0.2f, 1);
                        ReduceSaturationforbot(daryaftbot, 0.2f, 0);
                        panelcolorselect.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("پرداخت نا موفق بود.");
                    }



                }
                else
                {
                    MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                }

            }
            else
            {
                MessageBox.Show("کد ملی موجود نیست!!!");
            }

        }

        private void pardakhtbot_Click(object sender, EventArgs e)
        {
            ReduceSaturationforbot(pardakhtbot, 1f, 1);
            ReduceSaturationforbot(daryaftbot, 0.2f, 0);
            tracTypeCbox.SelectedIndex = 0;
            panelcolorselect.Visible = true;
            panelcolorselect.Width = pardakhtbot.Width;
            panelcolorselect.Left = pardakhtbot.Left;
        }

        private void daryaftbot_Click(object sender, EventArgs e)
        {
            ReduceSaturationforbot(pardakhtbot, 0.2f, 1);
            ReduceSaturationforbot(daryaftbot, 1f, 0);
            tracTypeCbox.SelectedIndex = 1;
            panelcolorselect.Visible = true;
            panelcolorselect.Width = daryaftbot.Width;
            panelcolorselect.Left = daryaftbot.Left;
        }

        private void idlbl_Click(object sender, EventArgs e)
        {

        }

        private void idlbl_TextChanged(object sender, EventArgs e)
        {
            if(idlbl.Text.Length == 10)
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
