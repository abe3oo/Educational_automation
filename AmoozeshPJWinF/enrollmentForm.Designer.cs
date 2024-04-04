namespace AmoozeshPJWinF
{
    partial class enrollmentForm
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
            courseID = new Label();
            date = new Label();
            whatsappGP = new Label();
            teacherID = new Label();
            WAgptxb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            datetxbm = new TextBox();
            datetxby = new TextBox();
            datetxbd = new TextBox();
            this.courseIDtxb = new TextBox();
            teacherIDtxb = new TextBox();
            sabtEnorollmetButton = new Button();
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.AutoSize = true;
            courseID.ImageAlign = ContentAlignment.MiddleRight;
            courseID.Location = new Point(308, 43);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.Yes;
            courseID.Size = new Size(49, 15);
            courseID.TabIndex = 0;
            courseID.Text = "کد درس:";
            // 
            // date
            // 
            date.AutoSize = true;
            date.ImageAlign = ContentAlignment.MiddleRight;
            date.Location = new Point(306, 133);
            date.Name = "date";
            date.RightToLeft = RightToLeft.Yes;
            date.Size = new Size(73, 15);
            date.TabIndex = 1;
            date.Text = "تاریخ ثبت نام:";
            // 
            // whatsappGP
            // 
            whatsappGP.AutoSize = true;
            whatsappGP.ImageAlign = ContentAlignment.MiddleRight;
            whatsappGP.Location = new Point(308, 175);
            whatsappGP.Name = "whatsappGP";
            whatsappGP.RightToLeft = RightToLeft.Yes;
            whatsappGP.Size = new Size(72, 15);
            whatsappGP.TabIndex = 2;
            whatsappGP.Text = "گروه واتساپ:";
            // 
            // teacherID
            // 
            teacherID.AutoSize = true;
            teacherID.ImageAlign = ContentAlignment.MiddleRight;
            teacherID.Location = new Point(308, 89);
            teacherID.Name = "teacherID";
            teacherID.RightToLeft = RightToLeft.Yes;
            teacherID.Size = new Size(78, 15);
            teacherID.TabIndex = 3;
            teacherID.Text = " کد ملی استاد:";
            // 
            // WAgptxb
            // 
            WAgptxb.Location = new Point(65, 175);
            WAgptxb.Margin = new Padding(4, 3, 4, 3);
            WAgptxb.Multiline = true;
            WAgptxb.Name = "WAgptxb";
            WAgptxb.Size = new Size(233, 120);
            WAgptxb.TabIndex = 17;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(15, 25);
            label2.TabIndex = 26;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(15, 25);
            label1.TabIndex = 25;
            label1.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(207, 130);
            datetxbm.Margin = new Padding(4, 3, 4, 3);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(31, 23);
            datetxbm.TabIndex = 24;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(134, 130);
            datetxby.Margin = new Padding(4, 3, 4, 3);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(46, 23);
            datetxby.TabIndex = 23;
            datetxby.TextAlign = HorizontalAlignment.Center;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(267, 130);
            datetxbd.Margin = new Padding(4, 3, 4, 3);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(31, 23);
            datetxbd.TabIndex = 22;
            // 
            // courseIDtxb
            // 
            this.courseIDtxb.Location = new Point(167, 40);
            this.courseIDtxb.Margin = new Padding(4, 3, 4, 3);
            this.courseIDtxb.MaxLength = 10;
            this.courseIDtxb.Name = "courseIDtxb";
            this.courseIDtxb.Size = new Size(131, 23);
            this.courseIDtxb.TabIndex = 27;
            // 
            // teacherIDtxb
            // 
            teacherIDtxb.Location = new Point(167, 86);
            teacherIDtxb.Margin = new Padding(4, 3, 4, 3);
            teacherIDtxb.MaxLength = 10;
            teacherIDtxb.Name = "teacherIDtxb";
            teacherIDtxb.Size = new Size(131, 23);
            teacherIDtxb.TabIndex = 28;
            // 
            // sabtEnorollmetButton
            // 
            sabtEnorollmetButton.Location = new Point(26, 334);
            sabtEnorollmetButton.Name = "sabtEnorollmetButton";
            sabtEnorollmetButton.Size = new Size(75, 23);
            sabtEnorollmetButton.TabIndex = 29;
            sabtEnorollmetButton.Text = "ثبت";
            sabtEnorollmetButton.UseVisualStyleBackColor = true;
            // 
            // enrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 388);
            Controls.Add(sabtEnorollmetButton);
            Controls.Add(teacherIDtxb);
            Controls.Add(this.courseIDtxb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datetxbm);
            Controls.Add(datetxby);
            Controls.Add(datetxbd);
            Controls.Add(WAgptxb);
            Controls.Add(teacherID);
            Controls.Add(whatsappGP);
            Controls.Add(date);
            Controls.Add(courseID);
            Name = "enrollmentForm";
            Text = "enrollmentForm";
            Load += this.enrollmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courseID;
        private Label date;
        private Label whatsappGP;
        private Label teacherID;
        private TextBox textBox1;
        private TextBox useridtbx;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox WAgptxb;
        private Label label2;
        private Label label1;
        private TextBox datetxbm;
        private TextBox datetxby;
        private TextBox datetxbd;
        private TextBox textBox4;
        private TextBox teacherIDtxb;
        private Button sabtEnorollmetButton;
    }
}