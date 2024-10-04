namespace AmoozeshPJWinF
{
    partial class info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            label1.Location = new Point(143, 178);
            label1.Name = "label1";
            label1.Size = new Size(129, 29);
            label1.TabIndex = 0;
            label1.Text = "اتومایسون دانشگاه";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 224);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "v1.0.b910018";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold);
            label3.Location = new Point(69, 268);
            label3.Name = "label3";
            label3.Size = new Size(281, 29);
            label3.TabIndex = 2;
            label3.Text = "سازندگان: امیررضا عباس زاده، فاطمه روشن";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 311);
            label4.Name = "label4";
            label4.Size = new Size(224, 25);
            label4.TabIndex = 3;
            label4.Text = "amirreza.a560@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 392);
            label5.Name = "label5";
            label5.Size = new Size(372, 23);
            label5.TabIndex = 4;
            label5.Text = "تمامی حقوق مادی و معنوی این اپلیکیشن برای سازندگان آن محفوظ میباشد.";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(143, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 105);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(396, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "info";
            Text = "درباره ما";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}