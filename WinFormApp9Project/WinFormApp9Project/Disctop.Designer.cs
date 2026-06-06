namespace WinFormApp9Project
{
    partial class Disctop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disctop));
            picBackDis = new PictureBox();
            picprogram1 = new PictureBox();
            picprogram2 = new PictureBox();
            picprogram3 = new PictureBox();
            picprogram5 = new PictureBox();
            picprogram4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBackDis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picprogram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picprogram2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picprogram3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picprogram5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picprogram4).BeginInit();
            SuspendLayout();
            // 
            // picBackDis
            // 
            picBackDis.Dock = DockStyle.Fill;
            picBackDis.Image = Properties.Resources.disctop;
            picBackDis.Location = new Point(0, 0);
            picBackDis.Name = "picBackDis";
            picBackDis.Size = new Size(867, 503);
            picBackDis.SizeMode = PictureBoxSizeMode.Zoom;
            picBackDis.TabIndex = 0;
            picBackDis.TabStop = false;
            // 
            // picprogram1
            // 
            picprogram1.Image = Properties.Resources.download__7_2;
            picprogram1.Location = new Point(801, 30);
            picprogram1.Name = "picprogram1";
            picprogram1.Size = new Size(50, 50);
            picprogram1.SizeMode = PictureBoxSizeMode.Zoom;
            picprogram1.TabIndex = 2;
            picprogram1.TabStop = false;
            picprogram1.Click += picprogram1_Click;
            // 
            // picprogram2
            // 
            picprogram2.Image = (Image)resources.GetObject("picprogram2.Image");
            picprogram2.Location = new Point(710, 30);
            picprogram2.Name = "picprogram2";
            picprogram2.Size = new Size(50, 50);
            picprogram2.SizeMode = PictureBoxSizeMode.Zoom;
            picprogram2.TabIndex = 3;
            picprogram2.TabStop = false;
            picprogram2.Click += picprogram2_Click;
            // 
            // picprogram3
            // 
            picprogram3.BackColor = Color.Transparent;
            picprogram3.ErrorImage = null;
            picprogram3.Image = Properties.Resources.download__3_6;
            picprogram3.Location = new Point(801, 110);
            picprogram3.Name = "picprogram3";
            picprogram3.Size = new Size(50, 50);
            picprogram3.SizeMode = PictureBoxSizeMode.Zoom;
            picprogram3.TabIndex = 4;
            picprogram3.TabStop = false;
            picprogram3.Click += picprogram3_Click;
            // 
            // picprogram5
            // 
            picprogram5.Image = Properties.Resources.Screenshot_2026_05_16_1811391;
            picprogram5.Location = new Point(801, 189);
            picprogram5.Name = "picprogram5";
            picprogram5.Size = new Size(50, 50);
            picprogram5.SizeMode = PictureBoxSizeMode.Zoom;
            picprogram5.TabIndex = 5;
            picprogram5.TabStop = false;
            picprogram5.Click += picprogram5_Click;
            // 
            // picprogram4
            // 
            picprogram4.Image = Properties.Resources.download__9_1;
            picprogram4.Location = new Point(710, 110);
            picprogram4.Name = "picprogram4";
            picprogram4.Size = new Size(50, 50);
            picprogram4.SizeMode = PictureBoxSizeMode.Zoom;
            picprogram4.TabIndex = 6;
            picprogram4.TabStop = false;
            picprogram4.Click += picprogram4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 7;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // Disctop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 503);
            Controls.Add(label1);
            Controls.Add(picprogram4);
            Controls.Add(picprogram5);
            Controls.Add(picprogram3);
            Controls.Add(picprogram2);
            Controls.Add(picprogram1);
            Controls.Add(picBackDis);
            Name = "Disctop";
            Text = "Disctop";
            Load += Disctop_Load;
            ((System.ComponentModel.ISupportInitialize)picBackDis).EndInit();
            ((System.ComponentModel.ISupportInitialize)picprogram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picprogram2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picprogram3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picprogram5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picprogram4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBackDis;
        private PictureBox picprogram1;
        private PictureBox picprogram2;
        private PictureBox picprogram3;
        private PictureBox picprogram5;
        private PictureBox picprogram4;
        private Label label1;
    }
}