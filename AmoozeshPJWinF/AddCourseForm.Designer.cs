namespace AmoozeshPJWinF
{
    partial class AddCourseForm
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
            cost = new Label();
            course_name = new Label();
            teacher_id = new Label();
            date_of_start = new Label();
            courseIDtxb = new TextBox();
            datetxby = new TextBox();
            costtxb = new TextBox();
            courseNametxb = new TextBox();
            teacherIDtxb = new TextBox();
            acceptButton = new Button();
            label1 = new Label();
            label2 = new Label();
            datetxbm = new TextBox();
            datetxbd = new TextBox();
            clocklabel = new Label();
            hourUpDown = new NumericUpDown();
            minUpDown = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)hourUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown).BeginInit();
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.Location = new Point(293, 79);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.Yes;
            courseID.Size = new Size(71, 43);
            courseID.TabIndex = 1;
            courseID.Text = "کد درس:";
            courseID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cost
            // 
            cost.Location = new Point(293, 236);
            cost.Name = "cost";
            cost.RightToLeft = RightToLeft.Yes;
            cost.Size = new Size(97, 28);
            cost.TabIndex = 2;
            cost.Text = "هزینه کلاس:";
            cost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // course_name
            // 
            course_name.Location = new Point(293, 189);
            course_name.Name = "course_name";
            course_name.RightToLeft = RightToLeft.Yes;
            course_name.Size = new Size(71, 20);
            course_name.TabIndex = 3;
            course_name.Text = "نام درس:";
            course_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // teacher_id
            // 
            teacher_id.Location = new Point(293, 133);
            teacher_id.Name = "teacher_id";
            teacher_id.RightToLeft = RightToLeft.Yes;
            teacher_id.Size = new Size(109, 31);
            teacher_id.TabIndex = 4;
            teacher_id.Text = "کد  ملی استاد:";
            teacher_id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // date_of_start
            // 
            date_of_start.Location = new Point(293, 287);
            date_of_start.Name = "date_of_start";
            date_of_start.RightToLeft = RightToLeft.Yes;
            date_of_start.Size = new Size(97, 35);
            date_of_start.TabIndex = 5;
            date_of_start.Text = "تاریخ شروع:";
            date_of_start.TextAlign = ContentAlignment.MiddleRight;
            // 
            // courseIDtxb
            // 
            courseIDtxb.Location = new Point(125, 87);
            courseIDtxb.Margin = new Padding(3, 4, 3, 4);
            courseIDtxb.Name = "courseIDtxb";
            courseIDtxb.Size = new Size(143, 27);
            courseIDtxb.TabIndex = 6;
            courseIDtxb.TextChanged += courseIDtxb_TextChanged;
            courseIDtxb.KeyPress += courseIDtxb_KeyPress;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(73, 287);
            datetxby.Margin = new Padding(3, 4, 3, 4);
            datetxby.MaxLength = 4;
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(63, 27);
            datetxby.TabIndex = 7;
            datetxby.TextChanged += datetxby_TextChanged;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // costtxb
            // 
            costtxb.Location = new Point(125, 236);
            costtxb.Margin = new Padding(3, 4, 3, 4);
            costtxb.Name = "costtxb";
            costtxb.Size = new Size(143, 27);
            costtxb.TabIndex = 8;
            costtxb.TextChanged += costtxb_TextChanged;
            costtxb.KeyPress += costtxb_KeyPress;
            // 
            // courseNametxb
            // 
            courseNametxb.Location = new Point(125, 185);
            courseNametxb.Margin = new Padding(3, 4, 3, 4);
            courseNametxb.Name = "courseNametxb";
            courseNametxb.Size = new Size(143, 27);
            courseNametxb.TabIndex = 9;
            // 
            // teacherIDtxb
            // 
            teacherIDtxb.Location = new Point(125, 135);
            teacherIDtxb.Margin = new Padding(3, 4, 3, 4);
            teacherIDtxb.Name = "teacherIDtxb";
            teacherIDtxb.Size = new Size(143, 27);
            teacherIDtxb.TabIndex = 10;
            teacherIDtxb.TextChanged += teacherIDtxb_TextChanged;
            teacherIDtxb.KeyPress += teacherIDtxb_KeyPress;
            // 
            // acceptButton
            // 
            acceptButton.Enabled = false;
            acceptButton.Location = new Point(42, 379);
            acceptButton.Margin = new Padding(3, 4, 3, 4);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(93, 36);
            acceptButton.TabIndex = 11;
            acceptButton.Text = "ثبت";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 284);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(17, 33);
            label1.TabIndex = 21;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 284);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(17, 33);
            label2.TabIndex = 22;
            label2.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(171, 287);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.MaxLength = 2;
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(35, 27);
            datetxbm.TabIndex = 24;
            datetxbm.TextChanged += datetxbm_TextChanged;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(233, 288);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.MaxLength = 2;
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(35, 27);
            datetxbd.TabIndex = 25;
            datetxbd.TextChanged += datetxbd_TextChanged;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // clocklabel
            // 
            clocklabel.Location = new Point(293, 340);
            clocklabel.Name = "clocklabel";
            clocklabel.RightToLeft = RightToLeft.Yes;
            clocklabel.Size = new Size(97, 35);
            clocklabel.TabIndex = 26;
            clocklabel.Text = "ساعت:";
            clocklabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // hourUpDown
            // 
            hourUpDown.Location = new Point(171, 345);
            hourUpDown.Name = "hourUpDown";
            hourUpDown.Size = new Size(37, 27);
            hourUpDown.TabIndex = 27;
            // 
            // minUpDown
            // 
            minUpDown.Location = new Point(233, 345);
            minUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minUpDown.Name = "minUpDown";
            minUpDown.Size = new Size(35, 27);
            minUpDown.TabIndex = 28;
            // 
            // label3
            // 
            label3.Location = new Point(214, 340);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(10, 35);
            label3.TabIndex = 29;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 469);
            Controls.Add(label3);
            Controls.Add(minUpDown);
            Controls.Add(hourUpDown);
            Controls.Add(clocklabel);
            Controls.Add(datetxbd);
            Controls.Add(datetxbm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(acceptButton);
            Controls.Add(teacherIDtxb);
            Controls.Add(courseNametxb);
            Controls.Add(costtxb);
            Controls.Add(datetxby);
            Controls.Add(courseIDtxb);
            Controls.Add(date_of_start);
            Controls.Add(teacher_id);
            Controls.Add(course_name);
            Controls.Add(cost);
            Controls.Add(courseID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            Load += AddCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)hourUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label courseID;
        private Label cost;
        private Label course_name;
        private Label teacher_id;
        private Label date_of_start;
        private TextBox courseIDtxb;
        private TextBox datetxby;
        private TextBox costtxb;
        private TextBox courseNametxb;
        private TextBox teacherIDtxb;
        private Button acceptButton;
        private Label label1;
        private Label label2;
        private TextBox datetxbm;
        private TextBox datetxbd;
        private Label clocklabel;
        private NumericUpDown hourUpDown;
        private NumericUpDown minUpDown;
        private Label label3;
    }
}