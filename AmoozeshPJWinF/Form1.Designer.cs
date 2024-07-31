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
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            yearlabelpr = new Label();
            monthlabelpr = new Label();
            daylabelpr = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
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
            acceptbot = new Button();
            dayremedical = new TextBox();
            monthremedical = new TextBox();
            yearremedical = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursetodayGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(832, 387);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 0;
            button1.Text = "AddUser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Adduser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(832, 422);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 1;
            button2.Text = "pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // yearlabelpr
            // 
            yearlabelpr.AutoSize = true;
            yearlabelpr.Font = new Font("Segoe UI", 11F);
            yearlabelpr.Location = new Point(58, 16);
            yearlabelpr.Name = "yearlabelpr";
            yearlabelpr.Size = new Size(52, 25);
            yearlabelpr.TabIndex = 2;
            yearlabelpr.Text = "0000";
            // 
            // monthlabelpr
            // 
            monthlabelpr.AutoSize = true;
            monthlabelpr.Font = new Font("Segoe UI", 11F);
            monthlabelpr.Location = new Point(117, 16);
            monthlabelpr.Name = "monthlabelpr";
            monthlabelpr.Size = new Size(32, 25);
            monthlabelpr.TabIndex = 3;
            monthlabelpr.Text = "00";
            monthlabelpr.TextChanged += monthlabelpr_TextChanged;
            // 
            // daylabelpr
            // 
            daylabelpr.AutoSize = true;
            daylabelpr.Font = new Font("Segoe UI", 11F);
            daylabelpr.Location = new Point(155, 16);
            daylabelpr.Name = "daylabelpr";
            daylabelpr.Size = new Size(32, 25);
            daylabelpr.TabIndex = 4;
            daylabelpr.Text = "00";
            daylabelpr.TextChanged += daylabelpr_TextChanged;
            daylabelpr.Click += daylabelpr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(103, 15);
            label1.Name = "label1";
            label1.Size = new Size(19, 25);
            label1.TabIndex = 5;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(142, 15);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 6;
            label2.Text = "/";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(clocklabel);
            groupBox1.Controls.Add(yearlabelpr);
            groupBox1.Controls.Add(monthlabelpr);
            groupBox1.Controls.Add(daylabelpr);
            groupBox1.Location = new Point(339, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 51);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // clocklabel
            // 
            clocklabel.AutoSize = true;
            clocklabel.Font = new Font("Segoe UI", 11F);
            clocklabel.Location = new Point(230, 17);
            clocklabel.Name = "clocklabel";
            clocklabel.Size = new Size(80, 25);
            clocklabel.TabIndex = 8;
            clocklabel.Text = "00:00:00";
            // 
            // day1
            // 
            day1.Location = new Point(11, 147);
            day1.Name = "day1";
            day1.Size = new Size(33, 27);
            day1.TabIndex = 8;
            day1.Text = "01";
            day1.UseVisualStyleBackColor = true;
            day1.Click += day1_Click;
            // 
            // day2
            // 
            day2.Location = new Point(51, 147);
            day2.Name = "day2";
            day2.Size = new Size(33, 27);
            day2.TabIndex = 9;
            day2.Text = "02";
            day2.UseVisualStyleBackColor = true;
            day2.Click += day2_Click;
            // 
            // day3
            // 
            day3.Location = new Point(90, 147);
            day3.Name = "day3";
            day3.Size = new Size(33, 27);
            day3.TabIndex = 10;
            day3.Text = "03";
            day3.UseVisualStyleBackColor = true;
            day3.Click += day3_Click;
            // 
            // day4
            // 
            day4.Location = new Point(129, 147);
            day4.Name = "day4";
            day4.Size = new Size(33, 27);
            day4.TabIndex = 11;
            day4.Text = "04";
            day4.UseVisualStyleBackColor = true;
            day4.Click += day4_Click;
            // 
            // day5
            // 
            day5.Location = new Point(168, 147);
            day5.Name = "day5";
            day5.Size = new Size(33, 27);
            day5.TabIndex = 12;
            day5.Text = "05";
            day5.UseVisualStyleBackColor = true;
            day5.Click += day5_Click;
            // 
            // day6
            // 
            day6.Location = new Point(207, 147);
            day6.Name = "day6";
            day6.Size = new Size(33, 27);
            day6.TabIndex = 13;
            day6.Text = "06";
            day6.UseVisualStyleBackColor = true;
            day6.Click += day6_Click;
            // 
            // day7
            // 
            day7.Location = new Point(11, 179);
            day7.Name = "day7";
            day7.Size = new Size(33, 27);
            day7.TabIndex = 14;
            day7.Text = "07";
            day7.UseVisualStyleBackColor = true;
            day7.Click += day7_Click;
            // 
            // day8
            // 
            day8.Location = new Point(51, 179);
            day8.Name = "day8";
            day8.Size = new Size(33, 27);
            day8.TabIndex = 15;
            day8.Text = "08";
            day8.UseVisualStyleBackColor = true;
            day8.Click += day8_Click;
            // 
            // day9
            // 
            day9.Location = new Point(90, 179);
            day9.Name = "day9";
            day9.Size = new Size(33, 27);
            day9.TabIndex = 16;
            day9.Text = "09";
            day9.UseVisualStyleBackColor = true;
            day9.Click += day9_Click;
            // 
            // day10
            // 
            day10.Location = new Point(129, 179);
            day10.Name = "day10";
            day10.Size = new Size(33, 27);
            day10.TabIndex = 17;
            day10.Text = "10";
            day10.UseVisualStyleBackColor = true;
            day10.Click += day10_Click;
            // 
            // day11
            // 
            day11.Location = new Point(168, 179);
            day11.Name = "day11";
            day11.Size = new Size(33, 27);
            day11.TabIndex = 18;
            day11.Text = "11";
            day11.UseVisualStyleBackColor = true;
            day11.Click += day11_Click;
            // 
            // day12
            // 
            day12.Location = new Point(207, 179);
            day12.Name = "day12";
            day12.Size = new Size(33, 27);
            day12.TabIndex = 19;
            day12.Text = "12";
            day12.UseVisualStyleBackColor = true;
            day12.Click += day12_Click;
            // 
            // day13
            // 
            day13.Location = new Point(11, 211);
            day13.Name = "day13";
            day13.Size = new Size(33, 27);
            day13.TabIndex = 20;
            day13.Text = "13";
            day13.UseVisualStyleBackColor = true;
            day13.Click += day13_Click;
            // 
            // day14
            // 
            day14.Location = new Point(53, 211);
            day14.Name = "day14";
            day14.Size = new Size(33, 27);
            day14.TabIndex = 21;
            day14.Text = "14";
            day14.UseVisualStyleBackColor = true;
            day14.Click += day14_Click;
            // 
            // day15
            // 
            day15.Location = new Point(89, 211);
            day15.Name = "day15";
            day15.Size = new Size(34, 27);
            day15.TabIndex = 22;
            day15.Text = "15";
            day15.UseVisualStyleBackColor = true;
            day15.Click += day15_Click;
            // 
            // day16
            // 
            day16.Location = new Point(129, 211);
            day16.Name = "day16";
            day16.Size = new Size(33, 27);
            day16.TabIndex = 23;
            day16.Text = "16";
            day16.UseVisualStyleBackColor = true;
            day16.Click += day16_Click;
            // 
            // day17
            // 
            day17.Location = new Point(168, 211);
            day17.Name = "day17";
            day17.Size = new Size(33, 27);
            day17.TabIndex = 24;
            day17.Text = "17";
            day17.UseVisualStyleBackColor = true;
            day17.Click += day17_Click;
            // 
            // day18
            // 
            day18.Location = new Point(207, 209);
            day18.Name = "day18";
            day18.Size = new Size(33, 27);
            day18.TabIndex = 25;
            day18.Text = "18";
            day18.UseVisualStyleBackColor = true;
            day18.Click += day18_Click;
            // 
            // day19
            // 
            day19.Location = new Point(11, 243);
            day19.Name = "day19";
            day19.Size = new Size(33, 27);
            day19.TabIndex = 26;
            day19.Text = "19";
            day19.UseVisualStyleBackColor = true;
            day19.Click += day19_Click;
            // 
            // day20
            // 
            day20.Location = new Point(53, 243);
            day20.Name = "day20";
            day20.Size = new Size(33, 27);
            day20.TabIndex = 27;
            day20.Text = "20";
            day20.UseVisualStyleBackColor = true;
            day20.Click += day20_Click;
            // 
            // day21
            // 
            day21.Location = new Point(89, 243);
            day21.Name = "day21";
            day21.Size = new Size(34, 27);
            day21.TabIndex = 28;
            day21.Text = "21";
            day21.UseVisualStyleBackColor = true;
            day21.Click += day21_Click;
            // 
            // day22
            // 
            day22.Location = new Point(129, 243);
            day22.Name = "day22";
            day22.Size = new Size(33, 27);
            day22.TabIndex = 29;
            day22.Text = "22";
            day22.UseVisualStyleBackColor = true;
            day22.Click += day22_Click;
            // 
            // day23
            // 
            day23.Location = new Point(168, 243);
            day23.Name = "day23";
            day23.Size = new Size(33, 27);
            day23.TabIndex = 30;
            day23.Text = "23";
            day23.UseVisualStyleBackColor = true;
            day23.Click += day23_Click;
            // 
            // day24
            // 
            day24.Location = new Point(207, 243);
            day24.Name = "day24";
            day24.Size = new Size(33, 27);
            day24.TabIndex = 31;
            day24.Text = "24";
            day24.UseVisualStyleBackColor = true;
            day24.Click += day24_Click;
            // 
            // day25
            // 
            day25.Location = new Point(11, 275);
            day25.Name = "day25";
            day25.Size = new Size(33, 27);
            day25.TabIndex = 32;
            day25.Text = "25";
            day25.UseVisualStyleBackColor = true;
            day25.Click += day25_Click;
            // 
            // day26
            // 
            day26.Location = new Point(53, 275);
            day26.Name = "day26";
            day26.Size = new Size(33, 27);
            day26.TabIndex = 33;
            day26.Text = "26";
            day26.UseVisualStyleBackColor = true;
            day26.Click += day26_Click;
            // 
            // day27
            // 
            day27.Location = new Point(89, 275);
            day27.Name = "day27";
            day27.Size = new Size(34, 27);
            day27.TabIndex = 34;
            day27.Text = "27";
            day27.UseVisualStyleBackColor = true;
            day27.Click += day27_Click;
            // 
            // day28
            // 
            day28.Location = new Point(129, 275);
            day28.Name = "day28";
            day28.Size = new Size(33, 27);
            day28.TabIndex = 35;
            day28.Text = "28";
            day28.UseVisualStyleBackColor = true;
            day28.Click += day28_Click;
            // 
            // day29
            // 
            day29.Location = new Point(168, 275);
            day29.Name = "day29";
            day29.Size = new Size(33, 27);
            day29.TabIndex = 36;
            day29.Text = "29";
            day29.UseVisualStyleBackColor = true;
            day29.Click += day29_Click;
            // 
            // day30
            // 
            day30.Location = new Point(207, 275);
            day30.Name = "day30";
            day30.Size = new Size(33, 27);
            day30.TabIndex = 37;
            day30.Text = "30";
            day30.UseVisualStyleBackColor = true;
            day30.Click += day30_Click;
            // 
            // day31
            // 
            day31.Location = new Point(11, 307);
            day31.Name = "day31";
            day31.Size = new Size(33, 27);
            day31.TabIndex = 38;
            day31.Text = "31";
            day31.UseVisualStyleBackColor = true;
            day31.Click += day31_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(832, 458);
            AddCourse.Margin = new Padding(3, 4, 3, 4);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(112, 31);
            AddCourse.TabIndex = 39;
            AddCourse.Text = "Add Course";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // yearlabelcul
            // 
            yearlabelcul.AutoSize = true;
            yearlabelcul.Font = new Font("Segoe UI", 11F);
            yearlabelcul.Location = new Point(71, 105);
            yearlabelcul.Name = "yearlabelcul";
            yearlabelcul.Size = new Size(52, 25);
            yearlabelcul.TabIndex = 9;
            yearlabelcul.Text = "0000";
            // 
            // monthlabelcul
            // 
            monthlabelcul.AutoSize = true;
            monthlabelcul.Font = new Font("Segoe UI", 11F);
            monthlabelcul.Location = new Point(139, 105);
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
            label3.Location = new Point(123, 105);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 9;
            label3.Text = "/";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(178, 105);
            button3.Name = "button3";
            button3.Size = new Size(35, 29);
            button3.TabIndex = 41;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 105);
            button4.Name = "button4";
            button4.Size = new Size(35, 29);
            button4.TabIndex = 42;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // todaybot
            // 
            todaybot.Location = new Point(178, 307);
            todaybot.Name = "todaybot";
            todaybot.Size = new Size(64, 33);
            todaybot.TabIndex = 43;
            todaybot.Text = "امروز";
            todaybot.UseVisualStyleBackColor = true;
            todaybot.Click += todaybot_Click;
            // 
            // enrollment
            // 
            enrollment.Location = new Point(832, 496);
            enrollment.Name = "enrollment";
            enrollment.Size = new Size(112, 29);
            enrollment.TabIndex = 44;
            enrollment.Text = "enrollment";
            enrollment.UseVisualStyleBackColor = true;
            enrollment.Click += button5_Click;
            // 
            // coursetodayGridView
            // 
            coursetodayGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursetodayGridView.Location = new Point(272, 105);
            coursetodayGridView.Name = "coursetodayGridView";
            coursetodayGridView.RowHeadersWidth = 51;
            coursetodayGridView.Size = new Size(672, 229);
            coursetodayGridView.TabIndex = 45;
            // 
            // todayclasslabel
            // 
            todayclasslabel.AutoSize = true;
            todayclasslabel.Location = new Point(832, 60);
            todayclasslabel.Name = "todayclasslabel";
            todayclasslabel.RightToLeft = RightToLeft.Yes;
            todayclasslabel.Size = new Size(112, 20);
            todayclasslabel.TabIndex = 46;
            todayclasslabel.Text = "کلاس های امروز:";
            // 
            // showbot
            // 
            showbot.Location = new Point(832, 352);
            showbot.Name = "showbot";
            showbot.Size = new Size(112, 29);
            showbot.TabIndex = 47;
            showbot.Text = "show";
            showbot.UseVisualStyleBackColor = true;
            showbot.Click += showbot_Click;
            // 
            // classidcombo
            // 
            classidcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            classidcombo.Enabled = false;
            classidcombo.FormattingEnabled = true;
            classidcombo.Location = new Point(127, 13);
            classidcombo.Name = "classidcombo";
            classidcombo.Size = new Size(112, 28);
            classidcombo.TabIndex = 48;
            classidcombo.SelectedIndexChanged += classidcombo_SelectedIndexChanged;
            // 
            // truebot
            // 
            truebot.Enabled = false;
            truebot.Location = new Point(71, 13);
            truebot.Name = "truebot";
            truebot.Size = new Size(35, 29);
            truebot.TabIndex = 50;
            truebot.Text = "✔";
            truebot.UseVisualStyleBackColor = true;
            truebot.Click += truebot_Click;
            // 
            // falsebot
            // 
            falsebot.Enabled = false;
            falsebot.Location = new Point(30, 13);
            falsebot.Name = "falsebot";
            falsebot.Size = new Size(35, 29);
            falsebot.TabIndex = 51;
            falsebot.Text = "❌";
            falsebot.UseVisualStyleBackColor = true;
            falsebot.Click += falsebot_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(classidcombo);
            groupBox2.Controls.Add(falsebot);
            groupBox2.Controls.Add(truebot);
            groupBox2.Location = new Point(272, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 47);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(533, 353);
            button5.Name = "button5";
            button5.Size = new Size(155, 29);
            button5.TabIndex = 53;
            button5.Text = "تغییر وضعیت برگزاری";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(acceptbot);
            groupBox3.Controls.Add(dayremedical);
            groupBox3.Controls.Add(monthremedical);
            groupBox3.Controls.Add(yearremedical);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(272, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 51);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // acceptbot
            // 
            acceptbot.Location = new Point(6, 17);
            acceptbot.Name = "acceptbot";
            acceptbot.Size = new Size(59, 29);
            acceptbot.TabIndex = 6;
            acceptbot.Text = "تایید";
            acceptbot.UseVisualStyleBackColor = true;
            acceptbot.Click += acceptbot_Click;
            // 
            // dayremedical
            // 
            dayremedical.Location = new Point(202, 17);
            dayremedical.Name = "dayremedical";
            dayremedical.Size = new Size(37, 27);
            dayremedical.TabIndex = 5;
            dayremedical.KeyPress += dayremedical_KeyPress;
            // 
            // monthremedical
            // 
            monthremedical.Location = new Point(155, 17);
            monthremedical.Name = "monthremedical";
            monthremedical.Size = new Size(37, 27);
            monthremedical.TabIndex = 4;
            monthremedical.KeyPress += monthremedical_KeyPress;
            // 
            // yearremedical
            // 
            yearremedical.Location = new Point(89, 17);
            yearremedical.Name = "yearremedical";
            yearremedical.Size = new Size(55, 27);
            yearremedical.TabIndex = 1;
            yearremedical.KeyPress += yearremedical_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 21);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(189, 20);
            label4.TabIndex = 0;
            label4.Text = "تاریخ جبرانی را مشخص کنید :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 533);
            Controls.Add(groupBox3);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(showbot);
            Controls.Add(todayclasslabel);
            Controls.Add(coursetodayGridView);
            Controls.Add(enrollment);
            Controls.Add(todaybot);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(monthlabelcul);
            Controls.Add(yearlabelcul);
            Controls.Add(AddCourse);
            Controls.Add(day31);
            Controls.Add(day30);
            Controls.Add(day29);
            Controls.Add(day28);
            Controls.Add(day27);
            Controls.Add(day26);
            Controls.Add(day25);
            Controls.Add(day24);
            Controls.Add(day23);
            Controls.Add(day22);
            Controls.Add(day21);
            Controls.Add(day20);
            Controls.Add(day19);
            Controls.Add(day18);
            Controls.Add(day17);
            Controls.Add(day16);
            Controls.Add(day15);
            Controls.Add(day14);
            Controls.Add(day13);
            Controls.Add(day12);
            Controls.Add(day11);
            Controls.Add(day10);
            Controls.Add(day9);
            Controls.Add(day8);
            Controls.Add(day7);
            Controls.Add(day6);
            Controls.Add(day5);
            Controls.Add(day4);
            Controls.Add(day3);
            Controls.Add(day2);
            Controls.Add(day1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursetodayGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox1;
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
        private Label label4;
        private TextBox monthremedical;
        private TextBox dayremedical;
        private Button acceptbot;
    }
}
