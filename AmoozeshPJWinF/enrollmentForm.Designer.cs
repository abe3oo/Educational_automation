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
            setbot = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.AutoSize = true;
            courseID.ImageAlign = ContentAlignment.MiddleRight;
            courseID.Location = new Point(406, 30);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.Yes;
            courseID.Size = new Size(40, 20);
            courseID.TabIndex = 0;
            courseID.Text = "درس";
            // 
            // date
            // 
            date.AutoSize = true;
            date.ImageAlign = ContentAlignment.MiddleRight;
            date.Location = new Point(350, 177);
            date.Name = "date";
            date.RightToLeft = RightToLeft.Yes;
            date.Size = new Size(89, 20);
            date.TabIndex = 1;
            date.Text = "تاریخ ثبت نام";
            // 
            // whatsappGP
            // 
            whatsappGP.AutoSize = true;
            whatsappGP.ImageAlign = ContentAlignment.MiddleRight;
            whatsappGP.Location = new Point(352, 233);
            whatsappGP.Name = "whatsappGP";
            whatsappGP.RightToLeft = RightToLeft.Yes;
            whatsappGP.Size = new Size(90, 20);
            whatsappGP.TabIndex = 2;
            whatsappGP.Text = "گروه واتساپ";
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.ImageAlign = ContentAlignment.MiddleRight;
            studentID.Location = new Point(406, 69);
            studentID.Name = "studentID";
            studentID.RightToLeft = RightToLeft.Yes;
            studentID.Size = new Size(56, 20);
            studentID.TabIndex = 3;
            studentID.Text = "دانشجو";
            // 
            // WAgptxb
            // 
            WAgptxb.Location = new Point(74, 233);
            WAgptxb.Margin = new Padding(5, 4, 5, 4);
            WAgptxb.Multiline = true;
            WAgptxb.Name = "WAgptxb";
            WAgptxb.Size = new Size(266, 159);
            WAgptxb.TabIndex = 17;
            WAgptxb.TextChanged += WAgptxb_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 173);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(17, 33);
            label2.TabIndex = 26;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 173);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(17, 33);
            label1.TabIndex = 25;
            label1.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(237, 173);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 24;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(153, 173);
            datetxby.Margin = new Padding(5, 4, 5, 4);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(52, 27);
            datetxby.TabIndex = 23;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(305, 173);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 22;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // courseIDtxb
            // 
            courseIDtxb.Location = new Point(74, 27);
            courseIDtxb.Margin = new Padding(5, 4, 5, 4);
            courseIDtxb.MaxLength = 10;
            courseIDtxb.Name = "courseIDtxb";
            courseIDtxb.Size = new Size(310, 27);
            courseIDtxb.TabIndex = 27;
            courseIDtxb.TextChanged += courseIDtxb_TextChanged;
            courseIDtxb.KeyPress += courseIDtxb_KeyPress;
            // 
            // studentIDtxb
            // 
            studentIDtxb.Location = new Point(74, 62);
            studentIDtxb.Margin = new Padding(5, 4, 5, 4);
            studentIDtxb.MaxLength = 10;
            studentIDtxb.Name = "studentIDtxb";
            studentIDtxb.Size = new Size(310, 27);
            studentIDtxb.TabIndex = 28;
            studentIDtxb.TextChanged += studentIDtxb_TextChanged;
            studentIDtxb.KeyPress += studentIDtxb_KeyPress;
            // 
            // setbot
            // 
            setbot.Location = new Point(74, 447);
            setbot.Name = "setbot";
            setbot.Size = new Size(94, 29);
            setbot.TabIndex = 30;
            setbot.Text = "ثبت";
            setbot.UseVisualStyleBackColor = true;
            setbot.Click += setbot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 243, 238);
            panel1.Controls.Add(courseIDtxb);
            panel1.Controls.Add(courseID);
            panel1.Controls.Add(studentIDtxb);
            panel1.Controls.Add(studentID);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 166);
            panel1.TabIndex = 31;
            // 
            // enrollmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 497);
            Controls.Add(panel1);
            Controls.Add(setbot);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datetxbm);
            Controls.Add(datetxby);
            Controls.Add(datetxbd);
            Controls.Add(WAgptxb);
            Controls.Add(whatsappGP);
            Controls.Add(date);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "enrollmentForm";
            Text = "enrollmentForm";
            Load += enrollmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button setbot;
        private Panel panel1;
    }
}