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
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.Location = new Point(256, 59);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.Yes;
            courseID.Size = new Size(62, 32);
            courseID.TabIndex = 1;
            courseID.Text = "کد درس:";
            courseID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cost
            // 
            cost.Location = new Point(256, 177);
            cost.Name = "cost";
            cost.RightToLeft = RightToLeft.Yes;
            cost.Size = new Size(85, 21);
            cost.TabIndex = 2;
            cost.Text = "هزینه کلاس:";
            cost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // course_name
            // 
            course_name.Location = new Point(256, 142);
            course_name.Name = "course_name";
            course_name.RightToLeft = RightToLeft.Yes;
            course_name.Size = new Size(62, 15);
            course_name.TabIndex = 3;
            course_name.Text = "نام درس:";
            course_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // teacher_id
            // 
            teacher_id.Location = new Point(256, 100);
            teacher_id.Name = "teacher_id";
            teacher_id.RightToLeft = RightToLeft.Yes;
            teacher_id.Size = new Size(85, 23);
            teacher_id.TabIndex = 4;
            teacher_id.Text = "کد  ملی استاد:";
            teacher_id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // date_of_start
            // 
            date_of_start.Location = new Point(256, 215);
            date_of_start.Name = "date_of_start";
            date_of_start.RightToLeft = RightToLeft.Yes;
            date_of_start.Size = new Size(85, 26);
            date_of_start.TabIndex = 5;
            date_of_start.Text = "تاریخ شروع:";
            date_of_start.TextAlign = ContentAlignment.MiddleRight;
            // 
            // courseIDtxb
            // 
            courseIDtxb.Location = new Point(109, 65);
            courseIDtxb.Name = "courseIDtxb";
            courseIDtxb.Size = new Size(126, 23);
            courseIDtxb.TabIndex = 6;
            courseIDtxb.TextChanged += courseIDtxb_TextChanged;
            courseIDtxb.KeyPress += courseIDtxb_KeyPress;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(64, 215);
            datetxby.Name = "datetxby";
            datetxby.Size = new Size(56, 23);
            datetxby.TabIndex = 7;
            datetxby.TextChanged += datetxby_TextChanged;
            datetxby.KeyPress += datetxby_KeyPress;
            // 
            // costtxb
            // 
            costtxb.Location = new Point(109, 177);
            costtxb.Name = "costtxb";
            costtxb.Size = new Size(126, 23);
            costtxb.TabIndex = 8;
            costtxb.TextChanged += costtxb_TextChanged;
            costtxb.KeyPress += costtxb_KeyPress;
            // 
            // courseNametxb
            // 
            courseNametxb.Location = new Point(109, 139);
            courseNametxb.Name = "courseNametxb";
            courseNametxb.Size = new Size(126, 23);
            courseNametxb.TabIndex = 9;
            // 
            // teacherIDtxb
            // 
            teacherIDtxb.Location = new Point(109, 101);
            teacherIDtxb.Name = "teacherIDtxb";
            teacherIDtxb.Size = new Size(126, 23);
            teacherIDtxb.TabIndex = 10;
            teacherIDtxb.TextChanged += teacherIDtxb_TextChanged;
            teacherIDtxb.KeyPress += teacherIDtxb_KeyPress;
            // 
            // acceptButton
            // 
            acceptButton.Enabled = false;
            acceptButton.Location = new Point(37, 284);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(81, 27);
            acceptButton.TabIndex = 11;
            acceptButton.Text = "ثبت";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 213);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(15, 25);
            label1.TabIndex = 21;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 213);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(15, 25);
            label2.TabIndex = 22;
            label2.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(150, 215);
            datetxbm.Margin = new Padding(4, 3, 4, 3);
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(31, 23);
            datetxbm.TabIndex = 24;
            datetxbm.TextChanged += datetxbm_TextChanged;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(204, 216);
            datetxbd.Margin = new Padding(4, 3, 4, 3);
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(31, 23);
            datetxbd.TabIndex = 25;
            datetxbd.TextChanged += datetxbd_TextChanged;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 352);
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
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            Load += AddCourseForm_Load;
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
    }
}