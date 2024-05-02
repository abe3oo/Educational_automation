namespace AmoozeshPJWinF
{
    partial class AddUserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TypeCbox = new ComboBox();
            groupBoxsame = new GroupBox();
            checkbot = new Button();
            picturebot = new Button();
            pictureBox1 = new PictureBox();
            checkBoxWA = new CheckBox();
            educationlabel = new Label();
            Fieldlabel = new Label();
            WAnamberlabel = new Label();
            NumberLabel = new Label();
            Agelabel = new Label();
            Lnamelabel = new Label();
            Fnamelabel = new Label();
            idlabel = new Label();
            educationCbox = new ComboBox();
            Fieldbox = new TextBox();
            WAnumberbox = new TextBox();
            Numberbox = new TextBox();
            Agebox = new TextBox();
            Lnamebox = new TextBox();
            Fnamebox = new TextBox();
            Idbox = new TextBox();
            groupBoxSt = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ClasstypeCbox = new ComboBox();
            Jobbox = new TextBox();
            Citybox = new TextBox();
            MaritalCbox = new ComboBox();
            groupBoxTch = new GroupBox();
            Dayenterybox = new TextBox();
            Monthenterybox = new TextBox();
            Yearenterybox = new TextBox();
            entrylabel = new Label();
            Presencerecordbox = new TextBox();
            Presencerecordlabel = new Label();
            Setbutton = new Button();
            addradioButton = new RadioButton();
            editradioButton = new RadioButton();
            groupBoxsame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxSt.SuspendLayout();
            groupBoxTch.SuspendLayout();
            SuspendLayout();
            // 
            // TypeCbox
            // 
            TypeCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeCbox.FormattingEnabled = true;
            TypeCbox.Items.AddRange(new object[] { "استاد", "دانشجو" });
            TypeCbox.Location = new Point(585, 33);
            TypeCbox.Name = "TypeCbox";
            TypeCbox.Size = new Size(151, 28);
            TypeCbox.TabIndex = 0;
            TypeCbox.SelectedIndexChanged += TypeCbox_SelectedIndexChanged;
            // 
            // groupBoxsame
            // 
            groupBoxsame.Controls.Add(checkbot);
            groupBoxsame.Controls.Add(picturebot);
            groupBoxsame.Controls.Add(pictureBox1);
            groupBoxsame.Controls.Add(checkBoxWA);
            groupBoxsame.Controls.Add(educationlabel);
            groupBoxsame.Controls.Add(Fieldlabel);
            groupBoxsame.Controls.Add(WAnamberlabel);
            groupBoxsame.Controls.Add(NumberLabel);
            groupBoxsame.Controls.Add(Agelabel);
            groupBoxsame.Controls.Add(Lnamelabel);
            groupBoxsame.Controls.Add(Fnamelabel);
            groupBoxsame.Controls.Add(idlabel);
            groupBoxsame.Controls.Add(educationCbox);
            groupBoxsame.Controls.Add(Fieldbox);
            groupBoxsame.Controls.Add(WAnumberbox);
            groupBoxsame.Controls.Add(Numberbox);
            groupBoxsame.Controls.Add(Agebox);
            groupBoxsame.Controls.Add(Lnamebox);
            groupBoxsame.Controls.Add(Fnamebox);
            groupBoxsame.Controls.Add(Idbox);
            groupBoxsame.Location = new Point(37, 21);
            groupBoxsame.Name = "groupBoxsame";
            groupBoxsame.Size = new Size(533, 323);
            groupBoxsame.TabIndex = 1;
            groupBoxsame.TabStop = false;
            groupBoxsame.Visible = false;
            // 
            // checkbot
            // 
            checkbot.Enabled = false;
            checkbot.Location = new Point(267, 25);
            checkbot.Name = "checkbot";
            checkbot.Size = new Size(61, 29);
            checkbot.TabIndex = 17;
            checkbot.Text = "check";
            checkbot.UseVisualStyleBackColor = true;
            checkbot.Visible = false;
            checkbot.Click += checkbot_Click;
            // 
            // picturebot
            // 
            picturebot.Location = new Point(417, 196);
            picturebot.Name = "picturebot";
            picturebot.Size = new Size(101, 29);
            picturebot.TabIndex = 5;
            picturebot.Text = "انتخاب عکس";
            picturebot.UseVisualStyleBackColor = true;
            picturebot.Click += picturebot_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(395, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBoxWA
            // 
            checkBoxWA.AutoSize = true;
            checkBoxWA.Location = new Point(158, 196);
            checkBoxWA.Name = "checkBoxWA";
            checkBoxWA.Size = new Size(18, 17);
            checkBoxWA.TabIndex = 16;
            checkBoxWA.UseVisualStyleBackColor = true;
            checkBoxWA.CheckedChanged += checkBoxWA_CheckedChanged;
            // 
            // educationlabel
            // 
            educationlabel.AutoSize = true;
            educationlabel.Location = new Point(182, 260);
            educationlabel.Name = "educationlabel";
            educationlabel.RightToLeft = RightToLeft.Yes;
            educationlabel.Size = new Size(112, 20);
            educationlabel.TabIndex = 15;
            educationlabel.Text = "سطح تحصیلات :";
            // 
            // Fieldlabel
            // 
            Fieldlabel.AutoSize = true;
            Fieldlabel.Location = new Point(182, 227);
            Fieldlabel.Name = "Fieldlabel";
            Fieldlabel.RightToLeft = RightToLeft.Yes;
            Fieldlabel.Size = new Size(47, 20);
            Fieldlabel.TabIndex = 14;
            Fieldlabel.Text = "رشته :";
            // 
            // WAnamberlabel
            // 
            WAnamberlabel.AutoSize = true;
            WAnamberlabel.Location = new Point(182, 195);
            WAnamberlabel.Name = "WAnamberlabel";
            WAnamberlabel.RightToLeft = RightToLeft.Yes;
            WAnamberlabel.Size = new Size(147, 20);
            WAnamberlabel.TabIndex = 13;
            WAnamberlabel.Text = "شماره واتس اپ مجزا :";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Location = new Point(182, 161);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.RightToLeft = RightToLeft.Yes;
            NumberLabel.Size = new Size(55, 20);
            NumberLabel.TabIndex = 12;
            NumberLabel.Text = "شماره :";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Location = new Point(182, 128);
            Agelabel.Name = "Agelabel";
            Agelabel.RightToLeft = RightToLeft.Yes;
            Agelabel.Size = new Size(39, 20);
            Agelabel.TabIndex = 11;
            Agelabel.Text = "سن :";
            // 
            // Lnamelabel
            // 
            Lnamelabel.AutoSize = true;
            Lnamelabel.Location = new Point(182, 95);
            Lnamelabel.Name = "Lnamelabel";
            Lnamelabel.RightToLeft = RightToLeft.Yes;
            Lnamelabel.Size = new Size(97, 20);
            Lnamelabel.TabIndex = 10;
            Lnamelabel.Text = "نام خانوادگی :";
            // 
            // Fnamelabel
            // 
            Fnamelabel.AutoSize = true;
            Fnamelabel.Location = new Point(182, 61);
            Fnamelabel.Name = "Fnamelabel";
            Fnamelabel.RightToLeft = RightToLeft.Yes;
            Fnamelabel.Size = new Size(34, 20);
            Fnamelabel.TabIndex = 9;
            Fnamelabel.Text = "نام :";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(182, 29);
            idlabel.Name = "idlabel";
            idlabel.RightToLeft = RightToLeft.Yes;
            idlabel.Size = new Size(63, 20);
            idlabel.TabIndex = 8;
            idlabel.Text = "کد ملی :";
            idlabel.Click += idlabel_Click;
            // 
            // educationCbox
            // 
            educationCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            educationCbox.FormattingEnabled = true;
            educationCbox.Items.AddRange(new object[] { "دانش آموز", "سیکل", "دیپلم", "فوق دیپلم", "لیسانس", "فوق لیسانس", "دکترا" });
            educationCbox.Location = new Point(22, 257);
            educationCbox.Name = "educationCbox";
            educationCbox.Size = new Size(125, 28);
            educationCbox.TabIndex = 7;
            // 
            // Fieldbox
            // 
            Fieldbox.Location = new Point(22, 224);
            Fieldbox.Name = "Fieldbox";
            Fieldbox.Size = new Size(125, 27);
            Fieldbox.TabIndex = 6;
            Fieldbox.KeyPress += Fieldbox_KeyPress;
            // 
            // WAnumberbox
            // 
            WAnumberbox.Enabled = false;
            WAnumberbox.Location = new Point(22, 191);
            WAnumberbox.Name = "WAnumberbox";
            WAnumberbox.Size = new Size(125, 27);
            WAnumberbox.TabIndex = 5;
            WAnumberbox.KeyPress += WAnumberbox_KeyPress;
            // 
            // Numberbox
            // 
            Numberbox.Location = new Point(22, 157);
            Numberbox.Name = "Numberbox";
            Numberbox.Size = new Size(125, 27);
            Numberbox.TabIndex = 4;
            Numberbox.KeyPress += Numberbox_KeyPress;
            // 
            // Agebox
            // 
            Agebox.Location = new Point(22, 125);
            Agebox.Name = "Agebox";
            Agebox.Size = new Size(125, 27);
            Agebox.TabIndex = 3;
            Agebox.TextChanged += Agebox_TextChanged;
            Agebox.KeyPress += Agebox_KeyPress;
            // 
            // Lnamebox
            // 
            Lnamebox.Location = new Point(22, 92);
            Lnamebox.Name = "Lnamebox";
            Lnamebox.Size = new Size(125, 27);
            Lnamebox.TabIndex = 2;
            Lnamebox.KeyPress += Lnamebox_KeyPress;
            // 
            // Fnamebox
            // 
            Fnamebox.Location = new Point(22, 59);
            Fnamebox.Name = "Fnamebox";
            Fnamebox.Size = new Size(125, 27);
            Fnamebox.TabIndex = 1;
            Fnamebox.KeyPress += Fnamebox_KeyPress;
            // 
            // Idbox
            // 
            Idbox.Location = new Point(22, 27);
            Idbox.MaxLength = 10;
            Idbox.Name = "Idbox";
            Idbox.Size = new Size(125, 27);
            Idbox.TabIndex = 0;
            Idbox.TextChanged += Idbox_TextChanged;
            Idbox.KeyPress += Idbox_KeyPress;
            // 
            // groupBoxSt
            // 
            groupBoxSt.Controls.Add(label4);
            groupBoxSt.Controls.Add(label3);
            groupBoxSt.Controls.Add(label2);
            groupBoxSt.Controls.Add(label1);
            groupBoxSt.Controls.Add(ClasstypeCbox);
            groupBoxSt.Controls.Add(Jobbox);
            groupBoxSt.Controls.Add(Citybox);
            groupBoxSt.Controls.Add(MaritalCbox);
            groupBoxSt.Location = new Point(405, 369);
            groupBoxSt.Name = "groupBoxSt";
            groupBoxSt.Size = new Size(331, 156);
            groupBoxSt.TabIndex = 2;
            groupBoxSt.TabStop = false;
            groupBoxSt.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 119);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(77, 20);
            label4.TabIndex = 19;
            label4.Text = "نوع کلاس :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 85);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(48, 20);
            label3.TabIndex = 18;
            label3.Text = "شغل :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 53);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(43, 20);
            label2.TabIndex = 17;
            label2.Text = "شهر :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(100, 20);
            label1.TabIndex = 16;
            label1.Text = "وضعیت تاهل :";
            // 
            // ClasstypeCbox
            // 
            ClasstypeCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClasstypeCbox.FormattingEnabled = true;
            ClasstypeCbox.Items.AddRange(new object[] { "حضوری", "مجازی" });
            ClasstypeCbox.Location = new Point(22, 116);
            ClasstypeCbox.Name = "ClasstypeCbox";
            ClasstypeCbox.Size = new Size(125, 28);
            ClasstypeCbox.TabIndex = 3;
            // 
            // Jobbox
            // 
            Jobbox.Location = new Point(22, 83);
            Jobbox.Name = "Jobbox";
            Jobbox.Size = new Size(125, 27);
            Jobbox.TabIndex = 2;
            Jobbox.KeyPress += Jobbox_KeyPress;
            // 
            // Citybox
            // 
            Citybox.Location = new Point(22, 51);
            Citybox.Name = "Citybox";
            Citybox.Size = new Size(125, 27);
            Citybox.TabIndex = 1;
            Citybox.KeyPress += Citybox_KeyPress;
            // 
            // MaritalCbox
            // 
            MaritalCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            MaritalCbox.FormattingEnabled = true;
            MaritalCbox.Items.AddRange(new object[] { "مجرد", "متاهل" });
            MaritalCbox.Location = new Point(22, 16);
            MaritalCbox.Name = "MaritalCbox";
            MaritalCbox.Size = new Size(125, 28);
            MaritalCbox.TabIndex = 0;
            // 
            // groupBoxTch
            // 
            groupBoxTch.Controls.Add(Dayenterybox);
            groupBoxTch.Controls.Add(Monthenterybox);
            groupBoxTch.Controls.Add(Yearenterybox);
            groupBoxTch.Controls.Add(entrylabel);
            groupBoxTch.Controls.Add(Presencerecordbox);
            groupBoxTch.Controls.Add(Presencerecordlabel);
            groupBoxTch.Location = new Point(37, 369);
            groupBoxTch.Name = "groupBoxTch";
            groupBoxTch.Size = new Size(331, 125);
            groupBoxTch.TabIndex = 3;
            groupBoxTch.TabStop = false;
            groupBoxTch.Visible = false;
            // 
            // Dayenterybox
            // 
            Dayenterybox.Location = new Point(121, 71);
            Dayenterybox.Name = "Dayenterybox";
            Dayenterybox.Size = new Size(34, 27);
            Dayenterybox.TabIndex = 25;
            Dayenterybox.KeyPress += Dayenterybox_KeyPress;
            // 
            // Monthenterybox
            // 
            Monthenterybox.Location = new Point(75, 71);
            Monthenterybox.Name = "Monthenterybox";
            Monthenterybox.Size = new Size(31, 27);
            Monthenterybox.TabIndex = 24;
            Monthenterybox.KeyPress += Monthenterybox_KeyPress;
            // 
            // Yearenterybox
            // 
            Yearenterybox.Location = new Point(22, 71);
            Yearenterybox.Name = "Yearenterybox";
            Yearenterybox.Size = new Size(42, 27);
            Yearenterybox.TabIndex = 23;
            Yearenterybox.KeyPress += Yearenterybox_KeyPress;
            // 
            // entrylabel
            // 
            entrylabel.AutoSize = true;
            entrylabel.Location = new Point(183, 75);
            entrylabel.Name = "entrylabel";
            entrylabel.RightToLeft = RightToLeft.Yes;
            entrylabel.Size = new Size(128, 20);
            entrylabel.TabIndex = 22;
            entrylabel.Text = "تاریخ ورود به مرکز :";
            // 
            // Presencerecordbox
            // 
            Presencerecordbox.Location = new Point(22, 20);
            Presencerecordbox.Name = "Presencerecordbox";
            Presencerecordbox.Size = new Size(125, 27);
            Presencerecordbox.TabIndex = 21;
            Presencerecordbox.KeyPress += Presencerecordbox_KeyPress;
            // 
            // Presencerecordlabel
            // 
            Presencerecordlabel.AutoSize = true;
            Presencerecordlabel.Location = new Point(182, 23);
            Presencerecordlabel.Name = "Presencerecordlabel";
            Presencerecordlabel.RightToLeft = RightToLeft.Yes;
            Presencerecordlabel.Size = new Size(146, 20);
            Presencerecordlabel.TabIndex = 20;
            Presencerecordlabel.Text = "سابقه حضور در مرکز :";
            // 
            // Setbutton
            // 
            Setbutton.Enabled = false;
            Setbutton.Location = new Point(597, 273);
            Setbutton.Name = "Setbutton";
            Setbutton.Size = new Size(94, 29);
            Setbutton.TabIndex = 4;
            Setbutton.Text = "تایید";
            Setbutton.UseVisualStyleBackColor = true;
            Setbutton.Click += Setbutton_Click;
            // 
            // addradioButton
            // 
            addradioButton.AutoSize = true;
            addradioButton.Location = new Point(688, 103);
            addradioButton.Name = "addradioButton";
            addradioButton.Size = new Size(104, 24);
            addradioButton.TabIndex = 5;
            addradioButton.TabStop = true;
            addradioButton.Text = "اضافه کردن";
            addradioButton.UseVisualStyleBackColor = true;
            addradioButton.CheckedChanged += addradioButton_CheckedChanged;
            // 
            // editradioButton
            // 
            editradioButton.AutoSize = true;
            editradioButton.Location = new Point(688, 133);
            editradioButton.Name = "editradioButton";
            editradioButton.Size = new Size(111, 24);
            editradioButton.TabIndex = 6;
            editradioButton.TabStop = true;
            editradioButton.Text = "ویرایش کردن";
            editradioButton.UseVisualStyleBackColor = true;
            editradioButton.CheckedChanged += editradioButton_CheckedChanged;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 554);
            Controls.Add(editradioButton);
            Controls.Add(addradioButton);
            Controls.Add(groupBoxSt);
            Controls.Add(Setbutton);
            Controls.Add(groupBoxTch);
            Controls.Add(groupBoxsame);
            Controls.Add(TypeCbox);
            Name = "AddUserForm";
            Text = "AddUserForm";
            Load += AddUserForm_Load;
            groupBoxsame.ResumeLayout(false);
            groupBoxsame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxSt.ResumeLayout(false);
            groupBoxSt.PerformLayout();
            groupBoxTch.ResumeLayout(false);
            groupBoxTch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TypeCbox;
        private GroupBox groupBoxsame;
        private TextBox Fieldbox;
        private TextBox WAnumberbox;
        private TextBox Numberbox;
        private TextBox Agebox;
        private TextBox Lnamebox;
        private TextBox Fnamebox;
        private TextBox Idbox;
        private Label educationlabel;
        private Label Fieldlabel;
        private Label WAnamberlabel;
        private Label NumberLabel;
        private Label Agelabel;
        private Label Lnamelabel;
        private Label Fnamelabel;
        private Label idlabel;
        private ComboBox educationCbox;
        private GroupBox groupBoxSt;
        private Label label1;
        private ComboBox ClasstypeCbox;
        private TextBox Jobbox;
        private TextBox Citybox;
        private ComboBox MaritalCbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBoxTch;
        private TextBox Dayenterybox;
        private TextBox Monthenterybox;
        private TextBox Yearenterybox;
        private Label entrylabel;
        private TextBox Presencerecordbox;
        private Label Presencerecordlabel;
        private CheckBox checkBoxWA;
        private Button Setbutton;
        private Button picturebot;
        private PictureBox pictureBox1;
        private RadioButton addradioButton;
        private RadioButton editradioButton;
        private Button checkbot;
    }
}