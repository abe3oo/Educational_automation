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
            set = new Button();
            pathbot = new Button();
            showpath = new Label();
            SuspendLayout();
            // 
            // set
            // 
            set.Enabled = false;
            set.Location = new Point(188, 240);
            set.Name = "set";
            set.Size = new Size(112, 29);
            set.TabIndex = 0;
            set.Text = "شروع";
            set.UseVisualStyleBackColor = true;
            set.Click += set_Click;
            // 
            // pathbot
            // 
            pathbot.Location = new Point(188, 156);
            pathbot.Name = "pathbot";
            pathbot.Size = new Size(112, 29);
            pathbot.TabIndex = 1;
            pathbot.Text = "انتخاب مسیر";
            pathbot.UseVisualStyleBackColor = true;
            pathbot.Click += pathbot_Click;
            // 
            // showpath
            // 
            showpath.AutoSize = true;
            showpath.Location = new Point(49, 206);
            showpath.Name = "showpath";
            showpath.Size = new Size(18, 20);
            showpath.TabIndex = 2;
            showpath.Text = "...";
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 363);
            Controls.Add(showpath);
            Controls.Add(pathbot);
            Controls.Add(set);
            Name = "Setting";
            Text = "Setting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button set;
        private Button pathbot;
        private Label showpath;
    }
}