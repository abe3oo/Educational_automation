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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            TypeCbox = new ComboBox();
            usereditlabel = new Label();
            userlabel = new Label();
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ClasstypeCbox = new ComboBox();
            Jobbox = new TextBox();
            Citybox = new TextBox();
            MaritalCbox = new ComboBox();
            Dayenterybox = new TextBox();
            Monthenterybox = new TextBox();
            Yearenterybox = new TextBox();
            entrylabel = new Label();
            Presencerecordbox = new TextBox();
            Presencerecordlabel = new Label();
            Setbutton = new Button();
            addradioButton = new RadioButton();
            editradioButton = new RadioButton();
            panelsame = new Panel();
            panelTch = new Panel();
            label6 = new Label();
            label5 = new Label();
            panelst = new Panel();
            panel1 = new Panel();
            studentbot = new Button();
            teacherbot = new Button();
            panelcolorselect = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelsame.SuspendLayout();
            panelTch.SuspendLayout();
            panelst.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TypeCbox
            // 
            TypeCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeCbox.FormattingEnabled = true;
            TypeCbox.Items.AddRange(new object[] { "استاد", "دانشجو" });
            TypeCbox.Location = new Point(14, 284);
            TypeCbox.Name = "TypeCbox";
            TypeCbox.Size = new Size(151, 28);
            TypeCbox.TabIndex = 0;
            TypeCbox.Visible = false;
            TypeCbox.SelectedIndexChanged += TypeCbox_SelectedIndexChanged;
            // 
            // usereditlabel
            // 
            usereditlabel.AutoSize = true;
            usereditlabel.Location = new Point(26, 19);
            usereditlabel.Name = "usereditlabel";
            usereditlabel.Size = new Size(18, 20);
            usereditlabel.TabIndex = 19;
            usereditlabel.Text = "...";
            usereditlabel.Visible = false;
            usereditlabel.TextChanged += usereditlabel_TextChanged;
            usereditlabel.Click += usereditlabel_Click;
            // 
            // userlabel
            // 
            userlabel.AutoSize = true;
            userlabel.Location = new Point(129, 19);
            userlabel.Name = "userlabel";
            userlabel.RightToLeft = RightToLeft.Yes;
            userlabel.Size = new Size(45, 20);
            userlabel.TabIndex = 18;
            userlabel.Text = "کاربر :";
            userlabel.Visible = false;
            // 
            // checkbot
            // 
            checkbot.Enabled = false;
            checkbot.Location = new Point(180, 10);
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
            picturebot.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            picturebot.Location = new Point(38, 216);
            picturebot.Name = "picturebot";
            picturebot.Size = new Size(101, 34);
            picturebot.TabIndex = 5;
            picturebot.Text = "انتخاب عکس";
            picturebot.UseVisualStyleBackColor = true;
            picturebot.Click += picturebot_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBoxWA
            // 
            checkBoxWA.AutoSize = true;
            checkBoxWA.Location = new Point(186, 182);
            checkBoxWA.Name = "checkBoxWA";
            checkBoxWA.Size = new Size(18, 17);
            checkBoxWA.TabIndex = 16;
            checkBoxWA.UseVisualStyleBackColor = true;
            checkBoxWA.CheckedChanged += checkBoxWA_CheckedChanged;
            // 
            // educationlabel
            // 
            educationlabel.AutoSize = true;
            educationlabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            educationlabel.Location = new Point(420, 242);
            educationlabel.Name = "educationlabel";
            educationlabel.RightToLeft = RightToLeft.Yes;
            educationlabel.Size = new Size(101, 27);
            educationlabel.TabIndex = 15;
            educationlabel.Text = "سطح تحصیلات";
            // 
            // Fieldlabel
            // 
            Fieldlabel.AutoSize = true;
            Fieldlabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            Fieldlabel.Location = new Point(477, 210);
            Fieldlabel.Name = "Fieldlabel";
            Fieldlabel.RightToLeft = RightToLeft.Yes;
            Fieldlabel.Size = new Size(42, 27);
            Fieldlabel.TabIndex = 14;
            Fieldlabel.Text = "رشته";
            // 
            // WAnamberlabel
            // 
            WAnamberlabel.AutoSize = true;
            WAnamberlabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            WAnamberlabel.Location = new Point(418, 177);
            WAnamberlabel.Name = "WAnamberlabel";
            WAnamberlabel.RightToLeft = RightToLeft.Yes;
            WAnamberlabel.Size = new Size(101, 27);
            WAnamberlabel.TabIndex = 13;
            WAnamberlabel.Text = "شماره واتس اپ";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            NumberLabel.Location = new Point(472, 143);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.RightToLeft = RightToLeft.Yes;
            NumberLabel.Size = new Size(47, 27);
            NumberLabel.TabIndex = 12;
            NumberLabel.Text = "شماره";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            Agelabel.Location = new Point(484, 111);
            Agelabel.Name = "Agelabel";
            Agelabel.RightToLeft = RightToLeft.Yes;
            Agelabel.Size = new Size(33, 27);
            Agelabel.TabIndex = 11;
            Agelabel.Text = "سن";
            // 
            // Lnamelabel
            // 
            Lnamelabel.AutoSize = true;
            Lnamelabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            Lnamelabel.Location = new Point(432, 77);
            Lnamelabel.Name = "Lnamelabel";
            Lnamelabel.RightToLeft = RightToLeft.Yes;
            Lnamelabel.Size = new Size(85, 27);
            Lnamelabel.TabIndex = 10;
            Lnamelabel.Text = "نام خانوادگی";
            // 
            // Fnamelabel
            // 
            Fnamelabel.AutoSize = true;
            Fnamelabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            Fnamelabel.Location = new Point(489, 44);
            Fnamelabel.Name = "Fnamelabel";
            Fnamelabel.RightToLeft = RightToLeft.Yes;
            Fnamelabel.Size = new Size(28, 27);
            Fnamelabel.TabIndex = 9;
            Fnamelabel.Text = "نام";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            idlabel.Location = new Point(463, 13);
            idlabel.Name = "idlabel";
            idlabel.RightToLeft = RightToLeft.Yes;
            idlabel.Size = new Size(54, 27);
            idlabel.TabIndex = 8;
            idlabel.Text = "کد ملی";
            idlabel.Click += idlabel_Click;
            // 
            // educationCbox
            // 
            educationCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            educationCbox.FormattingEnabled = true;
            educationCbox.Items.AddRange(new object[] { "دانش آموز", "سیکل", "دیپلم", "فوق دیپلم", "لیسانس", "فوق لیسانس", "دکترا" });
            educationCbox.Location = new Point(180, 242);
            educationCbox.Name = "educationCbox";
            educationCbox.Size = new Size(211, 28);
            educationCbox.TabIndex = 7;
            // 
            // Fieldbox
            // 
            Fieldbox.Location = new Point(180, 209);
            Fieldbox.Name = "Fieldbox";
            Fieldbox.Size = new Size(211, 27);
            Fieldbox.TabIndex = 6;
            Fieldbox.TextChanged += Fieldbox_TextChanged;
            Fieldbox.KeyPress += Fieldbox_KeyPress;
            // 
            // WAnumberbox
            // 
            WAnumberbox.Enabled = false;
            WAnumberbox.Location = new Point(217, 176);
            WAnumberbox.Name = "WAnumberbox";
            WAnumberbox.Size = new Size(174, 27);
            WAnumberbox.TabIndex = 5;
            WAnumberbox.KeyPress += WAnumberbox_KeyPress;
            // 
            // Numberbox
            // 
            Numberbox.Location = new Point(180, 142);
            Numberbox.Name = "Numberbox";
            Numberbox.Size = new Size(211, 27);
            Numberbox.TabIndex = 4;
            Numberbox.KeyPress += Numberbox_KeyPress;
            // 
            // Agebox
            // 
            Agebox.Location = new Point(180, 110);
            Agebox.Name = "Agebox";
            Agebox.Size = new Size(211, 27);
            Agebox.TabIndex = 3;
            Agebox.TextChanged += Agebox_TextChanged;
            Agebox.KeyPress += Agebox_KeyPress;
            // 
            // Lnamebox
            // 
            Lnamebox.Location = new Point(180, 77);
            Lnamebox.Name = "Lnamebox";
            Lnamebox.Size = new Size(211, 27);
            Lnamebox.TabIndex = 2;
            Lnamebox.KeyPress += Lnamebox_KeyPress;
            // 
            // Fnamebox
            // 
            Fnamebox.Location = new Point(180, 44);
            Fnamebox.Name = "Fnamebox";
            Fnamebox.Size = new Size(211, 27);
            Fnamebox.TabIndex = 1;
            Fnamebox.KeyPress += Fnamebox_KeyPress;
            // 
            // Idbox
            // 
            Idbox.Location = new Point(243, 12);
            Idbox.MaxLength = 10;
            Idbox.Name = "Idbox";
            Idbox.Size = new Size(148, 27);
            Idbox.TabIndex = 0;
            Idbox.TextChanged += Idbox_TextChanged;
            Idbox.KeyPress += Idbox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            label4.Location = new Point(278, 116);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(70, 27);
            label4.TabIndex = 19;
            label4.Text = "نوع کلاس";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            label3.Location = new Point(307, 79);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(39, 27);
            label3.TabIndex = 18;
            label3.Text = "شغل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            label2.Location = new Point(308, 43);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(38, 27);
            label2.TabIndex = 17;
            label2.Text = "شهر";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            label1.Location = new Point(261, 7);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(86, 27);
            label1.TabIndex = 16;
            label1.Text = "وضعیت تاهل";
            // 
            // ClasstypeCbox
            // 
            ClasstypeCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClasstypeCbox.FormattingEnabled = true;
            ClasstypeCbox.Items.AddRange(new object[] { "حضوری", "مجازی" });
            ClasstypeCbox.Location = new Point(9, 115);
            ClasstypeCbox.Name = "ClasstypeCbox";
            ClasstypeCbox.Size = new Size(211, 28);
            ClasstypeCbox.TabIndex = 3;
            // 
            // Jobbox
            // 
            Jobbox.Location = new Point(9, 79);
            Jobbox.Name = "Jobbox";
            Jobbox.Size = new Size(211, 27);
            Jobbox.TabIndex = 2;
            Jobbox.KeyPress += Jobbox_KeyPress;
            // 
            // Citybox
            // 
            Citybox.Location = new Point(9, 43);
            Citybox.Name = "Citybox";
            Citybox.Size = new Size(211, 27);
            Citybox.TabIndex = 1;
            Citybox.KeyPress += Citybox_KeyPress;
            // 
            // MaritalCbox
            // 
            MaritalCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            MaritalCbox.FormattingEnabled = true;
            MaritalCbox.Items.AddRange(new object[] { "مجرد", "متاهل" });
            MaritalCbox.Location = new Point(9, 6);
            MaritalCbox.Name = "MaritalCbox";
            MaritalCbox.Size = new Size(211, 28);
            MaritalCbox.TabIndex = 0;
            // 
            // Dayenterybox
            // 
            Dayenterybox.Location = new Point(183, 53);
            Dayenterybox.Name = "Dayenterybox";
            Dayenterybox.Size = new Size(34, 27);
            Dayenterybox.TabIndex = 25;
            Dayenterybox.KeyPress += Dayenterybox_KeyPress;
            // 
            // Monthenterybox
            // 
            Monthenterybox.Location = new Point(133, 53);
            Monthenterybox.Name = "Monthenterybox";
            Monthenterybox.Size = new Size(31, 27);
            Monthenterybox.TabIndex = 24;
            Monthenterybox.KeyPress += Monthenterybox_KeyPress;
            // 
            // Yearenterybox
            // 
            Yearenterybox.Location = new Point(71, 53);
            Yearenterybox.Name = "Yearenterybox";
            Yearenterybox.Size = new Size(42, 27);
            Yearenterybox.TabIndex = 23;
            Yearenterybox.KeyPress += Yearenterybox_KeyPress;
            // 
            // entrylabel
            // 
            entrylabel.AutoSize = true;
            entrylabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            entrylabel.Location = new Point(232, 53);
            entrylabel.Name = "entrylabel";
            entrylabel.RightToLeft = RightToLeft.Yes;
            entrylabel.Size = new Size(118, 27);
            entrylabel.TabIndex = 22;
            entrylabel.Text = "تاریخ ورود به مرکز";
            // 
            // Presencerecordbox
            // 
            Presencerecordbox.Location = new Point(9, 9);
            Presencerecordbox.Name = "Presencerecordbox";
            Presencerecordbox.Size = new Size(211, 27);
            Presencerecordbox.TabIndex = 21;
            Presencerecordbox.KeyPress += Presencerecordbox_KeyPress;
            // 
            // Presencerecordlabel
            // 
            Presencerecordlabel.AutoSize = true;
            Presencerecordlabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            Presencerecordlabel.Location = new Point(265, 9);
            Presencerecordlabel.Name = "Presencerecordlabel";
            Presencerecordlabel.RightToLeft = RightToLeft.Yes;
            Presencerecordlabel.Size = new Size(83, 27);
            Presencerecordlabel.TabIndex = 20;
            Presencerecordlabel.Text = "سابقه حضور";
            // 
            // Setbutton
            // 
            Setbutton.Enabled = false;
            Setbutton.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Setbutton.Location = new Point(38, 355);
            Setbutton.Name = "Setbutton";
            Setbutton.Size = new Size(99, 57);
            Setbutton.TabIndex = 4;
            Setbutton.Text = "تایید";
            Setbutton.UseVisualStyleBackColor = true;
            Setbutton.Click += Setbutton_Click;
            // 
            // addradioButton
            // 
            addradioButton.AutoSize = true;
            addradioButton.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            addradioButton.Location = new Point(59, 12);
            addradioButton.Name = "addradioButton";
            addradioButton.Size = new Size(106, 33);
            addradioButton.TabIndex = 5;
            addradioButton.TabStop = true;
            addradioButton.Text = "اضافه کردن";
            addradioButton.UseVisualStyleBackColor = true;
            addradioButton.CheckedChanged += addradioButton_CheckedChanged;
            // 
            // editradioButton
            // 
            editradioButton.AutoSize = true;
            editradioButton.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            editradioButton.Location = new Point(59, 42);
            editradioButton.Name = "editradioButton";
            editradioButton.Size = new Size(118, 33);
            editradioButton.TabIndex = 6;
            editradioButton.TabStop = true;
            editradioButton.Text = "ویرایش کردن";
            editradioButton.UseVisualStyleBackColor = true;
            editradioButton.CheckedChanged += editradioButton_CheckedChanged;
            // 
            // panelsame
            // 
            panelsame.BackColor = Color.Transparent;
            panelsame.Controls.Add(usereditlabel);
            panelsame.Controls.Add(TypeCbox);
            panelsame.Controls.Add(panelTch);
            panelsame.Controls.Add(Idbox);
            panelsame.Controls.Add(panelst);
            panelsame.Controls.Add(Setbutton);
            panelsame.Controls.Add(Fnamebox);
            panelsame.Controls.Add(Lnamebox);
            panelsame.Controls.Add(userlabel);
            panelsame.Controls.Add(checkbot);
            panelsame.Controls.Add(Agebox);
            panelsame.Controls.Add(Numberbox);
            panelsame.Controls.Add(picturebot);
            panelsame.Controls.Add(checkBoxWA);
            panelsame.Controls.Add(WAnumberbox);
            panelsame.Controls.Add(educationlabel);
            panelsame.Controls.Add(pictureBox1);
            panelsame.Controls.Add(Fieldbox);
            panelsame.Controls.Add(Fieldlabel);
            panelsame.Controls.Add(educationCbox);
            panelsame.Controls.Add(WAnamberlabel);
            panelsame.Controls.Add(idlabel);
            panelsame.Controls.Add(NumberLabel);
            panelsame.Controls.Add(Fnamelabel);
            panelsame.Controls.Add(Agelabel);
            panelsame.Controls.Add(Lnamelabel);
            panelsame.Location = new Point(12, 88);
            panelsame.Name = "panelsame";
            panelsame.Size = new Size(545, 497);
            panelsame.TabIndex = 7;
            panelsame.Visible = false;
            // 
            // panelTch
            // 
            panelTch.Controls.Add(label6);
            panelTch.Controls.Add(label5);
            panelTch.Controls.Add(Dayenterybox);
            panelTch.Controls.Add(Presencerecordbox);
            panelTch.Controls.Add(Monthenterybox);
            panelTch.Controls.Add(Presencerecordlabel);
            panelTch.Controls.Add(Yearenterybox);
            panelTch.Controls.Add(entrylabel);
            panelTch.Location = new Point(172, 267);
            panelTch.Name = "panelTch";
            panelTch.Size = new Size(374, 175);
            panelTch.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 56);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 27;
            label6.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 56);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 26;
            label5.Text = "/";
            // 
            // panelst
            // 
            panelst.Controls.Add(label4);
            panelst.Controls.Add(MaritalCbox);
            panelst.Controls.Add(label3);
            panelst.Controls.Add(Citybox);
            panelst.Controls.Add(label2);
            panelst.Controls.Add(Jobbox);
            panelst.Controls.Add(label1);
            panelst.Controls.Add(ClasstypeCbox);
            panelst.Location = new Point(171, 276);
            panelst.Name = "panelst";
            panelst.Size = new Size(374, 175);
            panelst.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 243, 238);
            panel1.Controls.Add(studentbot);
            panel1.Controls.Add(teacherbot);
            panel1.Controls.Add(editradioButton);
            panel1.Controls.Add(addradioButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 84);
            panel1.TabIndex = 10;
            // 
            // studentbot
            // 
            studentbot.FlatAppearance.BorderSize = 0;
            studentbot.FlatStyle = FlatStyle.Flat;
            studentbot.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            studentbot.ForeColor = SystemColors.ControlText;
            studentbot.Image = (Image)resources.GetObject("studentbot.Image");
            studentbot.Location = new Point(472, 3);
            studentbot.Name = "studentbot";
            studentbot.Size = new Size(85, 78);
            studentbot.TabIndex = 8;
            studentbot.Text = "دانشجو";
            studentbot.TextAlign = ContentAlignment.BottomCenter;
            studentbot.TextImageRelation = TextImageRelation.ImageAboveText;
            studentbot.UseVisualStyleBackColor = true;
            studentbot.Click += studentbot_Click;
            // 
            // teacherbot
            // 
            teacherbot.FlatAppearance.BorderSize = 0;
            teacherbot.FlatStyle = FlatStyle.Flat;
            teacherbot.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            teacherbot.Image = (Image)resources.GetObject("teacherbot.Image");
            teacherbot.Location = new Point(381, 3);
            teacherbot.Name = "teacherbot";
            teacherbot.Size = new Size(85, 78);
            teacherbot.TabIndex = 7;
            teacherbot.Text = "استاد";
            teacherbot.TextAlign = ContentAlignment.BottomCenter;
            teacherbot.TextImageRelation = TextImageRelation.ImageAboveText;
            teacherbot.UseVisualStyleBackColor = true;
            teacherbot.Click += teacherbot_Click;
            // 
            // panelcolorselect
            // 
            panelcolorselect.BackColor = Color.FromArgb(224, 175, 160);
            panelcolorselect.Location = new Point(472, 72);
            panelcolorselect.Name = "panelcolorselect";
            panelcolorselect.Size = new Size(85, 10);
            panelcolorselect.TabIndex = 11;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(574, 539);
            Controls.Add(panelcolorselect);
            Controls.Add(panel1);
            Controls.Add(panelsame);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUserForm";
            Text = "افزودن کاربر";
            Load += AddUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelsame.ResumeLayout(false);
            panelsame.PerformLayout();
            panelTch.ResumeLayout(false);
            panelTch.PerformLayout();
            panelst.ResumeLayout(false);
            panelst.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox TypeCbox;
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
        private Label label1;
        private ComboBox ClasstypeCbox;
        private TextBox Jobbox;
        private TextBox Citybox;
        private ComboBox MaritalCbox;
        private Label label4;
        private Label label3;
        private Label label2;
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
        private Label userlabel;
        private Label usereditlabel;
        private Panel panelsame;
        private Panel panelst;
        private Panel panelTch;
        private Panel panel1;
        private Button studentbot;
        private Button teacherbot;
        private Panel panelcolorselect;
        private Label label6;
        private Label label5;
    }
}