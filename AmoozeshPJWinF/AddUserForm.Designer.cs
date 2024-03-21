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
            groupBoxsame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxSt.SuspendLayout();
            groupBoxTch.SuspendLayout();
            SuspendLayout();
            // 
            // TypeCbox
            // 
            TypeCbox.FormattingEnabled = true;
            TypeCbox.Items.AddRange(new object[] { "استاد", "دانشجو" });
            TypeCbox.Location = new Point(512, 25);
            TypeCbox.Margin = new Padding(3, 2, 3, 2);
            TypeCbox.Name = "TypeCbox";
            TypeCbox.Size = new Size(133, 23);
            TypeCbox.TabIndex = 0;
            TypeCbox.SelectedIndexChanged += TypeCbox_SelectedIndexChanged;
            // 
            // groupBoxsame
            // 
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
            groupBoxsame.Location = new Point(32, 16);
            groupBoxsame.Margin = new Padding(3, 2, 3, 2);
            groupBoxsame.Name = "groupBoxsame";
            groupBoxsame.Padding = new Padding(3, 2, 3, 2);
            groupBoxsame.Size = new Size(466, 242);
            groupBoxsame.TabIndex = 1;
            groupBoxsame.TabStop = false;
            groupBoxsame.Visible = false;
            // 
            // picturebot
            // 
            picturebot.Location = new Point(365, 147);
            picturebot.Margin = new Padding(3, 2, 3, 2);
            picturebot.Name = "picturebot";
            picturebot.Size = new Size(88, 22);
            picturebot.TabIndex = 5;
            picturebot.Text = "انتخاب عکس";
            picturebot.UseVisualStyleBackColor = true;
            picturebot.Click += picturebot_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(346, 39);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBoxWA
            // 
            checkBoxWA.AutoSize = true;
            checkBoxWA.Location = new Point(138, 147);
            checkBoxWA.Margin = new Padding(3, 2, 3, 2);
            checkBoxWA.Name = "checkBoxWA";
            checkBoxWA.Size = new Size(15, 14);
            checkBoxWA.TabIndex = 16;
            checkBoxWA.UseVisualStyleBackColor = true;
            checkBoxWA.CheckedChanged += checkBoxWA_CheckedChanged;
            // 
            // educationlabel
            // 
            educationlabel.AutoSize = true;
            educationlabel.Location = new Point(159, 195);
            educationlabel.Name = "educationlabel";
            educationlabel.RightToLeft = RightToLeft.Yes;
            educationlabel.Size = new Size(88, 15);
            educationlabel.TabIndex = 15;
            educationlabel.Text = "سطح تحصیلات :";
            // 
            // Fieldlabel
            // 
            Fieldlabel.AutoSize = true;
            Fieldlabel.Location = new Point(159, 170);
            Fieldlabel.Name = "Fieldlabel";
            Fieldlabel.RightToLeft = RightToLeft.Yes;
            Fieldlabel.Size = new Size(37, 15);
            Fieldlabel.TabIndex = 14;
            Fieldlabel.Text = "رشته :";
            // 
            // WAnamberlabel
            // 
            WAnamberlabel.AutoSize = true;
            WAnamberlabel.Location = new Point(159, 146);
            WAnamberlabel.Name = "WAnamberlabel";
            WAnamberlabel.RightToLeft = RightToLeft.Yes;
            WAnamberlabel.Size = new Size(114, 15);
            WAnamberlabel.TabIndex = 13;
            WAnamberlabel.Text = "شماره واتس اپ مجزا :";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Location = new Point(159, 121);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.RightToLeft = RightToLeft.Yes;
            NumberLabel.Size = new Size(43, 15);
            NumberLabel.TabIndex = 12;
            NumberLabel.Text = "شماره :";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.Location = new Point(159, 96);
            Agelabel.Name = "Agelabel";
            Agelabel.RightToLeft = RightToLeft.Yes;
            Agelabel.Size = new Size(31, 15);
            Agelabel.TabIndex = 11;
            Agelabel.Text = "سن :";
            // 
            // Lnamelabel
            // 
            Lnamelabel.AutoSize = true;
            Lnamelabel.Location = new Point(159, 71);
            Lnamelabel.Name = "Lnamelabel";
            Lnamelabel.RightToLeft = RightToLeft.Yes;
            Lnamelabel.Size = new Size(75, 15);
            Lnamelabel.TabIndex = 10;
            Lnamelabel.Text = "نام خانوادگی :";
            // 
            // Fnamelabel
            // 
            Fnamelabel.AutoSize = true;
            Fnamelabel.Location = new Point(159, 46);
            Fnamelabel.Name = "Fnamelabel";
            Fnamelabel.RightToLeft = RightToLeft.Yes;
            Fnamelabel.Size = new Size(27, 15);
            Fnamelabel.TabIndex = 9;
            Fnamelabel.Text = "نام :";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(159, 22);
            idlabel.Name = "idlabel";
            idlabel.RightToLeft = RightToLeft.Yes;
            idlabel.Size = new Size(49, 15);
            idlabel.TabIndex = 8;
            idlabel.Text = "کد ملی :";
            idlabel.Click += idlabel_Click;
            // 
            // educationCbox
            // 
            educationCbox.FormattingEnabled = true;
            educationCbox.Items.AddRange(new object[] { "دانش آموز", "سیکل", "دیپلم", "فوق دیپلم", "لیسانس", "فوق لیسانس", "دکترا" });
            educationCbox.Location = new Point(19, 193);
            educationCbox.Margin = new Padding(3, 2, 3, 2);
            educationCbox.Name = "educationCbox";
            educationCbox.Size = new Size(110, 23);
            educationCbox.TabIndex = 7;
            // 
            // Fieldbox
            // 
            Fieldbox.Location = new Point(19, 168);
            Fieldbox.Margin = new Padding(3, 2, 3, 2);
            Fieldbox.Name = "Fieldbox";
            Fieldbox.Size = new Size(110, 23);
            Fieldbox.TabIndex = 6;
            // 
            // WAnumberbox
            // 
            WAnumberbox.Enabled = false;
            WAnumberbox.Location = new Point(19, 143);
            WAnumberbox.Margin = new Padding(3, 2, 3, 2);
            WAnumberbox.Name = "WAnumberbox";
            WAnumberbox.Size = new Size(110, 23);
            WAnumberbox.TabIndex = 5;
            // 
            // Numberbox
            // 
            Numberbox.Location = new Point(19, 118);
            Numberbox.Margin = new Padding(3, 2, 3, 2);
            Numberbox.Name = "Numberbox";
            Numberbox.Size = new Size(110, 23);
            Numberbox.TabIndex = 4;
            // 
            // Agebox
            // 
            Agebox.Location = new Point(19, 94);
            Agebox.Margin = new Padding(3, 2, 3, 2);
            Agebox.Name = "Agebox";
            Agebox.Size = new Size(110, 23);
            Agebox.TabIndex = 3;
            // 
            // Lnamebox
            // 
            Lnamebox.Location = new Point(19, 69);
            Lnamebox.Margin = new Padding(3, 2, 3, 2);
            Lnamebox.Name = "Lnamebox";
            Lnamebox.Size = new Size(110, 23);
            Lnamebox.TabIndex = 2;
            // 
            // Fnamebox
            // 
            Fnamebox.Location = new Point(19, 44);
            Fnamebox.Margin = new Padding(3, 2, 3, 2);
            Fnamebox.Name = "Fnamebox";
            Fnamebox.Size = new Size(110, 23);
            Fnamebox.TabIndex = 1;
            // 
            // Idbox
            // 
            Idbox.Location = new Point(19, 20);
            Idbox.Margin = new Padding(3, 2, 3, 2);
            Idbox.Name = "Idbox";
            Idbox.Size = new Size(110, 23);
            Idbox.TabIndex = 0;
            Idbox.TextChanged += Idbox_TextChanged;
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
            groupBoxSt.Location = new Point(378, 239);
            groupBoxSt.Margin = new Padding(3, 2, 3, 2);
            groupBoxSt.Name = "groupBoxSt";
            groupBoxSt.Padding = new Padding(3, 2, 3, 2);
            groupBoxSt.Size = new Size(290, 117);
            groupBoxSt.TabIndex = 2;
            groupBoxSt.TabStop = false;
            groupBoxSt.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 89);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(60, 15);
            label4.TabIndex = 19;
            label4.Text = "نوع کلاس :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 64);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "شغل :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 40);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(34, 15);
            label2.TabIndex = 17;
            label2.Text = "شهر :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 14);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(79, 15);
            label1.TabIndex = 16;
            label1.Text = "وضعیت تاهل :";
            // 
            // ClasstypeCbox
            // 
            ClasstypeCbox.FormattingEnabled = true;
            ClasstypeCbox.Items.AddRange(new object[] { "حضوری", "مجازی" });
            ClasstypeCbox.Location = new Point(19, 87);
            ClasstypeCbox.Margin = new Padding(3, 2, 3, 2);
            ClasstypeCbox.Name = "ClasstypeCbox";
            ClasstypeCbox.Size = new Size(110, 23);
            ClasstypeCbox.TabIndex = 3;
            // 
            // Jobbox
            // 
            Jobbox.Location = new Point(19, 62);
            Jobbox.Margin = new Padding(3, 2, 3, 2);
            Jobbox.Name = "Jobbox";
            Jobbox.Size = new Size(110, 23);
            Jobbox.TabIndex = 2;
            // 
            // Citybox
            // 
            Citybox.Location = new Point(19, 38);
            Citybox.Margin = new Padding(3, 2, 3, 2);
            Citybox.Name = "Citybox";
            Citybox.Size = new Size(110, 23);
            Citybox.TabIndex = 1;
            // 
            // MaritalCbox
            // 
            MaritalCbox.FormattingEnabled = true;
            MaritalCbox.Items.AddRange(new object[] { "مجرد", "متاهل" });
            MaritalCbox.Location = new Point(19, 12);
            MaritalCbox.Margin = new Padding(3, 2, 3, 2);
            MaritalCbox.Name = "MaritalCbox";
            MaritalCbox.Size = new Size(110, 23);
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
            groupBoxTch.Location = new Point(32, 262);
            groupBoxTch.Margin = new Padding(3, 2, 3, 2);
            groupBoxTch.Name = "groupBoxTch";
            groupBoxTch.Padding = new Padding(3, 2, 3, 2);
            groupBoxTch.Size = new Size(290, 94);
            groupBoxTch.TabIndex = 3;
            groupBoxTch.TabStop = false;
            groupBoxTch.Visible = false;
            // 
            // Dayenterybox
            // 
            Dayenterybox.Location = new Point(106, 53);
            Dayenterybox.Margin = new Padding(3, 2, 3, 2);
            Dayenterybox.Name = "Dayenterybox";
            Dayenterybox.Size = new Size(30, 23);
            Dayenterybox.TabIndex = 25;
            // 
            // Monthenterybox
            // 
            Monthenterybox.Location = new Point(66, 53);
            Monthenterybox.Margin = new Padding(3, 2, 3, 2);
            Monthenterybox.Name = "Monthenterybox";
            Monthenterybox.Size = new Size(28, 23);
            Monthenterybox.TabIndex = 24;
            // 
            // Yearenterybox
            // 
            Yearenterybox.Location = new Point(19, 53);
            Yearenterybox.Margin = new Padding(3, 2, 3, 2);
            Yearenterybox.Name = "Yearenterybox";
            Yearenterybox.Size = new Size(37, 23);
            Yearenterybox.TabIndex = 23;
            // 
            // entrylabel
            // 
            entrylabel.AutoSize = true;
            entrylabel.Location = new Point(160, 56);
            entrylabel.Name = "entrylabel";
            entrylabel.RightToLeft = RightToLeft.Yes;
            entrylabel.Size = new Size(100, 15);
            entrylabel.TabIndex = 22;
            entrylabel.Text = "تاریخ ورود به مرکز :";
            // 
            // Presencerecordbox
            // 
            Presencerecordbox.Location = new Point(19, 15);
            Presencerecordbox.Margin = new Padding(3, 2, 3, 2);
            Presencerecordbox.Name = "Presencerecordbox";
            Presencerecordbox.Size = new Size(110, 23);
            Presencerecordbox.TabIndex = 21;
            // 
            // Presencerecordlabel
            // 
            Presencerecordlabel.AutoSize = true;
            Presencerecordlabel.Location = new Point(159, 17);
            Presencerecordlabel.Name = "Presencerecordlabel";
            Presencerecordlabel.RightToLeft = RightToLeft.Yes;
            Presencerecordlabel.Size = new Size(114, 15);
            Presencerecordlabel.TabIndex = 20;
            Presencerecordlabel.Text = "سابقه حضور در مرکز :";
            // 
            // Setbutton
            // 
            Setbutton.Enabled = false;
            Setbutton.Location = new Point(522, 205);
            Setbutton.Margin = new Padding(3, 2, 3, 2);
            Setbutton.Name = "Setbutton";
            Setbutton.Size = new Size(82, 22);
            Setbutton.TabIndex = 4;
            Setbutton.Text = "ثبت";
            Setbutton.UseVisualStyleBackColor = true;
            Setbutton.Click += Setbutton_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 373);
            Controls.Add(Setbutton);
            Controls.Add(groupBoxTch);
            Controls.Add(groupBoxSt);
            Controls.Add(groupBoxsame);
            Controls.Add(TypeCbox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddUserForm";
            Text = "AddUserForm";
            groupBoxsame.ResumeLayout(false);
            groupBoxsame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxSt.ResumeLayout(false);
            groupBoxSt.PerformLayout();
            groupBoxTch.ResumeLayout(false);
            groupBoxTch.PerformLayout();
            ResumeLayout(false);
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
    }
}