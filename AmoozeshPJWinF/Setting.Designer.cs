namespace AmoozeshPJWinF
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            set = new Button();
            pathbot = new Button();
            showpath = new Label();
            label2 = new Label();
            label1 = new Label();
            dumppathlbl = new Label();
            helpdumpbot = new Button();
            changedumppathbot = new Button();
            SuspendLayout();
            // 
            // set
            // 
            set.Enabled = false;
            set.Location = new Point(93, 212);
            set.Name = "set";
            set.Size = new Size(219, 29);
            set.TabIndex = 0;
            set.Text = "شروع";
            set.UseVisualStyleBackColor = true;
            set.Click += set_Click;
            // 
            // pathbot
            // 
            pathbot.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            pathbot.Image = Properties.Resources.files20;
            pathbot.Location = new Point(265, 30);
            pathbot.Name = "pathbot";
            pathbot.Size = new Size(31, 28);
            pathbot.TabIndex = 1;
            pathbot.UseVisualStyleBackColor = true;
            pathbot.Click += pathbot_Click;
            // 
            // showpath
            // 
            showpath.AutoSize = true;
            showpath.BackColor = Color.Transparent;
            showpath.Location = new Point(187, 69);
            showpath.Name = "showpath";
            showpath.Size = new Size(18, 20);
            showpath.TabIndex = 2;
            showpath.Text = "...";
            showpath.SizeChanged += showpath_SizeChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            label2.Location = new Point(128, 102);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(139, 29);
            label2.TabIndex = 4;
            label2.Text = "مسیر فایل dump:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            label1.Location = new Point(141, 30);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(118, 29);
            label1.TabIndex = 3;
            label1.Text = "مسیر فایل بکاپ:";
            // 
            // dumppathlbl
            // 
            dumppathlbl.AutoSize = true;
            dumppathlbl.BackColor = Color.Transparent;
            dumppathlbl.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            dumppathlbl.Location = new Point(164, 140);
            dumppathlbl.Name = "dumppathlbl";
            dumppathlbl.Size = new Size(72, 27);
            dumppathlbl.TabIndex = 5;
            dumppathlbl.Text = "پیش فرض";
            dumppathlbl.SizeChanged += dumppathlbl_SizeChanged;
            // 
            // helpdumpbot
            // 
            helpdumpbot.Location = new Point(93, 102);
            helpdumpbot.Name = "helpdumpbot";
            helpdumpbot.Size = new Size(31, 28);
            helpdumpbot.TabIndex = 4;
            helpdumpbot.Text = "!";
            helpdumpbot.UseVisualStyleBackColor = true;
            helpdumpbot.Click += helpdumpbot_Click;
            // 
            // changedumppathbot
            // 
            changedumppathbot.Image = Properties.Resources.file20;
            changedumppathbot.Location = new Point(273, 101);
            changedumppathbot.Name = "changedumppathbot";
            changedumppathbot.Size = new Size(31, 28);
            changedumppathbot.TabIndex = 5;
            changedumppathbot.UseVisualStyleBackColor = true;
            changedumppathbot.Click += changedumppathbot_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(399, 275);
            Controls.Add(showpath);
            Controls.Add(changedumppathbot);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(helpdumpbot);
            Controls.Add(dumppathlbl);
            Controls.Add(pathbot);
            Controls.Add(set);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Setting";
            Text = "backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button set;
        private Button pathbot;
        private Label showpath;
        private Label label1;
        private Label label2;
        private Label dumppathlbl;
        private Button helpdumpbot;
        private Button changedumppathbot;
    }
}