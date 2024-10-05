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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(enrollmentForm));
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
            tableLayoutPanel2 = new TableLayoutPanel();
            classidpictureBox = new PictureBox();
            classnamelbl = new Label();
            classidlbl = new Label();
            classnamepictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            studentnamepictureBox = new PictureBox();
            studentidpictureBox = new PictureBox();
            studentnamelbl = new Label();
            studentidlbl = new Label();
            paycheckbox = new CheckBox();
            trackingcodetbx = new TextBox();
            tarncCode = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((ISupportInitialize)classidpictureBox).BeginInit();
            ((ISupportInitialize)classnamepictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)studentnamepictureBox).BeginInit();
            ((ISupportInitialize)studentidpictureBox).BeginInit();
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.AutoSize = true;
            courseID.BackColor = Color.Transparent;
            courseID.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            courseID.ImageAlign = ContentAlignment.MiddleRight;
            courseID.Location = new Point(439, 48);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.No;
            courseID.Size = new Size(41, 27);
            courseID.TabIndex = 0;
            courseID.Text = "درس";
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.Transparent;
            date.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            date.ImageAlign = ContentAlignment.MiddleRight;
            date.Location = new Point(392, 187);
            date.Name = "date";
            date.RightToLeft = RightToLeft.No;
            date.Size = new Size(90, 27);
            date.TabIndex = 1;
            date.Text = "تاریخ ثبت نام";
            // 
            // whatsappGP
            // 
            whatsappGP.AutoSize = true;
            whatsappGP.BackColor = Color.Transparent;
            whatsappGP.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            whatsappGP.ImageAlign = ContentAlignment.MiddleRight;
            whatsappGP.Location = new Point(395, 274);
            whatsappGP.Name = "whatsappGP";
            whatsappGP.RightToLeft = RightToLeft.No;
            whatsappGP.Size = new Size(85, 27);
            whatsappGP.TabIndex = 2;
            whatsappGP.Text = "گروه واتساپ";
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.BackColor = Color.Transparent;
            studentID.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            studentID.ImageAlign = ContentAlignment.MiddleRight;
            studentID.Location = new Point(425, 14);
            studentID.Name = "studentID";
            studentID.RightToLeft = RightToLeft.No;
            studentID.Size = new Size(55, 27);
            studentID.TabIndex = 3;
            studentID.Text = "دانشجو";
            // 
            // WAgptxb
            // 
            WAgptxb.Location = new Point(74, 275);
            WAgptxb.Margin = new Padding(5, 4, 5, 4);
            WAgptxb.Multiline = true;
            WAgptxb.Name = "WAgptxb";
            WAgptxb.Size = new Size(313, 97);
            WAgptxb.TabIndex = 6;
            WAgptxb.TextChanged += WAgptxb_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 183);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(17, 33);
            label2.TabIndex = 26;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 183);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(17, 33);
            label1.TabIndex = 25;
            label1.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(261, 186);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 4;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(177, 186);
            datetxby.Margin = new Padding(5, 4, 5, 4);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(52, 27);
            datetxby.TabIndex = 5;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.TextChanged += datetxby_TextChanged;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(329, 186);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 3;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // courseIDtxb
            // 
            courseIDtxb.AutoCompleteMode = AutoCompleteMode.Suggest;
            courseIDtxb.Location = new Point(74, 49);
            courseIDtxb.Margin = new Padding(5, 4, 5, 4);
            courseIDtxb.MaxLength = 10;
            courseIDtxb.Name = "courseIDtxb";
            courseIDtxb.Size = new Size(324, 27);
            courseIDtxb.TabIndex = 2;
            courseIDtxb.TextChanged += courseIDtxb_TextChanged;
            courseIDtxb.KeyDown += courseIDtxb_KeyDown;
            courseIDtxb.KeyPress += courseIDtxb_KeyPress;
            courseIDtxb.Leave += courseIDtxb_Leave;
            // 
            // studentIDtxb
            // 
            studentIDtxb.AutoCompleteMode = AutoCompleteMode.Suggest;
            studentIDtxb.Location = new Point(74, 13);
            studentIDtxb.Margin = new Padding(5, 4, 5, 4);
            studentIDtxb.MaxLength = 10;
            studentIDtxb.Name = "studentIDtxb";
            studentIDtxb.Size = new Size(324, 27);
            studentIDtxb.TabIndex = 1;
            studentIDtxb.TextChanged += studentIDtxb_TextChanged;
            studentIDtxb.KeyDown += studentIDtxb_KeyDown;
            studentIDtxb.KeyPress += studentIDtxb_KeyPress;
            studentIDtxb.Leave += studentIDtxb_Leave;
            // 
            // setbot
            // 
            setbot.Enabled = false;
            setbot.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            setbot.Location = new Point(74, 379);
            setbot.Name = "setbot";
            setbot.Size = new Size(94, 56);
            setbot.TabIndex = 30;
            setbot.Text = "ثبت";
            setbot.UseVisualStyleBackColor = true;
            setbot.Click += setbot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 243, 238);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(courseIDtxb);
            panel1.Controls.Add(courseID);
            panel1.Controls.Add(studentIDtxb);
            panel1.Controls.Add(studentID);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 166);
            panel1.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(classidpictureBox, 0, 1);
            tableLayoutPanel2.Controls.Add(classnamelbl, 1, 0);
            tableLayoutPanel2.Controls.Add(classidlbl, 1, 1);
            tableLayoutPanel2.Controls.Add(classnamepictureBox, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 92);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(241, 74);
            tableLayoutPanel2.TabIndex = 32;
            // 
            // classidpictureBox
            // 
            classidpictureBox.Anchor = AnchorStyles.Left;
            classidpictureBox.Location = new Point(209, 40);
            classidpictureBox.Name = "classidpictureBox";
            classidpictureBox.Size = new Size(29, 28);
            classidpictureBox.TabIndex = 31;
            classidpictureBox.TabStop = false;
            // 
            // classnamelbl
            // 
            classnamelbl.Anchor = AnchorStyles.Left;
            classnamelbl.AutoSize = true;
            classnamelbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            classnamelbl.Location = new Point(162, 4);
            classnamelbl.Name = "classnamelbl";
            classnamelbl.Size = new Size(41, 27);
            classnamelbl.TabIndex = 33;
            classnamelbl.Text = "خالی";
            classnamelbl.Visible = false;
            // 
            // classidlbl
            // 
            classidlbl.Anchor = AnchorStyles.Left;
            classidlbl.AutoSize = true;
            classidlbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            classidlbl.Location = new Point(162, 41);
            classidlbl.Name = "classidlbl";
            classidlbl.Size = new Size(41, 27);
            classidlbl.TabIndex = 34;
            classidlbl.Text = "خالی";
            classidlbl.Visible = false;
            classidlbl.TextChanged += classidlbl_TextChanged;
            // 
            // classnamepictureBox
            // 
            classnamepictureBox.Anchor = AnchorStyles.Left;
            classnamepictureBox.Location = new Point(209, 3);
            classnamepictureBox.Name = "classnamepictureBox";
            classnamepictureBox.Size = new Size(29, 29);
            classnamepictureBox.TabIndex = 32;
            classnamepictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(studentnamepictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(studentidpictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(studentnamelbl, 1, 0);
            tableLayoutPanel1.Controls.Add(studentidlbl, 1, 1);
            tableLayoutPanel1.Location = new Point(250, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(234, 71);
            tableLayoutPanel1.TabIndex = 33;
            // 
            // studentnamepictureBox
            // 
            studentnamepictureBox.Location = new Point(202, 3);
            studentnamepictureBox.Name = "studentnamepictureBox";
            studentnamepictureBox.Size = new Size(29, 28);
            studentnamepictureBox.TabIndex = 30;
            studentnamepictureBox.TabStop = false;
            // 
            // studentidpictureBox
            // 
            studentidpictureBox.Anchor = AnchorStyles.Left;
            studentidpictureBox.Location = new Point(202, 37);
            studentidpictureBox.Name = "studentidpictureBox";
            studentidpictureBox.Size = new Size(29, 32);
            studentidpictureBox.TabIndex = 29;
            studentidpictureBox.TabStop = false;
            // 
            // studentnamelbl
            // 
            studentnamelbl.Anchor = AnchorStyles.Left;
            studentnamelbl.AutoSize = true;
            studentnamelbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            studentnamelbl.Location = new Point(155, 3);
            studentnamelbl.Name = "studentnamelbl";
            studentnamelbl.Size = new Size(41, 27);
            studentnamelbl.TabIndex = 31;
            studentnamelbl.Text = "خالی";
            studentnamelbl.Visible = false;
            // 
            // studentidlbl
            // 
            studentidlbl.Anchor = AnchorStyles.Left;
            studentidlbl.AutoSize = true;
            studentidlbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            studentidlbl.Location = new Point(155, 39);
            studentidlbl.Name = "studentidlbl";
            studentidlbl.Size = new Size(41, 27);
            studentidlbl.TabIndex = 32;
            studentidlbl.Text = "خالی";
            studentidlbl.Visible = false;
            studentidlbl.TextChanged += studentidlbl_TextChanged;
            studentidlbl.Click += studentidlbl_Click;
            // 
            // paycheckbox
            // 
            paycheckbox.AutoSize = true;
            paycheckbox.BackColor = Color.Transparent;
            paycheckbox.Checked = true;
            paycheckbox.CheckState = CheckState.Checked;
            paycheckbox.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            paycheckbox.Location = new Point(89, 233);
            paycheckbox.Name = "paycheckbox";
            paycheckbox.Size = new Size(79, 31);
            paycheckbox.TabIndex = 32;
            paycheckbox.Text = "پرداخت";
            paycheckbox.UseVisualStyleBackColor = false;
            paycheckbox.CheckedChanged += paycheckbox_CheckedChanged;
            // 
            // trackingcodetbx
            // 
            trackingcodetbx.Location = new Point(174, 233);
            trackingcodetbx.Name = "trackingcodetbx";
            trackingcodetbx.Size = new Size(213, 27);
            trackingcodetbx.TabIndex = 33;
            // 
            // tarncCode
            // 
            tarncCode.BackColor = Color.Transparent;
            tarncCode.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            tarncCode.Location = new Point(392, 227);
            tarncCode.Margin = new Padding(5, 0, 5, 0);
            tarncCode.Name = "tarncCode";
            tarncCode.RightToLeft = RightToLeft.No;
            tarncCode.Size = new Size(85, 41);
            tarncCode.TabIndex = 34;
            tarncCode.Text = "کد پیگیری";
            tarncCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // enrollmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(496, 447);
            Controls.Add(tarncCode);
            Controls.Add(trackingcodetbx);
            Controls.Add(paycheckbox);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "enrollmentForm";
            Text = "ثبت نام";
            Load += enrollmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((ISupportInitialize)classidpictureBox).EndInit();
            ((ISupportInitialize)classnamepictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)studentnamepictureBox).EndInit();
            ((ISupportInitialize)studentidpictureBox).EndInit();
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
        private PictureBox studentnamepictureBox;
        private PictureBox studentidpictureBox;
        private PictureBox classnamepictureBox;
        private PictureBox classidpictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label studentnamelbl;
        private Label studentidlbl;
        private TableLayoutPanel tableLayoutPanel2;
        private Label classnamelbl;
        private Label classidlbl;
        private CheckBox paycheckbox;
        private TextBox trackingcodetbx;
        private Label tarncCode;
    }
}