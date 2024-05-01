using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoozeshPJWinF
{
    public partial class AddUserForm : Form
    {
        string path;
        public AddUserForm()
        {
            InitializeComponent();
            addradioButton.Checked = true;

        }

        public void clear_textbox(TextBox t1)
        {
            t1.Text = string.Empty;
        }
        private void clear_all()
        {
            clear_textbox(Idbox);
            clear_textbox(Fnamebox);
            clear_textbox(Lnamebox);
            clear_textbox(Agebox);
            clear_textbox(Numberbox);
            clear_textbox(WAnumberbox);
            clear_textbox(Fieldbox);
            educationCbox.SelectedIndex = -1;
            clear_textbox(Presencerecordbox);
            clear_textbox(Yearenterybox);
            clear_textbox(Monthenterybox);
            clear_textbox(Dayenterybox);
            MaritalCbox.SelectedIndex = -1;
            ClasstypeCbox.SelectedIndex = -1;
            clear_textbox(Jobbox);
            clear_textbox(Citybox);
            pictureBox1.Image = null;
        }

        private void TypeCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCbox.SelectedIndex == 0)
            {
                groupBoxsame.Visible = true;
                groupBoxTch.Visible = true;
                groupBoxSt.Visible = false;
                educationlabel.Text = "مدرک تحصیلی :";
            }
            else if (TypeCbox.SelectedIndex == 1)
            {
                groupBoxsame.Visible = true;
                groupBoxTch.Visible = false;
                groupBoxSt.Visible = true;
                educationlabel.Text = "سطح تحصیلات :";
            }
        }

        private void checkBoxWA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWA.Checked == true)
            {
                WAnumberbox.Enabled = true;
            }
            else
            {
                WAnumberbox.Enabled = false;
                WAnumberbox.Text = string.Empty;
            }

        }

        private void Setbutton_Click(object sender, EventArgs e)
        {
            DBC d1 = new DBC();

            if (addradioButton.Checked == true)
            {

                if (TypeCbox.SelectedIndex == 1)
                {
                    if (d1.id_check(Idbox.Text) == true)
                    {
                        MessageBox.Show("کد ملی موجود است");
                    }
                    else
                    {
                        if (Idbox.Text != "" && Fnamebox.Text != "" && Lnamebox.Text != "" && Agebox.Text != "" && Numberbox.Text != ""
                             && educationCbox.Text != "" && MaritalCbox.Text != "" && Citybox.Text != "" &&
                            ClasstypeCbox.Text != "" && TypeCbox.Text != "" && pictureBox1.Image != null)
                        {


                            student s1 = new student();

                            s1.personalcode = Convert.ToInt64(Idbox.Text);
                            s1.lastname = Lnamebox.Text;
                            s1.firstname = Fnamebox.Text;
                            s1.age = Convert.ToInt32(Agebox.Text);
                            s1.number = Convert.ToInt64(Numberbox.Text);
                            if (WAnumberbox.Text == "")
                            {
                                s1.whatsappnumber = Convert.ToInt64(Numberbox.Text);
                            }
                            else
                            {
                                s1.whatsappnumber = Convert.ToInt64(WAnumberbox.Text);
                            }
                            s1.fieled_of_study = Fieldbox.Text;
                            if (educationCbox.SelectedIndex == 0)
                            {
                                s1.education = 0;
                            }
                            else if (educationCbox.SelectedIndex == 1)
                            {
                                s1.education = 1;
                            }
                            else if (educationCbox.SelectedIndex == 2)
                            {
                                s1.education = 2;
                            }
                            else if (educationCbox.SelectedIndex == 3)
                            {
                                s1.education = 3;
                            }
                            else if (educationCbox.SelectedIndex == 4)
                            {
                                s1.education = 4;
                            }
                            else if (educationCbox.SelectedIndex == 5)
                            {
                                s1.education = 5;
                            }
                            else if (educationCbox.SelectedIndex == 6)
                            {
                                s1.education = 6;
                            }
                            if (MaritalCbox.SelectedIndex == 0)
                            {
                                s1.maritalstatus = false;
                            }
                            else if (MaritalCbox.SelectedIndex == 1)
                            {
                                s1.maritalstatus = true;
                            }
                            s1.city = Citybox.Text;
                            s1.job = Jobbox.Text;
                            if (ClasstypeCbox.SelectedIndex == 0)
                            {
                                s1.classtype = true;
                            }
                            else if (ClasstypeCbox.SelectedIndex == 1)
                            {
                                s1.classtype = false;
                            }
                            //picture

                            s1.profilepicture = d1.ImageToByteArray(pictureBox1.Image);




                            string result = d1.st_set(s1);
                            if (result == "11")
                            {
                                MessageBox.Show("ثبت با موفقیت انجام شد");
                                clear_textbox(Idbox);
                                clear_textbox(Fnamebox);
                                clear_textbox(Lnamebox);
                                clear_textbox(Agebox);
                                clear_textbox(Citybox);
                                clear_textbox(Jobbox);
                                clear_textbox(Numberbox);
                                clear_textbox(WAnumberbox);
                                clear_textbox(Fieldbox);
                                educationCbox.Text = string.Empty;
                                MaritalCbox.Text = string.Empty;
                                ClasstypeCbox.Text = string.Empty;
                                pictureBox1.Image = null;

                            }
                            else
                            {
                                MessageBox.Show("ثبت انجام نشد!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                        }

                    }
                }
                else if (TypeCbox.SelectedIndex == 0)
                {

                    if (Idbox.Text.Length < 10)
                    {
                        MessageBox.Show("کد ملی نا معتبر است.");
                    }
                    else
                    {


                        if (d1.id_check(Idbox.Text) == true)
                        {
                            MessageBox.Show("کد ملی موجود است");
                        }
                        else
                        {

                            if (Idbox.Text != "" && Fnamebox.Text != "" && Lnamebox.Text != "" && Agebox.Text != "" && Numberbox.Text != ""
                                 && educationCbox.Text != "" && Presencerecordbox.Text != "" && Yearenterybox.Text != "" &&
                                Monthenterybox.Text != "" && Dayenterybox.Text != "" && pictureBox1.Image != null)
                            {
                                teacher p1 = new teacher();
                                p1.personalcode = Convert.ToInt64(Idbox.Text);
                                p1.lastname = Lnamebox.Text;
                                p1.firstname = Fnamebox.Text;
                                p1.age = Convert.ToInt32(Agebox.Text);
                                p1.number = Convert.ToInt64(Numberbox.Text);
                                if (WAnumberbox.Text == "")
                                {
                                    p1.whatsappnumber = Convert.ToInt64(Numberbox.Text);
                                }
                                else
                                {
                                    p1.whatsappnumber = Convert.ToInt64(WAnumberbox.Text);
                                }
                                p1.fieled_of_study = Fieldbox.Text;
                                if (educationCbox.SelectedIndex == 0)
                                {
                                    p1.degree_of_education = 0;
                                }
                                else if (educationCbox.SelectedIndex == 1)
                                {
                                    p1.degree_of_education = 1;
                                }
                                else if (educationCbox.SelectedIndex == 2)
                                {
                                    p1.degree_of_education = 2;
                                }
                                else if (educationCbox.SelectedIndex == 3)
                                {
                                    p1.degree_of_education = 3;
                                }
                                else if (educationCbox.SelectedIndex == 4)
                                {
                                    p1.degree_of_education = 4;
                                }
                                else if (educationCbox.SelectedIndex == 5)
                                {
                                    p1.degree_of_education = 5;
                                }
                                else if (educationCbox.SelectedIndex == 6)
                                {
                                    p1.degree_of_education = 6;
                                }
                                p1.presence_record = Convert.ToInt16(Presencerecordbox.Text);
                                DateTime data1 = new DateTime(Convert.ToInt16(Yearenterybox.Text), Convert.ToInt16(Monthenterybox.Text), Convert.ToInt16(Dayenterybox.Text));
                                p1.date_of_entry = data1;
                                p1.profilepicture = d1.ImageToByteArray(pictureBox1.Image);
                                string result = d1.pr_set(p1);
                                if (result == "11")
                                {
                                    MessageBox.Show("ثبت با موفقیت انجام شد");
                                    clear_textbox(Idbox);
                                    clear_textbox(Fnamebox);
                                    clear_textbox(Lnamebox);
                                    clear_textbox(Agebox);


                                    clear_textbox(Numberbox);
                                    clear_textbox(WAnumberbox);
                                    clear_textbox(Fieldbox);
                                    clear_textbox(Presencerecordbox);
                                    clear_textbox(Yearenterybox);
                                    clear_textbox(Monthenterybox);
                                    clear_textbox(Dayenterybox);
                                    educationCbox.Text = string.Empty;
                                    pictureBox1.Image = null;

                                }

                                else
                                {
                                    MessageBox.Show("ثبت انجام نشد!!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("نوع کاربر را انتخاب کنید");
                }
            }
        }

        private void Idbox_TextChanged(object sender, EventArgs e)
        {
            if (addradioButton.Checked == true)
            {
                if (Idbox.Text.Length != 10)
                {
                    Setbutton.Enabled = false;
                    checkbot.Enabled = false;
                }
                else { Setbutton.Enabled = true; }
            }
            else if (editradioButton.Checked == true)
            {
                if (Idbox.Text.Length != 10)
                {
                    Setbutton.Enabled = false;
                    checkbot.Enabled = false;
                }
                else { Setbutton.Enabled = false; checkbot.Enabled = true; }
            }
        }

        private void picturebot_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(op.FileName);
                //pictureBox1.ImageLocation = op.FileName;
            }

        }

        private void idlabel_Click(object sender, EventArgs e)
        {

        }

        private void Idbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Agebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Numberbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void WAnumberbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Presencerecordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Yearenterybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Monthenterybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Dayenterybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Fnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Lnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Fieldbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Citybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Jobbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            TypeCbox.SelectedIndex = 1;

            groupBoxsame.Visible = true;
            groupBoxTch.Visible = false;
            groupBoxSt.Visible = true;
            educationlabel.Text = "سطح تحصیلات :";

        }

        private void addradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (addradioButton.Checked == true)
            {
                clear_all();
                checkbot.Visible = false;
            }
            else
            {
                clear_all();
                checkbot.Visible = true;
            }

        }

        private void editradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkbot_Click(object sender, EventArgs e)
        {
            DBC d1 = new DBC();
            if (d1.id_check(Idbox.Text))
            {
                if(TypeCbox.SelectedIndex == 1)
                {
                    GetStudent s1 = new GetStudent();
                    s1 = d1.St_Reader(Idbox.Text);
                    Fnamebox.Text = s1.firstname;
                    Lnamebox.Text= s1.lastname;
                    Agebox.Text = s1.age.ToString();
                    Numberbox.Text = s1.number.ToString();
                    Citybox.Text = s1.city;
                    Jobbox.Text = s1.job;
                    if(s1.whatsappnumber != null)
                    {
                        WAnumberbox.Text = s1.whatsappnumber.ToString();
                        checkBoxWA.Checked = true;
                    }
                    Fieldbox.Text = s1.fieled_of_study;
                    if (s1.education == null)
                    {
                        educationCbox.SelectedIndex = -1;
                    }
                    else
                    {
                        educationCbox.SelectedIndex= Convert.ToInt16(s1.education);
                    }

                    if (s1.maritalstatus == false)
                    {
                        MaritalCbox.SelectedIndex = 0;
                    }
                    else if (s1.maritalstatus == true)
                    {
                        MaritalCbox.SelectedIndex = 1;
                    }

                    if ( s1.classtype == true)
                    {
                        ClasstypeCbox.SelectedIndex = 0;
                    }
                    else if ( s1.classtype == false)
                    {
                        ClasstypeCbox.SelectedIndex = 1;
                    }
                }
                else if(TypeCbox.SelectedIndex == 0)
                {

                }
                
            }
            else
            {
                MessageBox.Show("کاربر وجود ندارد!");
            }
        }
    }
}
