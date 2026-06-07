namespace WinFormApp9Project
{
    partial class FormMe
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
            components = new System.ComponentModel.Container();
            picBackground = new PictureBox();
            picPerson = new PictureBox();
            pnlDialog = new Panel();
            butback = new Button();
            butnext = new Button();
            lblText = new Label();
            lblName = new Label();
            timertext = new System.Windows.Forms.Timer(components);
            butDisctop = new Button();
            lbldeveloper = new Label();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPerson).BeginInit();
            pnlDialog.SuspendLayout();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBackground.BackColor = Color.Black;
            picBackground.Location = new Point(-5, -30);
            picBackground.Margin = new Padding(3, 4, 3, 4);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(1935, 1025);
            picBackground.SizeMode = PictureBoxSizeMode.Zoom;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // picPerson
            // 
            picPerson.Anchor = AnchorStyles.None;
            picPerson.BackColor = Color.Transparent;
            picPerson.Location = new Point(1076, 507);
            picPerson.Margin = new Padding(3, 4, 3, 4);
            picPerson.MaximumSize = new Size(450, 562);
            picPerson.Name = "picPerson";
            picPerson.Size = new Size(300, 375);
            picPerson.SizeMode = PictureBoxSizeMode.Zoom;
            picPerson.TabIndex = 1;
            picPerson.TabStop = false;
            picPerson.Click += picPerson_Click;
            // 
            // pnlDialog
            // 
            pnlDialog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDialog.BackColor = Color.Black;
            pnlDialog.Controls.Add(butback);
            pnlDialog.Controls.Add(butnext);
            pnlDialog.Controls.Add(lblText);
            pnlDialog.Controls.Add(lblName);
            pnlDialog.ForeColor = Color.White;
            pnlDialog.Location = new Point(375, 757);
            pnlDialog.Margin = new Padding(3, 4, 3, 4);
            pnlDialog.Name = "pnlDialog";
            pnlDialog.Size = new Size(1178, 252);
            pnlDialog.TabIndex = 2;
            pnlDialog.Paint += pnlDialog_Paint;
            // 
            // butback
            // 
            butback.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            butback.AutoSize = true;
            butback.BackColor = Color.FromArgb(255, 255, 192);
            butback.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butback.ForeColor = Color.Black;
            butback.Location = new Point(827, 173);
            butback.Margin = new Padding(3, 4, 3, 4);
            butback.Name = "butback";
            butback.Size = new Size(112, 65);
            butback.TabIndex = 4;
            butback.Text = "back";
            butback.UseVisualStyleBackColor = false;
            butback.Click += butback_Click;
            // 
            // butnext
            // 
            butnext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            butnext.AutoSize = true;
            butnext.BackColor = Color.FromArgb(255, 255, 192);
            butnext.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butnext.ForeColor = Color.Black;
            butnext.Location = new Point(1051, 173);
            butnext.Margin = new Padding(3, 4, 3, 4);
            butnext.Name = "butnext";
            butnext.Size = new Size(112, 65);
            butnext.TabIndex = 3;
            butnext.Text = "next";
            butnext.UseVisualStyleBackColor = false;
            butnext.Click += butnext_Click;
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblText.Location = new Point(18, 56);
            lblText.Name = "lblText";
            lblText.RightToLeft = RightToLeft.Yes;
            lblText.Size = new Size(1145, 182);
            lblText.TabIndex = 1;
            lblText.Text = "label1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(13, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 32);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // timertext
            // 
            timertext.Interval = 40;
            timertext.Tick += timertext_Tick;
            // 
            // butDisctop
            // 
            butDisctop.BackColor = Color.Transparent;
            butDisctop.Cursor = Cursors.Hand;
            butDisctop.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butDisctop.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butDisctop.FlatStyle = FlatStyle.Flat;
            butDisctop.Location = new Point(774, 580);
            butDisctop.Name = "butDisctop";
            butDisctop.Size = new Size(296, 199);
            butDisctop.TabIndex = 3;
            butDisctop.UseVisualStyleBackColor = false;
            butDisctop.Click += butDisctop_Click;
            // 
            // lbldeveloper
            // 
            lbldeveloper.AutoSize = true;
            lbldeveloper.BackColor = Color.Transparent;
            lbldeveloper.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldeveloper.ForeColor = SystemColors.ButtonHighlight;
            lbldeveloper.Location = new Point(51, 44);
            lbldeveloper.Name = "lbldeveloper";
            lbldeveloper.Size = new Size(76, 31);
            lbldeveloper.TabIndex = 4;
            lbldeveloper.Text = "label1";
            // 
            // FormMe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1942, 1024);
            Controls.Add(lbldeveloper);
            Controls.Add(butDisctop);
            Controls.Add(picPerson);
            Controls.Add(pnlDialog);
            Controls.Add(picBackground);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "slide1";
            WindowState = FormWindowState.Maximized;
            Load += FormMe_Load;
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPerson).EndInit();
            pnlDialog.ResumeLayout(false);
            pnlDialog.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.Button butnext;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer timertext;
        private System.Windows.Forms.Button butback;
        private Button butDisctop;
        private Label lbldeveloper;
    }
}

