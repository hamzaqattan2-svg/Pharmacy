namespace WinFormApp9Project
{
    partial class login
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
            panel1 = new Panel();
            label1 = new Label();
            lblemail = new Label();
            textemail = new TextBox();
            lblpass = new Label();
            textpass = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            chkrebot = new CheckBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 44);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 0;
            label1.Text = "login";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.BackColor = Color.PaleGreen;
            lblemail.Location = new Point(88, 64);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 3;
            lblemail.Text = "email";
            lblemail.Click += label2_Click;
            // 
            // textemail
            // 
            textemail.Location = new Point(176, 61);
            textemail.Name = "textemail";
            textemail.Size = new Size(284, 27);
            textemail.TabIndex = 4;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.PaleGreen;
            lblpass.Location = new Point(88, 153);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(72, 20);
            lblpass.TabIndex = 5;
            lblpass.Text = "password";
            // 
            // textpass
            // 
            textpass.Location = new Point(176, 146);
            textpass.Name = "textpass";
            textpass.Size = new Size(284, 27);
            textpass.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 246);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "remember me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(603, 276);
            button1.Name = "button1";
            button1.Size = new Size(185, 41);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 368);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 9;
            label4.Text = "_ Dont have an account ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(230, 366);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 10;
            label5.Text = "Creat Account";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(29, 47);
            label6.Name = "label6";
            label6.Size = new Size(67, 46);
            label6.TabIndex = 11;
            label6.Text = "🙎‍♂️";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(29, 133);
            label7.Name = "label7";
            label7.Size = new Size(67, 46);
            label7.TabIndex = 12;
            label7.Text = "✉️";
            // 
            // chkrebot
            // 
            chkrebot.AutoSize = true;
            chkrebot.Location = new Point(437, 293);
            chkrebot.Name = "chkrebot";
            chkrebot.Size = new Size(136, 24);
            chkrebot.TabIndex = 13;
            chkrebot.Text = "I Am Not Robot";
            chkrebot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(50, 188);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 14;
            label2.Text = "forget password?";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(label2);
            Controls.Add(chkrebot);
            Controls.Add(lblpass);
            Controls.Add(label7);
            Controls.Add(lblemail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textpass);
            Controls.Add(textemail);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblemail;
        private TextBox textemail;
        private Label lblpass;
        private TextBox textpass;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox chkrebot;
        private Label label2;
    }
}