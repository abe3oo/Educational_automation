
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payWindow));
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
            panelcolorselect = new Panel();
            personlbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            namepictureBox = new PictureBox();
            idpictureBox = new PictureBox();
            namelbl = new Label();
            idlbl = new Label();
            pardakhtbot = new Button();
            daryaftbot = new Button();
            ((System.ComponentModel.ISupportInitialize)hourupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minupdown).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)namepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idpictureBox).BeginInit();
            SuspendLayout();
            // 
            // amount
            // 
            amount.BackColor = Color.Transparent;
            amount.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            amount.Location = new Point(521, 243);
            amount.Margin = new Padding(5, 0, 5, 0);
            amount.Name = "amount";
            amount.RightToLeft = RightToLeft.No;
            amount.Size = new Size(50, 27);
            amount.TabIndex = 1;
            amount.Text = "مقدار تراکنش";
            amount.TextAlign = ContentAlignment.MiddleRight;
            amount.Click += amount_Click;
            // 
            // term
            // 
            term.BackColor = Color.Transparent;
            term.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            term.Location = new Point(539, 191);
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
            timepay.BackColor = Color.Transparent;
            timepay.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            timepay.Location = new Point(529, 291);
            timepay.Margin = new Padding(5, 0, 5, 0);
            timepay.Name = "timepay";
            timepay.RightToLeft = RightToLeft.No;
            timepay.Size = new Size(42, 31);
            timepay.TabIndex = 4;
            timepay.Text = "زمان تراکنش";
            timepay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // typePay
            // 
            typePay.BackColor = Color.Transparent;
            typePay.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            typePay.Location = new Point(189, 289);
            typePay.Margin = new Padding(5, 0, 5, 0);
            typePay.Name = "typePay";
            typePay.RightToLeft = RightToLeft.No;
            typePay.Size = new Size(88, 32);
            typePay.TabIndex = 5;
            typePay.Text = "نوع تراکنش";
            typePay.TextAlign = ContentAlignment.MiddleRight;
            typePay.Visible = false;
            typePay.Click += typePay_Click;
            // 
            // datepay
            // 
            datepay.BackColor = Color.Transparent;
            datepay.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            datepay.Location = new Point(479, 139);
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
            status.BackColor = Color.Transparent;
            status.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            status.Location = new Point(210, 132);
            status.Margin = new Padding(5, 0, 5, 0);
            status.Name = "status";
            status.RightToLeft = RightToLeft.No;
            status.Size = new Size(80, 29);
            status.TabIndex = 7;
            status.Text = "توضیحات";
            // 
            // tarncCode
            // 
            tarncCode.BackColor = Color.Transparent;
            tarncCode.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            tarncCode.Location = new Point(488, 335);
            tarncCode.Margin = new Padding(5, 0, 5, 0);
            tarncCode.Name = "tarncCode";
            tarncCode.RightToLeft = RightToLeft.No;
            tarncCode.Size = new Size(85, 41);
            tarncCode.TabIndex = 8;
            tarncCode.Text = "کد پیگیری";
            tarncCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // useridtbx
            // 
            useridtbx.Location = new Point(24, 13);
            useridtbx.Margin = new Padding(5, 4, 5, 4);
            useridtbx.MaxLength = 10;
            useridtbx.Name = "useridtbx";
            useridtbx.Size = new Size(283, 27);
            useridtbx.TabIndex = 9;
            useridtbx.TextChanged += useridtbx_TextChanged;
            useridtbx.KeyPress += useridtbx_KeyPress;
            // 
            // tracCodetxb
            // 
            tracCodetxb.Location = new Point(329, 342);
            tracCodetxb.Margin = new Padding(5, 4, 5, 4);
            tracCodetxb.Name = "tracCodetxb";
            tracCodetxb.Size = new Size(149, 27);
            tracCodetxb.TabIndex = 12;
            tracCodetxb.KeyPress += tracCodetxb_KeyPress;
            // 
            // amounttxb
            // 
            amounttxb.Location = new Point(329, 241);
            amounttxb.Margin = new Padding(5, 4, 5, 4);
            amounttxb.Name = "amounttxb";
            amounttxb.Size = new Size(149, 27);
            amounttxb.TabIndex = 13;
            amounttxb.TextChanged += amounttxb_TextChanged;
            amounttxb.KeyPress += amounttxb_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(443, 142);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 15;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // statustxb
            // 
            statustxb.Location = new Point(10, 165);
            statustxb.Margin = new Padding(5, 4, 5, 4);
            statustxb.Multiline = true;
            statustxb.Name = "statustxb";
            statustxb.RightToLeft = RightToLeft.Yes;
            statustxb.Size = new Size(267, 120);
            statustxb.TabIndex = 16;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(300, 142);
            datetxby.Margin = new Padding(5, 4, 5, 4);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(52, 27);
            datetxby.TabIndex = 17;
            datetxby.TextAlign = HorizontalAlignment.Center;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(381, 142);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 18;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 138);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(17, 33);
            label1.TabIndex = 20;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 138);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(17, 33);
            label2.TabIndex = 21;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(421, 283);
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
            tracTypeCbox.Location = new Point(29, 291);
            tracTypeCbox.Margin = new Padding(5, 3, 5, 3);
            tracTypeCbox.Name = "tracTypeCbox";
            tracTypeCbox.Size = new Size(153, 28);
            tracTypeCbox.TabIndex = 24;
            tracTypeCbox.Visible = false;
            tracTypeCbox.SelectedIndexChanged += tracTypeCbox_SelectedIndexChanged;
            // 
            // termCobox
            // 
            termCobox.DropDownStyle = ComboBoxStyle.DropDownList;
            termCobox.FormattingEnabled = true;
            termCobox.Items.AddRange(new object[] { "بهار", "تابستان", "پاییز", "زمستان" });
            termCobox.Location = new Point(325, 191);
            termCobox.Margin = new Padding(5, 3, 5, 3);
            termCobox.Name = "termCobox";
            termCobox.Size = new Size(153, 28);
            termCobox.TabIndex = 25;
            // 
            // hourupdown
            // 
            hourupdown.Location = new Point(379, 289);
            hourupdown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            hourupdown.Name = "hourupdown";
            hourupdown.Size = new Size(40, 27);
            hourupdown.TabIndex = 26;
            hourupdown.ValueChanged += hourupdown_ValueChanged;
            // 
            // minupdown
            // 
            minupdown.Location = new Point(438, 289);
            minupdown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            minupdown.Name = "minupdown";
            minupdown.Size = new Size(40, 27);
            minupdown.TabIndex = 27;
            minupdown.ValueChanged += minupdown_ValueChanged;
            // 
            // setbot
            // 
            setbot.Enabled = false;
            setbot.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            setbot.Location = new Point(75, 349);
            setbot.Name = "setbot";
            setbot.Size = new Size(107, 52);
            setbot.TabIndex = 28;
            setbot.Text = "ثبت";
            setbot.UseVisualStyleBackColor = true;
            setbot.Click += setbot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 243, 238);
            panel1.Controls.Add(panelcolorselect);
            panel1.Controls.Add(personlbl);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(pardakhtbot);
            panel1.Controls.Add(daryaftbot);
            panel1.Controls.Add(useridtbx);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 119);
            panel1.TabIndex = 29;
            // 
            // panelcolorselect
            // 
            panelcolorselect.BackColor = Color.FromArgb(224, 175, 160);
            panelcolorselect.Location = new Point(490, 109);
            panelcolorselect.Name = "panelcolorselect";
            panelcolorselect.Size = new Size(94, 10);
            panelcolorselect.TabIndex = 30;
            panelcolorselect.Visible = false;
            // 
            // personlbl
            // 
            personlbl.AutoSize = true;
            personlbl.BackColor = Color.Transparent;
            personlbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            personlbl.Location = new Point(325, 16);
            personlbl.Name = "personlbl";
            personlbl.Size = new Size(40, 27);
            personlbl.TabIndex = 13;
            personlbl.Text = "کاربر";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(namepictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(idpictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(namelbl, 1, 0);
            tableLayoutPanel1.Controls.Add(idlbl, 1, 1);
            tableLayoutPanel1.Location = new Point(24, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(283, 70);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // namepictureBox
            // 
            namepictureBox.BackColor = Color.Transparent;
            namepictureBox.Location = new Point(256, 3);
            namepictureBox.Name = "namepictureBox";
            namepictureBox.Size = new Size(24, 31);
            namepictureBox.TabIndex = 10;
            namepictureBox.TabStop = false;
            // 
            // idpictureBox
            // 
            idpictureBox.BackColor = Color.Transparent;
            idpictureBox.Location = new Point(256, 40);
            idpictureBox.Name = "idpictureBox";
            idpictureBox.Size = new Size(24, 30);
            idpictureBox.TabIndex = 11;
            idpictureBox.TabStop = false;
            // 
            // namelbl
            // 
            namelbl.Anchor = AnchorStyles.Left;
            namelbl.AutoSize = true;
            namelbl.BackColor = Color.Transparent;
            namelbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            namelbl.Location = new Point(209, 5);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(41, 27);
            namelbl.TabIndex = 12;
            namelbl.Text = "خالی";
            namelbl.Visible = false;
            // 
            // idlbl
            // 
            idlbl.Anchor = AnchorStyles.Left;
            idlbl.AutoSize = true;
            idlbl.BackColor = Color.Transparent;
            idlbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            idlbl.Location = new Point(209, 41);
            idlbl.Name = "idlbl";
            idlbl.Size = new Size(41, 27);
            idlbl.TabIndex = 13;
            idlbl.Text = "خالی";
            idlbl.Visible = false;
            idlbl.TextChanged += idlbl_TextChanged;
            idlbl.Click += idlbl_Click;
            // 
            // pardakhtbot
            // 
            pardakhtbot.FlatAppearance.BorderSize = 0;
            pardakhtbot.FlatStyle = FlatStyle.Flat;
            pardakhtbot.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            pardakhtbot.Location = new Point(490, 3);
            pardakhtbot.Name = "pardakhtbot";
            pardakhtbot.Size = new Size(94, 113);
            pardakhtbot.TabIndex = 1;
            pardakhtbot.Text = "پرداخت";
            pardakhtbot.TextImageRelation = TextImageRelation.ImageAboveText;
            pardakhtbot.UseVisualStyleBackColor = true;
            pardakhtbot.Click += pardakhtbot_Click;
            // 
            // daryaftbot
            // 
            daryaftbot.BackColor = Color.Transparent;
            daryaftbot.FlatAppearance.BorderSize = 0;
            daryaftbot.FlatStyle = FlatStyle.Flat;
            daryaftbot.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            daryaftbot.Location = new Point(397, 3);
            daryaftbot.Name = "daryaftbot";
            daryaftbot.Size = new Size(94, 109);
            daryaftbot.TabIndex = 0;
            daryaftbot.Text = "دریافت";
            daryaftbot.TextImageRelation = TextImageRelation.ImageAboveText;
            daryaftbot.UseVisualStyleBackColor = false;
            daryaftbot.Click += daryaftbot_Click;
            // 
            // payWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(585, 413);
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
            Controls.Add(tarncCode);
            Controls.Add(status);
            Controls.Add(datepay);
            Controls.Add(typePay);
            Controls.Add(timepay);
            Controls.Add(term);
            Controls.Add(amount);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "payWindow";
            Text = "پرداخت";
            Load += payWindow_Load;
            ((System.ComponentModel.ISupportInitialize)hourupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minupdown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)namepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)idpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button pardakhtbot;
        private Button daryaftbot;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox idpictureBox;
        private PictureBox namepictureBox;
        private Label namelbl;
        private Label idlbl;
        private Label personlbl;
        private Panel panelcolorselect;
    }
}