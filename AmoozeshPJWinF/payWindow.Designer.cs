
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
            tractimetxbM = new TextBox();
            tracCodetxb = new TextBox();
            amounttxb = new TextBox();
            datetxbd = new TextBox();
            statustxb = new TextBox();
            datetxby = new TextBox();
            datetxbm = new TextBox();
            tractimetxbH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sabtbutton = new Button();
            tracTypeCbox = new ComboBox();
            termCobox = new ComboBox();
            SuspendLayout();
            // 
            // userID
            // 
            userID.Location = new Point(744, 51);
            userID.Name = "userID";
            userID.RightToLeft = RightToLeft.Yes;
            userID.Size = new Size(71, 20);
            userID.TabIndex = 0;
            userID.Text = "کد ملی:";
            // 
            // amount
            // 
            amount.Location = new Point(744, 192);
            amount.Name = "amount";
            amount.RightToLeft = RightToLeft.Yes;
            amount.Size = new Size(103, 27);
            amount.TabIndex = 1;
            amount.Text = "مقدار تراکنش:";
            // 
            // term
            // 
            term.Location = new Point(744, 140);
            term.Name = "term";
            term.RightToLeft = RightToLeft.Yes;
            term.Size = new Size(45, 20);
            term.TabIndex = 2;
            term.Text = "ترم:";
            // 
            // timepay
            // 
            timepay.Location = new Point(735, 313);
            timepay.Name = "timepay";
            timepay.RightToLeft = RightToLeft.Yes;
            timepay.Size = new Size(94, 41);
            timepay.TabIndex = 4;
            timepay.Text = "زمان تراکنش:";
            // 
            // typePay
            // 
            typePay.Location = new Point(735, 250);
            typePay.Name = "typePay";
            typePay.RightToLeft = RightToLeft.Yes;
            typePay.Size = new Size(94, 32);
            typePay.TabIndex = 5;
            typePay.Text = "نوع تراکنش:";
            // 
            // datepay
            // 
            datepay.Location = new Point(744, 96);
            datepay.Name = "datepay";
            datepay.RightToLeft = RightToLeft.Yes;
            datepay.Size = new Size(94, 32);
            datepay.TabIndex = 6;
            datepay.Text = "تاریخ پرداخت:";
            // 
            // status
            // 
            status.Location = new Point(361, 47);
            status.Name = "status";
            status.RightToLeft = RightToLeft.Yes;
            status.Size = new Size(94, 41);
            status.TabIndex = 7;
            status.Text = "توضیحات:";
            // 
            // tarncCode
            // 
            tarncCode.Location = new Point(744, 365);
            tarncCode.Name = "tarncCode";
            tarncCode.RightToLeft = RightToLeft.Yes;
            tarncCode.Size = new Size(71, 41);
            tarncCode.TabIndex = 8;
            tarncCode.Text = "کد پیگیری:";
            // 
            // useridtbx
            // 
            useridtbx.Location = new Point(575, 47);
            useridtbx.Margin = new Padding(3, 4, 3, 4);
            useridtbx.MaxLength = 10;
            useridtbx.Name = "useridtbx";
            useridtbx.Size = new Size(149, 27);
            useridtbx.TabIndex = 9;
            useridtbx.TextChanged += useridtbx_TextChanged;
            useridtbx.KeyPress += useridtbx_KeyPress;
            // 
            // tractimetxbM
            // 
            tractimetxbM.Location = new Point(689, 309);
            tractimetxbM.Margin = new Padding(3, 4, 3, 4);
            tractimetxbM.Name = "tractimetxbM";
            tractimetxbM.Size = new Size(35, 27);
            tractimetxbM.TabIndex = 10;
            tractimetxbM.KeyPress += tractimetxbM_KeyPress;
            // 
            // tracCodetxb
            // 
            tracCodetxb.Location = new Point(575, 365);
            tracCodetxb.Margin = new Padding(3, 4, 3, 4);
            tracCodetxb.Name = "tracCodetxb";
            tracCodetxb.Size = new Size(149, 27);
            tracCodetxb.TabIndex = 12;
            tracCodetxb.KeyPress += tracCodetxb_KeyPress;
            // 
            // amounttxb
            // 
            amounttxb.Location = new Point(575, 192);
            amounttxb.Margin = new Padding(3, 4, 3, 4);
            amounttxb.Name = "amounttxb";
            amounttxb.Size = new Size(149, 27);
            amounttxb.TabIndex = 13;
            amounttxb.KeyPress += amounttxb_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(689, 92);
            datetxbd.Margin = new Padding(3, 4, 3, 4);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 15;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // statustxb
            // 
            statustxb.Location = new Point(97, 47);
            statustxb.Margin = new Padding(3, 4, 3, 4);
            statustxb.Multiline = true;
            statustxb.Name = "statustxb";
            statustxb.Size = new Size(267, 119);
            statustxb.TabIndex = 16;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(546, 89);
            datetxby.Margin = new Padding(3, 4, 3, 4);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(52, 27);
            datetxby.TabIndex = 17;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(630, 89);
            datetxbm.Margin = new Padding(3, 4, 3, 4);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 18;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // tractimetxbH
            // 
            tractimetxbH.Location = new Point(630, 309);
            tractimetxbH.Margin = new Padding(3, 4, 3, 4);
            tractimetxbH.Name = "tractimetxbH";
            tractimetxbH.Size = new Size(35, 27);
            tractimetxbH.TabIndex = 19;
            tractimetxbH.TextChanged += tractimetxbH_TextChanged;
            tractimetxbH.KeyPress += tractimetxbH_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 89);
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
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(17, 33);
            label3.TabIndex = 22;
            label3.Text = ":";
            // 
            // sabtbutton
            // 
            sabtbutton.Enabled = false;
            sabtbutton.Location = new Point(279, 336);
            sabtbutton.Margin = new Padding(3, 4, 3, 4);
            sabtbutton.Name = "sabtbutton";
            sabtbutton.Size = new Size(86, 40);
            sabtbutton.TabIndex = 23;
            sabtbutton.Text = "ثبت";
            sabtbutton.UseVisualStyleBackColor = true;
            sabtbutton.Click += sabtbutton_Click;
            // 
            // tracTypeCbox
            // 
            tracTypeCbox.FormattingEnabled = true;
            tracTypeCbox.Items.AddRange(new object[] { "پرداخت", "دریافت" });
            tracTypeCbox.Location = new Point(573, 247);
            tracTypeCbox.Name = "tracTypeCbox";
            tracTypeCbox.Size = new Size(151, 28);
            tracTypeCbox.TabIndex = 24;
            tracTypeCbox.SelectedIndexChanged += tracTypeCbox_SelectedIndexChanged;
            // 
            // termCobox
            // 
            termCobox.FormattingEnabled = true;
            termCobox.Items.AddRange(new object[] { "بهار", "تابستان", "پاییز", "زمستان" });
            termCobox.Location = new Point(573, 140);
            termCobox.Name = "termCobox";
            termCobox.Size = new Size(151, 28);
            termCobox.TabIndex = 25;
            // 
            // payWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 600);
            Controls.Add(termCobox);
            Controls.Add(tracTypeCbox);
            Controls.Add(sabtbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tractimetxbH);
            Controls.Add(datetxbm);
            Controls.Add(datetxby);
            Controls.Add(statustxb);
            Controls.Add(datetxbd);
            Controls.Add(amounttxb);
            Controls.Add(tracCodetxb);
            Controls.Add(tractimetxbM);
            Controls.Add(useridtbx);
            Controls.Add(tarncCode);
            Controls.Add(status);
            Controls.Add(datepay);
            Controls.Add(typePay);
            Controls.Add(timepay);
            Controls.Add(term);
            Controls.Add(amount);
            Controls.Add(userID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "payWindow";
            Text = "Form2";
            Load += payWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void sabtbutton_Click(object sender, EventArgs e)
        {
            DBC dpay = new DBC();
            if (dpay.id_check(useridtbx.Text) == true)
            {
                if (useridtbx.Text != "" && datetxby.Text != "" && datetxbm.Text != "" && datetxbd.Text != "" && termCobox.Text != "" && amounttxb.Text != ""
                       && tracTypeCbox.Text != "" && tractimetxbH.Text != "" && tractimetxbM.Text != "" &&
                      tracCodetxb.Text != "")
                {
                    Payment p1 = new Payment();

                    p1.userid = Convert.ToInt64(useridtbx.Text);
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
                    if (tracTypeCbox.SelectedIndex == 0)
                    {
                        p1.transactionstatus = false;
                    }
                    else if (tracTypeCbox.SelectedIndex == 1)
                    {
                        p1.transactionstatus = true;
                    }
                    TimeSpan time = new TimeSpan(Convert.ToInt16(tractimetxbH.Text), Convert.ToInt16(tractimetxbM.Text), 0);
                    p1.tarckingtime = time;
                    p1.trackingcode = Convert.ToInt64(tracCodetxb.Text);
                    p1.description = statustxb.Text;

                    dpay.pay_set(p1);

                    MessageBox.Show("ثبت با موفقیت انجام شد");

                    clear_textbox(useridtbx);
                    clear_textbox(datetxby);
                    clear_textbox(datetxbm);
                    clear_textbox(datetxbd);
                    clear_textbox(amounttxb);
                    clear_textbox(tractimetxbH);
                    clear_textbox(tractimetxbM);
                    clear_textbox(tracCodetxb);
                    clear_textbox(statustxb);
                    termCobox.Text = string.Empty;
                    tracTypeCbox.Text = string.Empty;

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
        private TextBox tractimetxbM;
        private TextBox tracCodetxb;
        private TextBox amounttxb;
        private TextBox datetxbd;
        private TextBox statustxb;
        private TextBox datetxby;
        private TextBox datetxbm;
        private TextBox tractimetxbH;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button sabtbutton;
        private ComboBox tracTypeCbox;
        private ComboBox termCobox;
    }
}