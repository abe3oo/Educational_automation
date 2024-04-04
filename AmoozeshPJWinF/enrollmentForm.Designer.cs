using Amozesh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoozeshPJWinF
{
    partial class enrollmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void clear_textbox(TextBox t1)
        {
            t1.Text = string.Empty;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            courseID = new Label();
            date = new Label();
            whatsappGP = new Label();
            studentID = new Label();
            WAgptxb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            datetxbm = new TextBox();
            datetxby = new TextBox();
            datetxbd = new TextBox();
            courseIDtxb = new TextBox();
            studentIDtxb = new TextBox();
            sabtEnorollmetButton = new Button();
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.AutoSize = true;
            courseID.ImageAlign = ContentAlignment.MiddleRight;
            courseID.Location = new Point(308, 43);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.Yes;
            courseID.Size = new Size(49, 15);
            courseID.TabIndex = 0;
            courseID.Text = "کد درس:";
            // 
            // date
            // 
            date.AutoSize = true;
            date.ImageAlign = ContentAlignment.MiddleRight;
            date.Location = new Point(306, 133);
            date.Name = "date";
            date.RightToLeft = RightToLeft.Yes;
            date.Size = new Size(73, 15);
            date.TabIndex = 1;
            date.Text = "تاریخ ثبت نام:";
            // 
            // whatsappGP
            // 
            whatsappGP.AutoSize = true;
            whatsappGP.ImageAlign = ContentAlignment.MiddleRight;
            whatsappGP.Location = new Point(308, 175);
            whatsappGP.Name = "whatsappGP";
            whatsappGP.RightToLeft = RightToLeft.Yes;
            whatsappGP.Size = new Size(72, 15);
            whatsappGP.TabIndex = 2;
            whatsappGP.Text = "گروه واتساپ:";
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.ImageAlign = ContentAlignment.MiddleRight;
            studentID.Location = new Point(308, 89);
            studentID.Name = "studentID";
            studentID.RightToLeft = RightToLeft.Yes;
            studentID.Size = new Size(119, 15);
            studentID.TabIndex = 3;
            studentID.Text = "  کد ملی دانش اموزش:";
            // 
            // WAgptxb
            // 
            WAgptxb.Location = new Point(65, 175);
            WAgptxb.Margin = new Padding(4, 3, 4, 3);
            WAgptxb.Multiline = true;
            WAgptxb.Name = "WAgptxb";
            WAgptxb.Size = new Size(233, 120);
            WAgptxb.TabIndex = 17;
            WAgptxb.TextChanged += WAgptxb_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(15, 25);
            label2.TabIndex = 26;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(15, 25);
            label1.TabIndex = 25;
            label1.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(207, 130);
            datetxbm.Margin = new Padding(4, 3, 4, 3);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(31, 23);
            datetxbm.TabIndex = 24;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(134, 130);
            datetxby.Margin = new Padding(4, 3, 4, 3);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(46, 23);
            datetxby.TabIndex = 23;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(267, 130);
            datetxbd.Margin = new Padding(4, 3, 4, 3);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(31, 23);
            datetxbd.TabIndex = 22;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // courseIDtxb
            // 
            courseIDtxb.Location = new Point(167, 40);
            courseIDtxb.Margin = new Padding(4, 3, 4, 3);
            courseIDtxb.MaxLength = 10;
            courseIDtxb.Name = "courseIDtxb";
            courseIDtxb.Size = new Size(131, 23);
            courseIDtxb.TabIndex = 27;
            courseIDtxb.TextChanged += courseIDtxb_TextChanged;
            courseIDtxb.KeyPress += courseIDtxb_KeyPress;
            // 
            // studentIDtxb
            // 
            studentIDtxb.Location = new Point(167, 86);
            studentIDtxb.Margin = new Padding(4, 3, 4, 3);
            studentIDtxb.MaxLength = 10;
            studentIDtxb.Name = "studentIDtxb";
            studentIDtxb.Size = new Size(131, 23);
            studentIDtxb.TabIndex = 28;
            studentIDtxb.TextChanged += studentIDtxb_TextChanged;
            studentIDtxb.KeyPress += studentIDtxb_KeyPress;
            // 
            // sabtEnorollmetButton
            // 
            sabtEnorollmetButton.Enabled = false;
            sabtEnorollmetButton.Location = new Point(26, 334);
            sabtEnorollmetButton.Name = "sabtEnorollmetButton";
            sabtEnorollmetButton.Size = new Size(75, 23);
            sabtEnorollmetButton.TabIndex = 29;
            sabtEnorollmetButton.Text = "ثبت";
            sabtEnorollmetButton.UseVisualStyleBackColor = true;
            sabtEnorollmetButton.Click += sabtEnorollmetButton_Click;
            // 
            // enrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 388);
            Controls.Add(sabtEnorollmetButton);
            Controls.Add(studentIDtxb);
            Controls.Add(courseIDtxb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datetxbm);
            Controls.Add(datetxby);
            Controls.Add(datetxbd);
            Controls.Add(WAgptxb);
            Controls.Add(studentID);
            Controls.Add(whatsappGP);
            Controls.Add(date);
            Controls.Add(courseID);
            Name = "enrollmentForm";
            Text = "enrollmentForm";
            Load += enrollmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void enrollmentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void sabtEnorollmetButton_Click(object sender, EventArgs e)
        {
            DBC denrollment = new DBC();

            if ((denrollment.courseid_check(courseIDtxb.Text) == true) && (denrollment.studentid_check(studentIDtxb.Text) == true))
            {
                if (courseIDtxb.Text != "" && studentIDtxb.Text != "" && WAgptxb.Text != "" && datetxbd.Text != "" && datetxbm.Text != "" && datetxby.Text != "")
                {
                    Enrollment e1 = new Enrollment();

                    e1.courseid = Convert.ToInt64(courseIDtxb.Text);
                    e1.studentid = Convert.ToInt64(studentIDtxb.Text);
                    e1.whatsappgp = WAgptxb.Text;
                    DateTime date3 = new DateTime(Convert.ToInt16(datetxby.Text), Convert.ToInt16(datetxbm.Text), Convert.ToInt16(datetxbd.Text));
                    e1.dateofenrollment = date3;

                    denrollment.enrollment_set(e1);

                    MessageBox.Show("ثبت با موفقیت انجام شد");

                    clear_textbox(courseIDtxb);
                    clear_textbox(studentIDtxb);
                    clear_textbox(datetxby);
                    clear_textbox(datetxbm);
                    clear_textbox(datetxbd);      
                    clear_textbox(WAgptxb);

                }
                else
                {
                    MessageBox.Show("فیلد های مورد نیاز را پر کنید");
                }
            }
            else
            {
                MessageBox.Show("کد ملی یا کد درس موجود نیست!!!");
            }

        }

        #endregion

        private Label courseID;
        private Label date;
        private Label whatsappGP;
        private Label studentID;
        private TextBox textBox1;
        private TextBox useridtbx;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox WAgptxb;
        private Label label2;
        private Label label1;
        private TextBox datetxbm;
        private TextBox datetxby;
        private TextBox datetxbd;
        private TextBox courseIDtxb;
        private TextBox textBox4;
        private TextBox studentIDtxb;
        private Button sabtEnorollmetButton;
    }
}