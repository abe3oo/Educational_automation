﻿
using Amozesh;
using System.Windows.Forms;

namespace AmoozeshPJWinF
{
    partial class payWindow
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
            userID = new Label();
            amount = new Label();
            term = new Label();
            timepay = new Label();
            typePay = new Label();
            datepay = new Label();
            status = new Label();
            tarncCode = new Label();
            useridtbx = new TextBox();
            tracCodetxb = new TextBox();
            amounttxb = new TextBox();
            datetxbd = new TextBox();
            statustxb = new TextBox();
            datetxby = new TextBox();
            datetxbm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tracTypeCbox = new ComboBox();
            termCobox = new ComboBox();
            hourupdown = new NumericUpDown();
            minupdown = new NumericUpDown();
            setbot = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)hourupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minupdown).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userID
            // 
            userID.Location = new Point(539, 146);
            userID.Margin = new Padding(5, 0, 5, 0);
            userID.Name = "userID";
            userID.RightToLeft = RightToLeft.No;
            userID.Size = new Size(71, 20);
            userID.TabIndex = 0;
            userID.Text = "کد ملی";
            userID.TextAlign = ContentAlignment.MiddleRight;
            userID.Click += userID_Click;
            // 
            // amount
            // 
            amount.Location = new Point(522, 297);
            amount.Margin = new Padding(5, 0, 5, 0);
            amount.Name = "amount";
            amount.RightToLeft = RightToLeft.No;
            amount.Size = new Size(88, 27);
            amount.TabIndex = 1;
            amount.Text = "مقدار تراکنش";
            amount.TextAlign = ContentAlignment.MiddleRight;
            amount.Click += amount_Click;
            // 
            // term
            // 
            term.Location = new Point(578, 249);
            term.Margin = new Padding(5, 0, 5, 0);
            term.Name = "term";
            term.RightToLeft = RightToLeft.No;
            term.Size = new Size(32, 27);
            term.TabIndex = 2;
            term.Text = "ترم";
            term.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timepay
            // 
            timepay.Location = new Point(525, 414);
            timepay.Margin = new Padding(5, 0, 5, 0);
            timepay.Name = "timepay";
            timepay.RightToLeft = RightToLeft.No;
            timepay.Size = new Size(85, 31);
            timepay.TabIndex = 4;
            timepay.Text = "زمان تراکنش";
            timepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // typePay
            // 
            typePay.Location = new Point(525, 339);
            typePay.Margin = new Padding(5, 0, 5, 0);
            typePay.Name = "typePay";
            typePay.RightToLeft = RightToLeft.No;
            typePay.Size = new Size(85, 32);
            typePay.TabIndex = 5;
            typePay.Text = "نوع تراکنش";
            typePay.TextAlign = ContentAlignment.MiddleRight;
            typePay.Click += typePay_Click;
            // 
            // datepay
            // 
            datepay.Location = new Point(522, 185);
            datepay.Margin = new Padding(5, 0, 5, 0);
            datepay.Name = "datepay";
            datepay.RightToLeft = RightToLeft.No;
            datepay.Size = new Size(94, 32);
            datepay.TabIndex = 6;
            datepay.Text = "تاریخ پرداخت";
            datepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // status
            // 
            status.Location = new Point(206, 232);
            status.Margin = new Padding(5, 0, 5, 0);
            status.Name = "status";
            status.RightToLeft = RightToLeft.No;
            status.Size = new Size(94, 41);
            status.TabIndex = 7;
            status.Text = "توضیحات";
            // 
            // tarncCode
            // 
            tarncCode.Location = new Point(539, 456);
            tarncCode.Margin = new Padding(5, 0, 5, 0);
            tarncCode.Name = "tarncCode";
            tarncCode.RightToLeft = RightToLeft.No;
            tarncCode.Size = new Size(71, 41);
            tarncCode.TabIndex = 8;
            tarncCode.Text = "کد پیگیری";
            tarncCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // useridtbx
            // 
            useridtbx.Location = new Point(342, 139);
            useridtbx.Margin = new Padding(5, 4, 5, 4);
            useridtbx.MaxLength = 10;
            useridtbx.Name = "useridtbx";
            useridtbx.Size = new Size(149, 27);
            useridtbx.TabIndex = 9;
            useridtbx.TextChanged += useridtbx_TextChanged;
            useridtbx.KeyPress += useridtbx_KeyPress;
            // 
            // tracCodetxb
            // 
            tracCodetxb.Location = new Point(342, 456);
            tracCodetxb.Margin = new Padding(5, 4, 5, 4);
            tracCodetxb.Name = "tracCodetxb";
            tracCodetxb.Size = new Size(149, 27);
            tracCodetxb.TabIndex = 12;
            tracCodetxb.KeyPress += tracCodetxb_KeyPress;
            // 
            // amounttxb
            // 
            amounttxb.Location = new Point(342, 284);
            amounttxb.Margin = new Padding(5, 4, 5, 4);
            amounttxb.Name = "amounttxb";
            amounttxb.Size = new Size(149, 27);
            amounttxb.TabIndex = 13;
            amounttxb.TextChanged += amounttxb_TextChanged;
            amounttxb.KeyPress += amounttxb_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(456, 184);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 15;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // statustxb
            // 
            statustxb.Location = new Point(33, 271);
            statustxb.Margin = new Padding(5, 4, 5, 4);
            statustxb.Multiline = true;
            statustxb.Name = "statustxb";
            statustxb.Size = new Size(267, 120);
            statustxb.TabIndex = 16;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(313, 181);
            datetxby.Margin = new Padding(5, 4, 5, 4);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(52, 27);
            datetxby.TabIndex = 17;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(397, 181);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 18;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 181);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(17, 33);
            label1.TabIndex = 20;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 181);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(17, 33);
            label2.TabIndex = 21;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 399);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(17, 33);
            label3.TabIndex = 22;
            label3.Text = ":";
            // 
            // tracTypeCbox
            // 
            tracTypeCbox.FormattingEnabled = true;
            tracTypeCbox.Items.AddRange(new object[] { "پرداخت", "دریافت" });
            tracTypeCbox.Location = new Point(338, 339);
            tracTypeCbox.Margin = new Padding(5, 3, 5, 3);
            tracTypeCbox.Name = "tracTypeCbox";
            tracTypeCbox.Size = new Size(153, 28);
            tracTypeCbox.TabIndex = 24;
            tracTypeCbox.SelectedIndexChanged += tracTypeCbox_SelectedIndexChanged;
            // 
            // termCobox
            // 
            termCobox.FormattingEnabled = true;
            termCobox.Items.AddRange(new object[] { "بهار", "تابستان", "پاییز", "زمستان" });
            termCobox.Location = new Point(338, 232);
            termCobox.Margin = new Padding(5, 3, 5, 3);
            termCobox.Name = "termCobox";
            termCobox.Size = new Size(153, 28);
            termCobox.TabIndex = 25;
            // 
            // hourupdown
            // 
            hourupdown.Location = new Point(397, 403);
            hourupdown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            hourupdown.Name = "hourupdown";
            hourupdown.Size = new Size(40, 27);
            hourupdown.TabIndex = 26;
            hourupdown.ValueChanged += hourupdown_ValueChanged;
            // 
            // minupdown
            // 
            minupdown.Location = new Point(456, 403);
            minupdown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            minupdown.Name = "minupdown";
            minupdown.Size = new Size(40, 27);
            minupdown.TabIndex = 27;
            minupdown.ValueChanged += minupdown_ValueChanged;
            // 
            // setbot
            // 
            setbot.Enabled = false;
            setbot.Location = new Point(79, 538);
            setbot.Name = "setbot";
            setbot.Size = new Size(94, 29);
            setbot.TabIndex = 28;
            setbot.Text = "ثبت";
            setbot.UseVisualStyleBackColor = true;
            setbot.Click += setbot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 243, 238);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 90);
            panel1.TabIndex = 29;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.moneyup60;
            button2.Location = new Point(402, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 84);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.moneydown60;
            button1.Location = new Point(515, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 84);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // payWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 600);
            Controls.Add(panel1);
            Controls.Add(setbot);
            Controls.Add(minupdown);
            Controls.Add(hourupdown);
            Controls.Add(termCobox);
            Controls.Add(tracTypeCbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datetxbm);
            Controls.Add(datetxby);
            Controls.Add(statustxb);
            Controls.Add(datetxbd);
            Controls.Add(amounttxb);
            Controls.Add(tracCodetxb);
            Controls.Add(useridtbx);
            Controls.Add(tarncCode);
            Controls.Add(status);
            Controls.Add(datepay);
            Controls.Add(typePay);
            Controls.Add(timepay);
            Controls.Add(term);
            Controls.Add(amount);
            Controls.Add(userID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 4, 5, 4);
            Name = "payWindow";
            Text = "Form2";
            Load += payWindow_Load;
            ((System.ComponentModel.ISupportInitialize)hourupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minupdown).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userID;
        private Label amount;
        private Label term;
        private Label timepay;
        private Label typePay;
        private Label datepay;
        private Label status;
        private Label tarncCode;
        private TextBox useridtbx;
        private TextBox tracCodetxb;
        private TextBox amounttxb;
        private TextBox datetxbd;
        private TextBox statustxb;
        private TextBox datetxby;
        private TextBox datetxbm;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox tracTypeCbox;
        private ComboBox termCobox;
        private NumericUpDown hourupdown;
        private NumericUpDown minupdown;
        private Button setbot;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}