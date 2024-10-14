namespace AmoozeshPJWinF
{
    partial class helpdumpinfo
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(399, 122);
            label1.TabIndex = 0;
            label1.Text = "در صورتی که اروری دریافت کردید که در آن مضمون pg_dump وجود داشت، مسیر فایل pg_dump.exe را از حالت پیش فرض خارج کرده و به مسیر جدید تغییر دهید.";
            // 
            // helpdumpinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 149);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "helpdumpinfo";
            Text = "help";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}