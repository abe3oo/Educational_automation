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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            courseID = new Label();
            cost = new Label();
            course_name = new Label();
            teacher_id = new Label();
            date_of_start = new Label();
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
            termcombobox = new ComboBox();
            numberofcoursebox = new TextBox();
            numberofcourselbl = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            idlabel = new Label();
            idpictureBox = new PictureBox();
            namepictureBox = new PictureBox();
            namelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)hourUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)namepictureBox).BeginInit();
            SuspendLayout();
            // 
            // courseID
            // 
            courseID.BackColor = Color.Transparent;
            courseID.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            courseID.Location = new Point(361, 150);
            courseID.Name = "courseID";
            courseID.RightToLeft = RightToLeft.No;
            courseID.Size = new Size(36, 28);
            courseID.TabIndex = 1;
            courseID.Text = "ترم";
            courseID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cost
            // 
            cost.BackColor = Color.Transparent;
            cost.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            cost.Location = new Point(313, 243);
            cost.Name = "cost";
            cost.RightToLeft = RightToLeft.No;
            cost.Size = new Size(84, 29);
            cost.TabIndex = 2;
            cost.Text = "هزینه کلاس";
            cost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // course_name
            // 
            course_name.BackColor = Color.Transparent;
            course_name.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            course_name.Location = new Point(334, 198);
            course_name.Name = "course_name";
            course_name.RightToLeft = RightToLeft.No;
            course_name.Size = new Size(63, 27);
            course_name.TabIndex = 3;
            course_name.Text = "نام درس";
            course_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // teacher_id
            // 
            teacher_id.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            teacher_id.Location = new Point(304, 23);
            teacher_id.Name = "teacher_id";
            teacher_id.RightToLeft = RightToLeft.Yes;
            teacher_id.Size = new Size(104, 31);
            teacher_id.TabIndex = 4;
            teacher_id.Text = "جستجوی استاد";
            teacher_id.TextAlign = ContentAlignment.MiddleRight;
            // 
            // date_of_start
            // 
            date_of_start.BackColor = Color.Transparent;
            date_of_start.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            date_of_start.Location = new Point(303, 294);
            date_of_start.Name = "date_of_start";
            date_of_start.RightToLeft = RightToLeft.No;
            date_of_start.Size = new Size(94, 30);
            date_of_start.TabIndex = 5;
            date_of_start.Text = "تاریخ شروع";
            date_of_start.TextAlign = ContentAlignment.MiddleRight;
            // 
            // datetxby
            // 
            datetxby.Location = new Point(101, 295);
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
            costtxb.Location = new Point(101, 245);
            costtxb.Margin = new Padding(3, 4, 3, 4);
            costtxb.Name = "costtxb";
            costtxb.Size = new Size(199, 27);
            costtxb.TabIndex = 4;
            costtxb.TextChanged += costtxb_TextChanged;
            costtxb.KeyPress += costtxb_KeyPress;
            // 
            // courseNametxb
            // 
            courseNametxb.Location = new Point(101, 198);
            courseNametxb.Margin = new Padding(3, 4, 3, 4);
            courseNametxb.Name = "courseNametxb";
            courseNametxb.Size = new Size(199, 27);
            courseNametxb.TabIndex = 3;
            // 
            // teacherIDtxb
            // 
            teacherIDtxb.Location = new Point(18, 23);
            teacherIDtxb.Margin = new Padding(3, 4, 3, 4);
            teacherIDtxb.MaxLength = 10;
            teacherIDtxb.Name = "teacherIDtxb";
            teacherIDtxb.Size = new Size(282, 27);
            teacherIDtxb.TabIndex = 1;
            teacherIDtxb.TextChanged += teacherIDtxb_TextChanged;
            teacherIDtxb.KeyPress += teacherIDtxb_KeyPress;
            // 
            // acceptButton
            // 
            acceptButton.Enabled = false;
            acceptButton.Font = new Font("B Nazanin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            acceptButton.Location = new Point(12, 406);
            acceptButton.Margin = new Padding(3, 4, 3, 4);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(105, 50);
            acceptButton.TabIndex = 11;
            acceptButton.Text = "ثبت";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 291);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(17, 33);
            label1.TabIndex = 21;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 291);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(17, 33);
            label2.TabIndex = 22;
            label2.Text = "/";
            // 
            // datetxbm
            // 
            datetxbm.Location = new Point(198, 295);
            datetxbm.Margin = new Padding(5, 4, 5, 4);
            datetxbm.MaxLength = 2;
            datetxbm.Name = "datetxbm";
            datetxbm.Size = new Size(39, 27);
            datetxbm.TabIndex = 6;
            datetxbm.TextChanged += datetxbm_TextChanged;
            datetxbm.KeyPress += datetxbm_KeyPress;
            // 
            // datetxbd
            // 
            datetxbd.Location = new Point(262, 295);
            datetxbd.Margin = new Padding(5, 4, 5, 4);
            datetxbd.MaxLength = 2;
            datetxbd.Name = "datetxbd";
            datetxbd.Size = new Size(38, 27);
            datetxbd.TabIndex = 5;
            datetxbd.TextChanged += datetxbd_TextChanged;
            datetxbd.KeyPress += datetxbd_KeyPress;
            // 
            // clocklabel
            // 
            clocklabel.BackColor = Color.Transparent;
            clocklabel.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            clocklabel.Location = new Point(343, 390);
            clocklabel.Name = "clocklabel";
            clocklabel.RightToLeft = RightToLeft.No;
            clocklabel.Size = new Size(54, 35);
            clocklabel.TabIndex = 26;
            clocklabel.Text = "ساعت";
            clocklabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // hourUpDown
            // 
            hourUpDown.Location = new Point(185, 394);
            hourUpDown.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            hourUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            hourUpDown.Name = "hourUpDown";
            hourUpDown.Size = new Size(44, 27);
            hourUpDown.TabIndex = 10;
            hourUpDown.ValueChanged += hourUpDown_ValueChanged;
            // 
            // minUpDown
            // 
            minUpDown.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            minUpDown.Location = new Point(255, 394);
            minUpDown.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            minUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            minUpDown.Name = "minUpDown";
            minUpDown.Size = new Size(42, 27);
            minUpDown.TabIndex = 9;
            minUpDown.ValueChanged += minUpDown_ValueChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(235, 389);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(13, 35);
            label3.TabIndex = 29;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // termcombobox
            // 
            termcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            termcombobox.FormattingEnabled = true;
            termcombobox.Items.AddRange(new object[] { "بهار", "تابستان", "پاییز", "زمستان" });
            termcombobox.Location = new Point(101, 150);
            termcombobox.Name = "termcombobox";
            termcombobox.Size = new Size(199, 28);
            termcombobox.TabIndex = 2;
            // 
            // numberofcoursebox
            // 
            numberofcoursebox.Location = new Point(101, 345);
            numberofcoursebox.Name = "numberofcoursebox";
            numberofcoursebox.Size = new Size(199, 27);
            numberofcoursebox.TabIndex = 8;
            numberofcoursebox.TextChanged += numberofcoursebox_TextChanged;
            numberofcoursebox.KeyPress += numberofcoursebox_KeyPress;
            // 
            // numberofcourselbl
            // 
            numberofcourselbl.BackColor = Color.Transparent;
            numberofcourselbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold);
            numberofcourselbl.Location = new Point(303, 348);
            numberofcourselbl.Name = "numberofcourselbl";
            numberofcourselbl.RightToLeft = RightToLeft.No;
            numberofcourselbl.Size = new Size(94, 24);
            numberofcourselbl.TabIndex = 32;
            numberofcourselbl.Text = "تعداد جلسات";
            numberofcourselbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 243, 238);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(teacherIDtxb);
            panel1.Controls.Add(teacher_id);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 119);
            panel1.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(idlabel, 1, 1);
            tableLayoutPanel1.Controls.Add(idpictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(namepictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(namelabel, 1, 0);
            tableLayoutPanel1.Location = new Point(18, 57);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(282, 62);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // idlabel
            // 
            idlabel.Anchor = AnchorStyles.Left;
            idlabel.AutoSize = true;
            idlabel.Location = new Point(209, 36);
            idlabel.Name = "idlabel";
            idlabel.RightToLeft = RightToLeft.Yes;
            idlabel.Size = new Size(40, 20);
            idlabel.TabIndex = 36;
            idlabel.Text = "خالی";
            idlabel.Visible = false;
            idlabel.TextChanged += idlabel_TextChanged;
            // 
            // idpictureBox
            // 
            idpictureBox.BackColor = Color.Transparent;
            idpictureBox.Image = (Image)resources.GetObject("idpictureBox.Image");
            idpictureBox.Location = new Point(255, 34);
            idpictureBox.Name = "idpictureBox";
            idpictureBox.Size = new Size(24, 23);
            idpictureBox.TabIndex = 34;
            idpictureBox.TabStop = false;
            // 
            // namepictureBox
            // 
            namepictureBox.BackColor = Color.Transparent;
            namepictureBox.Image = (Image)resources.GetObject("namepictureBox.Image");
            namepictureBox.Location = new Point(255, 3);
            namepictureBox.Name = "namepictureBox";
            namepictureBox.Size = new Size(24, 25);
            namepictureBox.TabIndex = 34;
            namepictureBox.TabStop = false;
            // 
            // namelabel
            // 
            namelabel.Anchor = AnchorStyles.Left;
            namelabel.AutoSize = true;
            namelabel.Location = new Point(209, 5);
            namelabel.Name = "namelabel";
            namelabel.RightToLeft = RightToLeft.Yes;
            namelabel.Size = new Size(40, 20);
            namelabel.TabIndex = 35;
            namelabel.Text = "خالی";
            namelabel.TextAlign = ContentAlignment.BottomCenter;
            namelabel.Visible = false;
            namelabel.Click += namelabel_Click;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(418, 469);
            Controls.Add(panel1);
            Controls.Add(numberofcourselbl);
            Controls.Add(numberofcoursebox);
            Controls.Add(termcombobox);
            Controls.Add(label3);
            Controls.Add(minUpDown);
            Controls.Add(hourUpDown);
            Controls.Add(clocklabel);
            Controls.Add(datetxbd);
            Controls.Add(datetxbm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(acceptButton);
            Controls.Add(courseNametxb);
            Controls.Add(costtxb);
            Controls.Add(datetxby);
            Controls.Add(date_of_start);
            Controls.Add(course_name);
            Controls.Add(cost);
            Controls.Add(courseID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            Load += AddCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)hourUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)namepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label courseID;
        private Label cost;
        private Label course_name;
        private Label teacher_id;
        private Label date_of_start;
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
        private ComboBox termcombobox;
        private TextBox numberofcoursebox;
        private Label numberofcourselbl;
        private Panel panel1;
        private PictureBox namepictureBox;
        private PictureBox idpictureBox;
        private Label idlabel;
        private Label namelabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}