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
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(770, 346);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 0;
            button1.Text = "AddUser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Adduser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(770, 391);
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
            // 
            // daylabelpr
            // 
            daylabelpr.AutoSize = true;
            daylabelpr.Font = new Font("Segoe UI", 11F);
            daylabelpr.Location = new Point(156, 16);
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
            groupBox1.Location = new Point(272, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 50);
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
            day1.Location = new Point(12, 147);
            day1.Name = "day1";
            day1.Size = new Size(33, 26);
            day1.TabIndex = 8;
            day1.Text = "01";
            day1.UseVisualStyleBackColor = true;
            // 
            // day2
            // 
            day2.Location = new Point(51, 147);
            day2.Name = "day2";
            day2.Size = new Size(33, 26);
            day2.TabIndex = 9;
            day2.Text = "02";
            day2.UseVisualStyleBackColor = true;
            // 
            // day3
            // 
            day3.Location = new Point(90, 147);
            day3.Name = "day3";
            day3.Size = new Size(33, 26);
            day3.TabIndex = 10;
            day3.Text = "03";
            day3.UseVisualStyleBackColor = true;
            // 
            // day4
            // 
            day4.Location = new Point(129, 147);
            day4.Name = "day4";
            day4.Size = new Size(33, 26);
            day4.TabIndex = 11;
            day4.Text = "04";
            day4.UseVisualStyleBackColor = true;
            // 
            // day5
            // 
            day5.Location = new Point(168, 147);
            day5.Name = "day5";
            day5.Size = new Size(33, 26);
            day5.TabIndex = 12;
            day5.Text = "05";
            day5.UseVisualStyleBackColor = true;
            // 
            // day6
            // 
            day6.Location = new Point(207, 147);
            day6.Name = "day6";
            day6.Size = new Size(33, 26);
            day6.TabIndex = 13;
            day6.Text = "06";
            day6.UseVisualStyleBackColor = true;
            // 
            // day7
            // 
            day7.Location = new Point(12, 179);
            day7.Name = "day7";
            day7.Size = new Size(33, 26);
            day7.TabIndex = 14;
            day7.Text = "07";
            day7.UseVisualStyleBackColor = true;
            // 
            // day8
            // 
            day8.Location = new Point(51, 179);
            day8.Name = "day8";
            day8.Size = new Size(33, 26);
            day8.TabIndex = 15;
            day8.Text = "08";
            day8.UseVisualStyleBackColor = true;
            // 
            // day9
            // 
            day9.Location = new Point(90, 179);
            day9.Name = "day9";
            day9.Size = new Size(33, 26);
            day9.TabIndex = 16;
            day9.Text = "09";
            day9.UseVisualStyleBackColor = true;
            // 
            // day10
            // 
            day10.Location = new Point(129, 179);
            day10.Name = "day10";
            day10.Size = new Size(33, 26);
            day10.TabIndex = 17;
            day10.Text = "10";
            day10.UseVisualStyleBackColor = true;
            // 
            // day11
            // 
            day11.Location = new Point(168, 179);
            day11.Name = "day11";
            day11.Size = new Size(33, 26);
            day11.TabIndex = 18;
            day11.Text = "11";
            day11.UseVisualStyleBackColor = true;
            // 
            // day12
            // 
            day12.Location = new Point(207, 179);
            day12.Name = "day12";
            day12.Size = new Size(33, 26);
            day12.TabIndex = 19;
            day12.Text = "12";
            day12.UseVisualStyleBackColor = true;
            // 
            // day13
            // 
            day13.Location = new Point(12, 211);
            day13.Name = "day13";
            day13.Size = new Size(33, 26);
            day13.TabIndex = 20;
            day13.Text = "13";
            day13.UseVisualStyleBackColor = true;
            // 
            // day14
            // 
            day14.Location = new Point(52, 211);
            day14.Name = "day14";
            day14.Size = new Size(33, 26);
            day14.TabIndex = 21;
            day14.Text = "14";
            day14.UseVisualStyleBackColor = true;
            // 
            // day15
            // 
            day15.Location = new Point(89, 211);
            day15.Name = "day15";
            day15.Size = new Size(34, 26);
            day15.TabIndex = 22;
            day15.Text = "15";
            day15.UseVisualStyleBackColor = true;
            // 
            // day16
            // 
            day16.Location = new Point(129, 210);
            day16.Name = "day16";
            day16.Size = new Size(33, 27);
            day16.TabIndex = 23;
            day16.Text = "16";
            day16.UseVisualStyleBackColor = true;
            // 
            // day17
            // 
            day17.Location = new Point(168, 210);
            day17.Name = "day17";
            day17.Size = new Size(33, 26);
            day17.TabIndex = 24;
            day17.Text = "17";
            day17.UseVisualStyleBackColor = true;
            // 
            // day18
            // 
            day18.Location = new Point(207, 209);
            day18.Name = "day18";
            day18.Size = new Size(33, 27);
            day18.TabIndex = 25;
            day18.Text = "18";
            day18.UseVisualStyleBackColor = true;
            // 
            // day19
            // 
            day19.Location = new Point(12, 243);
            day19.Name = "day19";
            day19.Size = new Size(33, 26);
            day19.TabIndex = 26;
            day19.Text = "19";
            day19.UseVisualStyleBackColor = true;
            // 
            // day20
            // 
            day20.Location = new Point(52, 243);
            day20.Name = "day20";
            day20.Size = new Size(33, 26);
            day20.TabIndex = 27;
            day20.Text = "20";
            day20.UseVisualStyleBackColor = true;
            // 
            // day21
            // 
            day21.Location = new Point(89, 243);
            day21.Name = "day21";
            day21.Size = new Size(34, 26);
            day21.TabIndex = 28;
            day21.Text = "21";
            day21.UseVisualStyleBackColor = true;
            // 
            // day22
            // 
            day22.Location = new Point(129, 242);
            day22.Name = "day22";
            day22.Size = new Size(33, 27);
            day22.TabIndex = 29;
            day22.Text = "22";
            day22.UseVisualStyleBackColor = true;
            // 
            // day23
            // 
            day23.Location = new Point(168, 243);
            day23.Name = "day23";
            day23.Size = new Size(33, 26);
            day23.TabIndex = 30;
            day23.Text = "23";
            day23.UseVisualStyleBackColor = true;
            // 
            // day24
            // 
            day24.Location = new Point(207, 243);
            day24.Name = "day24";
            day24.Size = new Size(33, 26);
            day24.TabIndex = 31;
            day24.Text = "24";
            day24.UseVisualStyleBackColor = true;
            // 
            // day25
            // 
            day25.Location = new Point(12, 275);
            day25.Name = "day25";
            day25.Size = new Size(33, 26);
            day25.TabIndex = 32;
            day25.Text = "25";
            day25.UseVisualStyleBackColor = true;
            // 
            // day26
            // 
            day26.Location = new Point(52, 275);
            day26.Name = "day26";
            day26.Size = new Size(33, 26);
            day26.TabIndex = 33;
            day26.Text = "26";
            day26.UseVisualStyleBackColor = true;
            // 
            // day27
            // 
            day27.Location = new Point(89, 275);
            day27.Name = "day27";
            day27.Size = new Size(34, 26);
            day27.TabIndex = 34;
            day27.Text = "27";
            day27.UseVisualStyleBackColor = true;
            // 
            // day28
            // 
            day28.Location = new Point(129, 275);
            day28.Name = "day28";
            day28.Size = new Size(33, 26);
            day28.TabIndex = 35;
            day28.Text = "28";
            day28.UseVisualStyleBackColor = true;
            // 
            // day29
            // 
            day29.Location = new Point(168, 274);
            day29.Name = "day29";
            day29.Size = new Size(33, 27);
            day29.TabIndex = 36;
            day29.Text = "29";
            day29.UseVisualStyleBackColor = true;
            // 
            // day30
            // 
            day30.Location = new Point(207, 275);
            day30.Name = "day30";
            day30.Size = new Size(33, 26);
            day30.TabIndex = 37;
            day30.Text = "30";
            day30.UseVisualStyleBackColor = true;
            // 
            // day31
            // 
            day31.Location = new Point(12, 307);
            day31.Name = "day31";
            day31.Size = new Size(33, 26);
            day31.TabIndex = 38;
            day31.Text = "31";
            day31.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(471, 245);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 39;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 483);
            Controls.Add(button3);
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
            ResumeLayout(false);
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
        private Button button3;
    }
}
