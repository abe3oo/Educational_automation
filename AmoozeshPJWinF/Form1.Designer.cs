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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(651, 147);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "AddUser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Adduser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(651, 225);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
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
            yearlabelpr.Location = new Point(49, 16);
            yearlabelpr.Name = "yearlabelpr";
            yearlabelpr.Size = new Size(52, 25);
            yearlabelpr.TabIndex = 2;
            yearlabelpr.Text = "0000";
            // 
            // monthlabelpr
            // 
            monthlabelpr.AutoSize = true;
            monthlabelpr.Font = new Font("Segoe UI", 11F);
            monthlabelpr.Location = new Point(118, 16);
            monthlabelpr.Name = "monthlabelpr";
            monthlabelpr.Size = new Size(32, 25);
            monthlabelpr.TabIndex = 3;
            monthlabelpr.Text = "00";
            // 
            // daylabelpr
            // 
            daylabelpr.AutoSize = true;
            daylabelpr.Font = new Font("Segoe UI", 11F);
            daylabelpr.Location = new Point(169, 16);
            daylabelpr.Name = "daylabelpr";
            daylabelpr.Size = new Size(32, 25);
            daylabelpr.TabIndex = 4;
            daylabelpr.Text = "00";
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
            label2.Location = new Point(147, 15);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 6;
            label2.Text = "/";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clocklabel);
            groupBox1.Controls.Add(yearlabelpr);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(monthlabelpr);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(daylabelpr);
            groupBox1.Location = new Point(238, 1);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 483);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
