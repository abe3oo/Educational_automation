namespace AmoozeshPJWinF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            yearlabelpr = new Label();
            monthlabelpr = new Label();
            daylabelpr = new Label();
            label1 = new Label();
            label2 = new Label();
            clocklabel = new Label();
            day1 = new Button();
            day2 = new Button();
            day3 = new Button();
            day4 = new Button();
            day5 = new Button();
            day6 = new Button();
            day7 = new Button();
            day8 = new Button();
            day9 = new Button();
            day10 = new Button();
            day11 = new Button();
            day12 = new Button();
            day13 = new Button();
            day14 = new Button();
            day15 = new Button();
            day16 = new Button();
            day17 = new Button();
            day18 = new Button();
            day19 = new Button();
            day20 = new Button();
            day21 = new Button();
            day22 = new Button();
            day23 = new Button();
            day24 = new Button();
            day25 = new Button();
            day26 = new Button();
            day27 = new Button();
            day28 = new Button();
            day29 = new Button();
            day30 = new Button();
            day31 = new Button();
            AddCourse = new Button();
            yearlabelcul = new Label();
            monthlabelcul = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            todaybot = new Button();
            enrollment = new Button();
            coursetodayGridView = new DataGridView();
            todayclasslabel = new Label();
            showbot = new Button();
            classidcombo = new ComboBox();
            truebot = new Button();
            falsebot = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            groupBox3 = new GroupBox();
            checkBox1 = new CheckBox();
            acceptbot = new Button();
            dayremedical = new TextBox();
            monthremedical = new TextBox();
            yearremedical = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)coursetodayGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 231, 240);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(4, 82);
            button1.Name = "button1";
            button1.Size = new Size(113, 76);
            button1.TabIndex = 0;
            button1.Text = "افزودن کاربر";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Adduser_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 231, 240);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(3, 405);
            button2.Name = "button2";
            button2.Size = new Size(113, 81);
            button2.TabIndex = 1;
            button2.Text = "پرداخت ها";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // yearlabelpr
            // 
            yearlabelpr.AutoSize = true;
            yearlabelpr.BackColor = Color.Transparent;
            yearlabelpr.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            yearlabelpr.ForeColor = Color.White;
            yearlabelpr.Location = new Point(1, 9);
            yearlabelpr.Name = "yearlabelpr";
            yearlabelpr.Size = new Size(46, 24);
            yearlabelpr.TabIndex = 2;
            yearlabelpr.Text = "0000";
            // 
            // monthlabelpr
            // 
            monthlabelpr.AutoSize = true;
            monthlabelpr.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            monthlabelpr.ForeColor = Color.White;
            monthlabelpr.Location = new Point(56, 9);
            monthlabelpr.Name = "monthlabelpr";
            monthlabelpr.Size = new Size(28, 24);
            monthlabelpr.TabIndex = 3;
            monthlabelpr.Text = "00";
            monthlabelpr.TextChanged += monthlabelpr_TextChanged;
            // 
            // daylabelpr
            // 
            daylabelpr.AutoSize = true;
            daylabelpr.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            daylabelpr.ForeColor = Color.White;
            daylabelpr.Location = new Point(94, 9);
            daylabelpr.Name = "daylabelpr";
            daylabelpr.Size = new Size(28, 24);
            daylabelpr.TabIndex = 4;
            daylabelpr.Text = "00";
            daylabelpr.TextChanged += daylabelpr_TextChanged;
            daylabelpr.Click += daylabelpr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 8);
            label1.Name = "label1";
            label1.Size = new Size(17, 24);
            label1.TabIndex = 5;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 8);
            label2.Name = "label2";
            label2.Size = new Size(17, 24);
            label2.TabIndex = 6;
            label2.Text = "/";
            // 
            // clocklabel
            // 
            clocklabel.AutoSize = true;
            clocklabel.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clocklabel.ForeColor = Color.White;
            clocklabel.Location = new Point(24, 44);
            clocklabel.Name = "clocklabel";
            clocklabel.Size = new Size(74, 24);
            clocklabel.TabIndex = 8;
            clocklabel.Text = "00:00:00";
            // 
            // day1
            // 
            day1.Location = new Point(25, 54);
            day1.Name = "day1";
            day1.Size = new Size(33, 27);
            day1.TabIndex = 8;
            day1.Text = "01";
            day1.UseVisualStyleBackColor = true;
            day1.Click += day1_Click;
            // 
            // day2
            // 
            day2.Location = new Point(65, 54);
            day2.Name = "day2";
            day2.Size = new Size(33, 27);
            day2.TabIndex = 9;
            day2.Text = "02";
            day2.UseVisualStyleBackColor = true;
            day2.Click += day2_Click;
            // 
            // day3
            // 
            day3.Location = new Point(104, 54);
            day3.Name = "day3";
            day3.Size = new Size(33, 27);
            day3.TabIndex = 10;
            day3.Text = "03";
            day3.UseVisualStyleBackColor = true;
            day3.Click += day3_Click;
            // 
            // day4
            // 
            day4.Location = new Point(143, 54);
            day4.Name = "day4";
            day4.Size = new Size(33, 27);
            day4.TabIndex = 11;
            day4.Text = "04";
            day4.UseVisualStyleBackColor = true;
            day4.Click += day4_Click;
            // 
            // day5
            // 
            day5.Location = new Point(182, 54);
            day5.Name = "day5";
            day5.Size = new Size(33, 27);
            day5.TabIndex = 12;
            day5.Text = "05";
            day5.UseVisualStyleBackColor = true;
            day5.Click += day5_Click;
            // 
            // day6
            // 
            day6.Location = new Point(221, 54);
            day6.Name = "day6";
            day6.Size = new Size(33, 27);
            day6.TabIndex = 13;
            day6.Text = "06";
            day6.UseVisualStyleBackColor = true;
            day6.Click += day6_Click;
            // 
            // day7
            // 
            day7.Location = new Point(25, 86);
            day7.Name = "day7";
            day7.Size = new Size(33, 27);
            day7.TabIndex = 14;
            day7.Text = "07";
            day7.UseVisualStyleBackColor = true;
            day7.Click += day7_Click;
            // 
            // day8
            // 
            day8.Location = new Point(65, 86);
            day8.Name = "day8";
            day8.Size = new Size(33, 27);
            day8.TabIndex = 15;
            day8.Text = "08";
            day8.UseVisualStyleBackColor = true;
            day8.Click += day8_Click;
            // 
            // day9
            // 
            day9.Location = new Point(104, 86);
            day9.Name = "day9";
            day9.Size = new Size(33, 27);
            day9.TabIndex = 16;
            day9.Text = "09";
            day9.UseVisualStyleBackColor = true;
            day9.Click += day9_Click;
            // 
            // day10
            // 
            day10.Location = new Point(143, 86);
            day10.Name = "day10";
            day10.Size = new Size(33, 27);
            day10.TabIndex = 17;
            day10.Text = "10";
            day10.UseVisualStyleBackColor = true;
            day10.Click += day10_Click;
            // 
            // day11
            // 
            day11.Location = new Point(182, 86);
            day11.Name = "day11";
            day11.Size = new Size(33, 27);
            day11.TabIndex = 18;
            day11.Text = "11";
            day11.UseVisualStyleBackColor = true;
            day11.Click += day11_Click;
            // 
            // day12
            // 
            day12.Location = new Point(221, 86);
            day12.Name = "day12";
            day12.Size = new Size(33, 27);
            day12.TabIndex = 19;
            day12.Text = "12";
            day12.UseVisualStyleBackColor = true;
            day12.Click += day12_Click;
            // 
            // day13
            // 
            day13.Location = new Point(25, 118);
            day13.Name = "day13";
            day13.Size = new Size(33, 27);
            day13.TabIndex = 20;
            day13.Text = "13";
            day13.UseVisualStyleBackColor = true;
            day13.Click += day13_Click;
            // 
            // day14
            // 
            day14.Location = new Point(67, 118);
            day14.Name = "day14";
            day14.Size = new Size(33, 27);
            day14.TabIndex = 21;
            day14.Text = "14";
            day14.UseVisualStyleBackColor = true;
            day14.Click += day14_Click;
            // 
            // day15
            // 
            day15.Location = new Point(103, 118);
            day15.Name = "day15";
            day15.Size = new Size(34, 27);
            day15.TabIndex = 22;
            day15.Text = "15";
            day15.UseVisualStyleBackColor = true;
            day15.Click += day15_Click;
            // 
            // day16
            // 
            day16.Location = new Point(143, 118);
            day16.Name = "day16";
            day16.Size = new Size(33, 27);
            day16.TabIndex = 23;
            day16.Text = "16";
            day16.UseVisualStyleBackColor = true;
            day16.Click += day16_Click;
            // 
            // day17
            // 
            day17.Location = new Point(182, 118);
            day17.Name = "day17";
            day17.Size = new Size(33, 27);
            day17.TabIndex = 24;
            day17.Text = "17";
            day17.UseVisualStyleBackColor = true;
            day17.Click += day17_Click;
            // 
            // day18
            // 
            day18.Location = new Point(221, 116);
            day18.Name = "day18";
            day18.Size = new Size(33, 27);
            day18.TabIndex = 25;
            day18.Text = "18";
            day18.UseVisualStyleBackColor = true;
            day18.Click += day18_Click;
            // 
            // day19
            // 
            day19.Location = new Point(25, 150);
            day19.Name = "day19";
            day19.Size = new Size(33, 27);
            day19.TabIndex = 26;
            day19.Text = "19";
            day19.UseVisualStyleBackColor = true;
            day19.Click += day19_Click;
            // 
            // day20
            // 
            day20.Location = new Point(67, 150);
            day20.Name = "day20";
            day20.Size = new Size(33, 27);
            day20.TabIndex = 27;
            day20.Text = "20";
            day20.UseVisualStyleBackColor = true;
            day20.Click += day20_Click;
            // 
            // day21
            // 
            day21.Location = new Point(103, 150);
            day21.Name = "day21";
            day21.Size = new Size(34, 27);
            day21.TabIndex = 28;
            day21.Text = "21";
            day21.UseVisualStyleBackColor = true;
            day21.Click += day21_Click;
            // 
            // day22
            // 
            day22.Location = new Point(143, 150);
            day22.Name = "day22";
            day22.Size = new Size(33, 27);
            day22.TabIndex = 29;
            day22.Text = "22";
            day22.UseVisualStyleBackColor = true;
            day22.Click += day22_Click;
            // 
            // day23
            // 
            day23.Location = new Point(182, 150);
            day23.Name = "day23";
            day23.Size = new Size(33, 27);
            day23.TabIndex = 30;
            day23.Text = "23";
            day23.UseVisualStyleBackColor = true;
            day23.Click += day23_Click;
            // 
            // day24
            // 
            day24.Location = new Point(221, 150);
            day24.Name = "day24";
            day24.Size = new Size(33, 27);
            day24.TabIndex = 31;
            day24.Text = "24";
            day24.UseVisualStyleBackColor = true;
            day24.Click += day24_Click;
            // 
            // day25
            // 
            day25.Location = new Point(25, 182);
            day25.Name = "day25";
            day25.Size = new Size(33, 27);
            day25.TabIndex = 32;
            day25.Text = "25";
            day25.UseVisualStyleBackColor = true;
            day25.Click += day25_Click;
            // 
            // day26
            // 
            day26.Location = new Point(67, 182);
            day26.Name = "day26";
            day26.Size = new Size(33, 27);
            day26.TabIndex = 33;
            day26.Text = "26";
            day26.UseVisualStyleBackColor = true;
            day26.Click += day26_Click;
            // 
            // day27
            // 
            day27.Location = new Point(103, 182);
            day27.Name = "day27";
            day27.Size = new Size(34, 27);
            day27.TabIndex = 34;
            day27.Text = "27";
            day27.UseVisualStyleBackColor = true;
            day27.Click += day27_Click;
            // 
            // day28
            // 
            day28.Location = new Point(143, 182);
            day28.Name = "day28";
            day28.Size = new Size(33, 27);
            day28.TabIndex = 35;
            day28.Text = "28";
            day28.UseVisualStyleBackColor = true;
            day28.Click += day28_Click;
            // 
            // day29
            // 
            day29.Location = new Point(182, 182);
            day29.Name = "day29";
            day29.Size = new Size(33, 27);
            day29.TabIndex = 36;
            day29.Text = "29";
            day29.UseVisualStyleBackColor = true;
            day29.Click += day29_Click;
            // 
            // day30
            // 
            day30.Location = new Point(221, 182);
            day30.Name = "day30";
            day30.Size = new Size(33, 27);
            day30.TabIndex = 37;
            day30.Text = "30";
            day30.UseVisualStyleBackColor = true;
            day30.Click += day30_Click;
            // 
            // day31
            // 
            day31.Location = new Point(25, 214);
            day31.Name = "day31";
            day31.Size = new Size(33, 27);
            day31.TabIndex = 38;
            day31.Text = "31";
            day31.UseVisualStyleBackColor = true;
            day31.Click += day31_Click;
            // 
            // AddCourse
            // 
            AddCourse.BackColor = Color.FromArgb(227, 231, 240);
            AddCourse.FlatAppearance.BorderSize = 0;
            AddCourse.FlatStyle = FlatStyle.Flat;
            AddCourse.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            AddCourse.Image = (Image)resources.GetObject("AddCourse.Image");
            AddCourse.Location = new Point(3, 157);
            AddCourse.Margin = new Padding(3, 4, 3, 4);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(113, 81);
            AddCourse.TabIndex = 39;
            AddCourse.Text = "افزودن کلاس";
            AddCourse.TextAlign = ContentAlignment.BottomCenter;
            AddCourse.TextImageRelation = TextImageRelation.ImageAboveText;
            AddCourse.UseVisualStyleBackColor = false;
            AddCourse.Click += AddCourse_Click;
            // 
            // yearlabelcul
            // 
            yearlabelcul.AutoSize = true;
            yearlabelcul.Font = new Font("Segoe UI", 11F);
            yearlabelcul.Location = new Point(85, 14);
            yearlabelcul.Name = "yearlabelcul";
            yearlabelcul.Size = new Size(52, 25);
            yearlabelcul.TabIndex = 9;
            yearlabelcul.Text = "0000";
            // 
            // monthlabelcul
            // 
            monthlabelcul.AutoSize = true;
            monthlabelcul.Font = new Font("Segoe UI", 11F);
            monthlabelcul.Location = new Point(153, 14);
            monthlabelcul.Name = "monthlabelcul";
            monthlabelcul.Size = new Size(32, 25);
            monthlabelcul.TabIndex = 40;
            monthlabelcul.Text = "00";
            monthlabelcul.TextChanged += monthlabelcul_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(137, 14);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 9;
            label3.Text = "/";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(192, 14);
            button3.Name = "button3";
            button3.Size = new Size(35, 29);
            button3.TabIndex = 41;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(44, 13);
            button4.Name = "button4";
            button4.Size = new Size(35, 29);
            button4.TabIndex = 42;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // todaybot
            // 
            todaybot.Location = new Point(192, 214);
            todaybot.Name = "todaybot";
            todaybot.Size = new Size(64, 33);
            todaybot.TabIndex = 43;
            todaybot.Text = "امروز";
            todaybot.UseVisualStyleBackColor = true;
            todaybot.Click += todaybot_Click;
            // 
            // enrollment
            // 
            enrollment.BackColor = Color.FromArgb(227, 231, 240);
            enrollment.FlatAppearance.BorderSize = 0;
            enrollment.FlatStyle = FlatStyle.Flat;
            enrollment.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            enrollment.Image = (Image)resources.GetObject("enrollment.Image");
            enrollment.Location = new Point(3, 324);
            enrollment.Name = "enrollment";
            enrollment.Size = new Size(113, 81);
            enrollment.TabIndex = 44;
            enrollment.Text = "ثبت نام";
            enrollment.TextAlign = ContentAlignment.BottomCenter;
            enrollment.TextImageRelation = TextImageRelation.ImageAboveText;
            enrollment.UseVisualStyleBackColor = false;
            enrollment.Click += button5_Click;
            // 
            // coursetodayGridView
            // 
            coursetodayGridView.BackgroundColor = Color.FromArgb(188, 184, 177);
            coursetodayGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursetodayGridView.Location = new Point(306, 8);
            coursetodayGridView.Name = "coursetodayGridView";
            coursetodayGridView.RowHeadersWidth = 51;
            coursetodayGridView.Size = new Size(620, 299);
            coursetodayGridView.TabIndex = 45;
            // 
            // todayclasslabel
            // 
            todayclasslabel.AutoSize = true;
            todayclasslabel.BackColor = Color.FromArgb(188, 184, 177);
            todayclasslabel.FlatStyle = FlatStyle.Flat;
            todayclasslabel.Font = new Font("B Nazanin", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            todayclasslabel.Location = new Point(468, 135);
            todayclasslabel.Name = "todayclasslabel";
            todayclasslabel.RightToLeft = RightToLeft.Yes;
            todayclasslabel.Size = new Size(324, 64);
            todayclasslabel.TabIndex = 46;
            todayclasslabel.Text = "امروز کلاسی ندارید !!!";
            todayclasslabel.Click += todayclasslabel_Click;
            // 
            // showbot
            // 
            showbot.BackColor = Color.FromArgb(227, 231, 240);
            showbot.FlatAppearance.BorderSize = 0;
            showbot.FlatStyle = FlatStyle.Flat;
            showbot.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            showbot.Image = (Image)resources.GetObject("showbot.Image");
            showbot.Location = new Point(4, 245);
            showbot.Name = "showbot";
            showbot.Size = new Size(113, 73);
            showbot.TabIndex = 47;
            showbot.Text = "نمایش";
            showbot.TextAlign = ContentAlignment.BottomCenter;
            showbot.TextImageRelation = TextImageRelation.ImageAboveText;
            showbot.UseVisualStyleBackColor = false;
            showbot.Click += showbot_Click;
            // 
            // classidcombo
            // 
            classidcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            classidcombo.Enabled = false;
            classidcombo.Font = new Font("Segoe UI", 11F);
            classidcombo.FormattingEnabled = true;
            classidcombo.Location = new Point(132, 14);
            classidcombo.Name = "classidcombo";
            classidcombo.Size = new Size(112, 33);
            classidcombo.TabIndex = 48;
            classidcombo.SelectedIndexChanged += classidcombo_SelectedIndexChanged;
            // 
            // truebot
            // 
            truebot.Enabled = false;
            truebot.Location = new Point(79, 15);
            truebot.Name = "truebot";
            truebot.Size = new Size(47, 33);
            truebot.TabIndex = 50;
            truebot.Text = "✔";
            truebot.UseVisualStyleBackColor = true;
            truebot.Click += truebot_Click;
            // 
            // falsebot
            // 
            falsebot.Enabled = false;
            falsebot.Location = new Point(26, 15);
            falsebot.Name = "falsebot";
            falsebot.Size = new Size(47, 33);
            falsebot.TabIndex = 51;
            falsebot.Text = "❌";
            falsebot.UseVisualStyleBackColor = true;
            falsebot.Click += falsebot_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(classidcombo);
            groupBox2.Controls.Add(falsebot);
            groupBox2.Controls.Add(truebot);
            groupBox2.Location = new Point(661, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 54);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Enabled = false;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(306, 313);
            button5.Name = "button5";
            button5.Size = new Size(620, 39);
            button5.TabIndex = 53;
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(acceptbot);
            groupBox3.Controls.Add(dayremedical);
            groupBox3.Controls.Add(monthremedical);
            groupBox3.Controls.Add(yearremedical);
            groupBox3.Location = new Point(306, 358);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 54);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(169, 20);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "تاریخ جبرانی";
            checkBox1.TextAlign = ContentAlignment.BottomCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // acceptbot
            // 
            acceptbot.Location = new Point(286, 14);
            acceptbot.Name = "acceptbot";
            acceptbot.Size = new Size(47, 33);
            acceptbot.TabIndex = 6;
            acceptbot.Text = "تایید";
            acceptbot.UseVisualStyleBackColor = true;
            acceptbot.Click += acceptbot_Click;
            // 
            // dayremedical
            // 
            dayremedical.Font = new Font("Segoe UI", 11F);
            dayremedical.Location = new Point(119, 15);
            dayremedical.Name = "dayremedical";
            dayremedical.Size = new Size(47, 32);
            dayremedical.TabIndex = 5;
            dayremedical.Visible = false;
            dayremedical.KeyPress += dayremedical_KeyPress;
            // 
            // monthremedical
            // 
            monthremedical.Font = new Font("Segoe UI", 11F);
            monthremedical.Location = new Point(76, 15);
            monthremedical.Name = "monthremedical";
            monthremedical.Size = new Size(37, 32);
            monthremedical.TabIndex = 4;
            monthremedical.Visible = false;
            monthremedical.KeyPress += monthremedical_KeyPress;
            // 
            // yearremedical
            // 
            yearremedical.Font = new Font("Segoe UI", 11F);
            yearremedical.Location = new Point(15, 15);
            yearremedical.Name = "yearremedical";
            yearremedical.Size = new Size(55, 32);
            yearremedical.TabIndex = 1;
            yearremedical.Visible = false;
            yearremedical.KeyPress += yearremedical_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 231, 240);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddCourse);
            panel2.Controls.Add(showbot);
            panel2.Controls.Add(enrollment);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(945, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 497);
            panel2.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 83, 80);
            panel3.Controls.Add(clocklabel);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(yearlabelpr);
            panel3.Controls.Add(monthlabelpr);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(daylabelpr);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 76);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(day1);
            panel4.Controls.Add(day2);
            panel4.Controls.Add(day3);
            panel4.Controls.Add(day4);
            panel4.Controls.Add(day5);
            panel4.Controls.Add(day6);
            panel4.Controls.Add(day7);
            panel4.Controls.Add(todaybot);
            panel4.Controls.Add(day8);
            panel4.Controls.Add(day9);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(day10);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(day11);
            panel4.Controls.Add(monthlabelcul);
            panel4.Controls.Add(day12);
            panel4.Controls.Add(yearlabelcul);
            panel4.Controls.Add(day13);
            panel4.Controls.Add(day31);
            panel4.Controls.Add(day14);
            panel4.Controls.Add(day30);
            panel4.Controls.Add(day15);
            panel4.Controls.Add(day29);
            panel4.Controls.Add(day16);
            panel4.Controls.Add(day28);
            panel4.Controls.Add(day17);
            panel4.Controls.Add(day27);
            panel4.Controls.Add(day18);
            panel4.Controls.Add(day26);
            panel4.Controls.Add(day19);
            panel4.Controls.Add(day25);
            panel4.Controls.Add(day20);
            panel4.Controls.Add(day24);
            panel4.Controls.Add(day21);
            panel4.Controls.Add(day23);
            panel4.Controls.Add(day22);
            panel4.Location = new Point(12, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 259);
            panel4.TabIndex = 57;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1066, 497);
            Controls.Add(groupBox2);
            Controls.Add(todayclasslabel);
            Controls.Add(coursetodayGridView);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(button5);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)coursetodayGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label yearlabelpr;
        private Label monthlabelpr;
        private Label daylabelpr;
        private Label label1;
        private Label label2;
        private Label clocklabel;
        private Button day1;
        private Button day2;
        private Button day3;
        private Button day4;
        private Button day5;
        private Button day6;
        private Button day7;
        private Button day8;
        private Button day9;
        private Button day10;
        private Button day11;
        private Button day12;
        private Button day13;
        private Button day14;
        private Button day15;
        private Button day16;
        private Button day17;
        private Button day18;
        private Button day19;
        private Button day20;
        private Button day21;
        private Button day22;
        private Button day23;
        private Button day24;
        private Button day25;
        private Button day26;
        private Button day27;
        private Button day28;
        private Button day29;
        private Button day30;
        private Button day31;
        private Button AddCourse;
        private Label yearlabelcul;
        private Label monthlabelcul;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button todaybot;
        private Button enrollment;
        private DataGridView coursetodayGridView;
        private Label todayclasslabel;
        private Button showbot;
        private ComboBox classidcombo;
        private Button truebot;
        private Button falsebot;
        private GroupBox groupBox2;
        private Button button5;
        private GroupBox groupBox3;
        private TextBox yearremedical;
        private TextBox monthremedical;
        private TextBox dayremedical;
        private Button acceptbot;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private CheckBox checkBox1;
    }
}
