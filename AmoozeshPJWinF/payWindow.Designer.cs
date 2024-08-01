
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
            ((System.ComponentModel.ISupportInitialize)hourupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minupdown).BeginInit();
            SuspendLayout();
            // 
            // userID
            // 
            userID.Location = new Point(758, 51);
            userID.Margin = new Padding(5, 0, 5, 0);
            userID.Name = "userID";
            userID.RightToLeft = RightToLeft.Yes;
            userID.Size = new Size(71, 20);
            userID.TabIndex = 0;
            userID.Text = "کد ملی:";
            userID.TextAlign = ContentAlignment.MiddleRight;
            userID.Click += userID_Click;
            // 
            // amount
            // 
            amount.Location = new Point(758, 192);
            amount.Margin = new Padding(5, 0, 5, 0);
            amount.Name = "amount";
            amount.RightToLeft = RightToLeft.Yes;
            amount.Size = new Size(88, 27);
            amount.TabIndex = 1;
            amount.Text = "مقدار تراکنش:";
            amount.TextAlign = ContentAlignment.MiddleRight;
            amount.Click += amount_Click;
            // 
            // term
            // 
            term.Location = new Point(758, 141);
            term.Margin = new Padding(5, 0, 5, 0);
            term.Name = "term";
            term.RightToLeft = RightToLeft.Yes;
            term.Size = new Size(32, 27);
            term.TabIndex = 2;
            term.Text = "ترم:";
            term.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timepay
            // 
            timepay.Location = new Point(758, 308);
            timepay.Margin = new Padding(5, 0, 5, 0);
            timepay.Name = "timepay";
            timepay.RightToLeft = RightToLeft.Yes;
            timepay.Size = new Size(85, 31);
            timepay.TabIndex = 4;
            timepay.Text = "زمان تراکنش:";
            timepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // typePay
            // 
            typePay.Location = new Point(758, 247);
            typePay.Margin = new Padding(5, 0, 5, 0);
            typePay.Name = "typePay";
            typePay.RightToLeft = RightToLeft.Yes;
            typePay.Size = new Size(85, 32);
            typePay.TabIndex = 5;
            typePay.Text = "نوع تراکنش:";
            typePay.TextAlign = ContentAlignment.MiddleRight;
            typePay.Click += typePay_Click;
            // 
            // datepay
            // 
            datepay.Location = new Point(758, 93);
            datepay.Margin = new Padding(5, 0, 5, 0);
            datepay.Name = "datepay";
            datepay.RightToLeft = RightToLeft.Yes;
            datepay.Size = new Size(94, 32);
            datepay.TabIndex = 6;
            datepay.Text = "تاریخ پرداخت:";
            datepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // status
            // 
            status.Location = new Point(361, 47);
            status.Margin = new Padding(5, 0, 5, 0);
            status.Name = "status";
            status.RightToLeft = RightToLeft.Yes;
            status.Size = new Size(94, 41);
            status.TabIndex = 7;
            status.Text = "توضیحات:";
            // 
            // tarncCode
            // 
            tarncCode.Location = new Point(758, 364);
            tarncCode.Margin = new Padding(5, 0, 5, 0);
            tarncCode.Name = "tarncCode";
            tarncCode.RightToLeft = RightToLeft.Yes;
            tarncCode.Size = new Size(71, 41);
            tarncCode.TabIndex = 8;
            tarncCode.Text = "کد پیگیری:";
            tarncCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // useridtbx
            // 
            useridtbx.Location = new Point(575, 47);
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
            tracCodetxb.Location = new Point(575, 364);
            tracCodetxb.Margin = new Padding(5, 4, 5, 4);
            tracCodetxb.Name = "tracCodetxb";
            tracCodetxb.Size = new Size(149, 27);
            tracCodetxb.TabIndex = 12;
            tracCodetxb.KeyPress += tracCodetxb_KeyPress;
            // 
            // amounttxb
            // 
            amounttxb.Location = new Point(575, 192);
            amounttxb.Margin = new Padding(5, 4, 5, 4);
            amounttxb.Name = "amounttxb";
            amounttxb.Size = new Size(149, 27);
            amounttxb.TabIndex = 13;
            amounttxb.TextChanged += amounttxb_TextChanged;
            amounttxb.KeyPress += amounttxb_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(689, 92);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 15;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // statustxb
            // 
            statustxb.Location = new Point(97, 47);
            statustxb.Margin = new Padding(5, 4, 5, 4);
            statustxb.Multiline = true;
            statustxb.Name = "statustxb";
            statustxb.Size = new Size(267, 120);
            statustxb.TabIndex = 16;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(546, 89);
            datetxby.Margin = new Padding(5, 4, 5, 4);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(52, 27);
            datetxby.TabIndex = 17;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(630, 89);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 18;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 89);
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
            label2.Location = new Point(672, 89);
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
            label3.Location = new Point(672, 307);
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
            tracTypeCbox.Location = new Point(571, 247);
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
            termCobox.Location = new Point(571, 140);
            termCobox.Margin = new Padding(5, 3, 5, 3);
            termCobox.Name = "termCobox";
            termCobox.Size = new Size(153, 28);
            termCobox.TabIndex = 25;
            // 
            // hourupdown
            // 
            hourupdown.Location = new Point(630, 311);
            hourupdown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            hourupdown.Name = "hourupdown";
            hourupdown.Size = new Size(40, 27);
            hourupdown.TabIndex = 26;
            hourupdown.ValueChanged += hourupdown_ValueChanged;
            // 
            // minupdown
            // 
            minupdown.Location = new Point(689, 311);
            minupdown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            minupdown.Name = "minupdown";
            minupdown.Size = new Size(40, 27);
            minupdown.TabIndex = 27;
            minupdown.ValueChanged += minupdown_ValueChanged;
            // 
            // setbot
            // 
            setbot.Enabled = false;
            setbot.Location = new Point(209, 406);
            setbot.Name = "setbot";
            setbot.Size = new Size(94, 29);
            setbot.TabIndex = 28;
            setbot.Text = "ثبت";
            setbot.UseVisualStyleBackColor = true;
            setbot.Click += setbot_Click;
            // 
            // payWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 600);
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
    }
}