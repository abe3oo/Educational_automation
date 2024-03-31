
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
            userID.Location = new Point(663, 38);
            userID.Margin = new Padding(4, 0, 4, 0);
            userID.Name = "userID";
            userID.RightToLeft = RightToLeft.Yes;
            userID.Size = new Size(62, 15);
            userID.TabIndex = 0;
            userID.Text = "کد ملی:";
            userID.TextAlign = ContentAlignment.MiddleRight;
            userID.Click += userID_Click;
            // 
            // amount
            // 
            amount.Location = new Point(663, 144);
            amount.Margin = new Padding(4, 0, 4, 0);
            amount.Name = "amount";
            amount.RightToLeft = RightToLeft.Yes;
            amount.Size = new Size(77, 20);
            amount.TabIndex = 1;
            amount.Text = "مقدار تراکنش:";
            amount.TextAlign = ContentAlignment.MiddleRight;
            amount.Click += amount_Click;
            // 
            // term
            // 
            term.Location = new Point(663, 106);
            term.Margin = new Padding(4, 0, 4, 0);
            term.Name = "term";
            term.RightToLeft = RightToLeft.Yes;
            term.Size = new Size(28, 20);
            term.TabIndex = 2;
            term.Text = "ترم:";
            term.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timepay
            // 
            timepay.Location = new Point(663, 231);
            timepay.Margin = new Padding(4, 0, 4, 0);
            timepay.Name = "timepay";
            timepay.RightToLeft = RightToLeft.Yes;
            timepay.Size = new Size(74, 23);
            timepay.TabIndex = 4;
            timepay.Text = "زمان تراکنش:";
            timepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // typePay
            // 
            typePay.Location = new Point(663, 185);
            typePay.Margin = new Padding(4, 0, 4, 0);
            typePay.Name = "typePay";
            typePay.RightToLeft = RightToLeft.Yes;
            typePay.Size = new Size(74, 24);
            typePay.TabIndex = 5;
            typePay.Text = "نوع تراکنش:";
            typePay.TextAlign = ContentAlignment.MiddleRight;
            typePay.Click += typePay_Click;
            // 
            // datepay
            // 
            datepay.Location = new Point(663, 70);
            datepay.Margin = new Padding(4, 0, 4, 0);
            datepay.Name = "datepay";
            datepay.RightToLeft = RightToLeft.Yes;
            datepay.Size = new Size(82, 24);
            datepay.TabIndex = 6;
            datepay.Text = "تاریخ پرداخت:";
            datepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // status
            // 
            status.Location = new Point(316, 35);
            status.Margin = new Padding(4, 0, 4, 0);
            status.Name = "status";
            status.RightToLeft = RightToLeft.Yes;
            status.Size = new Size(82, 31);
            status.TabIndex = 7;
            status.Text = "توضیحات:";
            // 
            // tarncCode
            // 
            tarncCode.Location = new Point(663, 273);
            tarncCode.Margin = new Padding(4, 0, 4, 0);
            tarncCode.Name = "tarncCode";
            tarncCode.RightToLeft = RightToLeft.Yes;
            tarncCode.Size = new Size(62, 31);
            tarncCode.TabIndex = 8;
            tarncCode.Text = "کد پیگیری:";
            tarncCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // useridtbx
            // 
            useridtbx.Location = new Point(503, 35);
            useridtbx.Margin = new Padding(4, 3, 4, 3);
            useridtbx.MaxLength = 10;
            useridtbx.Name = "useridtbx";
            useridtbx.Size = new Size(131, 23);
            useridtbx.TabIndex = 9;
            useridtbx.TextChanged += useridtbx_TextChanged;
            useridtbx.KeyPress += useridtbx_KeyPress;
            // 
            // tractimetxbM
            // 
            tractimetxbM.Location = new Point(603, 232);
            tractimetxbM.Margin = new Padding(4, 3, 4, 3);
            tractimetxbM.Name = "tractimetxbM";
            tractimetxbM.Size = new Size(31, 23);
            tractimetxbM.TabIndex = 10;
            tractimetxbM.KeyPress += tractimetxbM_KeyPress;
            // 
            // tracCodetxb
            // 
            tracCodetxb.Location = new Point(503, 273);
            tracCodetxb.Margin = new Padding(4, 3, 4, 3);
            tracCodetxb.Name = "tracCodetxb";
            tracCodetxb.Size = new Size(131, 23);
            tracCodetxb.TabIndex = 12;
            tracCodetxb.KeyPress += tracCodetxb_KeyPress;
            // 
            // amounttxb
            // 
            amounttxb.Location = new Point(503, 144);
            amounttxb.Margin = new Padding(4, 3, 4, 3);
            amounttxb.Name = "amounttxb";
            amounttxb.Size = new Size(131, 23);
            amounttxb.TabIndex = 13;
            amounttxb.TextChanged += amounttxb_TextChanged;
            amounttxb.KeyPress += amounttxb_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(603, 69);
            datetxbd.Margin = new Padding(4, 3, 4, 3);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(31, 23);
            datetxbd.TabIndex = 15;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // statustxb
            // 
            statustxb.Location = new Point(85, 35);
            statustxb.Margin = new Padding(4, 3, 4, 3);
            statustxb.Multiline = true;
            statustxb.Name = "statustxb";
            statustxb.Size = new Size(234, 91);
            statustxb.TabIndex = 16;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(478, 67);
            datetxby.Margin = new Padding(4, 3, 4, 3);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(46, 23);
            datetxby.TabIndex = 17;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(551, 67);
            datetxbm.Margin = new Padding(4, 3, 4, 3);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(31, 23);
            datetxbm.TabIndex = 18;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // tractimetxbH
            // 
            tractimetxbH.Location = new Point(551, 232);
            tractimetxbH.Margin = new Padding(4, 3, 4, 3);
            tractimetxbH.Name = "tractimetxbH";
            tractimetxbH.Size = new Size(31, 23);
            tractimetxbH.TabIndex = 19;
            tractimetxbH.TextChanged += tractimetxbH_TextChanged;
            tractimetxbH.KeyPress += tractimetxbH_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(530, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(15, 25);
            label1.TabIndex = 20;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(588, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(15, 25);
            label2.TabIndex = 21;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(588, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(15, 25);
            label3.TabIndex = 22;
            label3.Text = ":";
            // 
            // sabtbutton
            // 
            sabtbutton.Enabled = false;
            sabtbutton.Location = new Point(244, 252);
            sabtbutton.Margin = new Padding(4, 3, 4, 3);
            sabtbutton.Name = "sabtbutton";
            sabtbutton.Size = new Size(75, 30);
            sabtbutton.TabIndex = 23;
            sabtbutton.Text = "ثبت";
            sabtbutton.UseVisualStyleBackColor = true;
            sabtbutton.Click += sabtbutton_Click;
            // 
            // tracTypeCbox
            // 
            tracTypeCbox.FormattingEnabled = true;
            tracTypeCbox.Items.AddRange(new object[] { "پرداخت", "دریافت" });
            tracTypeCbox.Location = new Point(500, 185);
            tracTypeCbox.Margin = new Padding(4, 2, 4, 2);
            tracTypeCbox.Name = "tracTypeCbox";
            tracTypeCbox.Size = new Size(134, 23);
            tracTypeCbox.TabIndex = 24;
            tracTypeCbox.SelectedIndexChanged += tracTypeCbox_SelectedIndexChanged;
            // 
            // termCobox
            // 
            termCobox.FormattingEnabled = true;
            termCobox.Items.AddRange(new object[] { "بهار", "تابستان", "پاییز", "زمستان" });
            termCobox.Location = new Point(500, 105);
            termCobox.Margin = new Padding(4, 2, 4, 2);
            termCobox.Name = "termCobox";
            termCobox.Size = new Size(134, 23);
            termCobox.TabIndex = 25;
            // 
            // payWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
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
            Margin = new Padding(4, 3, 4, 3);
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