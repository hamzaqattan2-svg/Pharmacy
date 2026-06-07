namespace WinFormApp9Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            butdel = new Guna.UI2.WinForms.Guna2ImageButton();
            textcomp = new TextBox();
            textcost = new TextBox();
            textSname = new TextBox();
            textTname = new TextBox();
            textQty = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dvgMedicines = new DataGridView();
            TName = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            butAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            butEdt = new Guna.UI2.WinForms.Guna2ImageButton();
            butClr = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            DtpExp = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgMedicines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__3_2;
            pictureBox1.Location = new Point(0, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1014, 597);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2ImageButton2
            // 
            guna2ImageButton2.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton2.Image = (Image)resources.GetObject("guna2ImageButton2.Image");
            guna2ImageButton2.ImageOffset = new Point(0, 0);
            guna2ImageButton2.ImageRotate = 0F;
            guna2ImageButton2.Location = new Point(325, 470);
            guna2ImageButton2.Name = "guna2ImageButton2";
            guna2ImageButton2.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton2.Size = new Size(0, 0);
            guna2ImageButton2.TabIndex = 39;
            // 
            // butdel
            // 
            butdel.CheckedState.ImageSize = new Size(64, 64);
            butdel.Cursor = Cursors.Hand;
            butdel.HoverState.ImageSize = new Size(64, 64);
            butdel.Image = (Image)resources.GetObject("butdel.Image");
            butdel.ImageOffset = new Point(0, 0);
            butdel.ImageRotate = 0F;
            butdel.Location = new Point(261, 520);
            butdel.Name = "butdel";
            butdel.PressedState.ImageSize = new Size(64, 64);
            butdel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            butdel.Size = new Size(76, 63);
            butdel.TabIndex = 38;
            butdel.Click += butdel_Click;
            // 
            // textcomp
            // 
            textcomp.Location = new Point(334, 266);
            textcomp.Name = "textcomp";
            textcomp.Size = new Size(196, 27);
            textcomp.TabIndex = 35;
            // 
            // textcost
            // 
            textcost.Location = new Point(334, 212);
            textcost.Name = "textcost";
            textcost.Size = new Size(196, 27);
            textcost.TabIndex = 34;
            // 
            // textSname
            // 
            textSname.Location = new Point(334, 157);
            textSname.Name = "textSname";
            textSname.Size = new Size(196, 27);
            textSname.TabIndex = 33;
            // 
            // textTname
            // 
            textTname.Location = new Point(334, 103);
            textTname.Name = "textTname";
            textTname.Size = new Size(196, 27);
            textTname.TabIndex = 32;
            // 
            // textQty
            // 
            textQty.Location = new Point(334, 56);
            textQty.Name = "textQty";
            textQty.Size = new Size(196, 27);
            textQty.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(195, 321);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 30;
            label6.Text = "Expiration date :";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(195, 269);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 29;
            label5.Text = "Company :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(195, 215);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 28;
            label4.Text = "Cost :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(195, 164);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 27;
            label3.Text = "Scientific Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(195, 106);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 26;
            label2.Text = "Trade Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(195, 59);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 25;
            label1.Text = "Amount :";
            // 
            // dvgMedicines
            // 
            dvgMedicines.BackgroundColor = Color.FromArgb(192, 255, 192);
            dvgMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMedicines.Columns.AddRange(new DataGridViewColumn[] { TName, Cost, Quantity });
            dvgMedicines.Location = new Point(546, 63);
            dvgMedicines.Name = "dvgMedicines";
            dvgMedicines.RowHeadersWidth = 51;
            dvgMedicines.Size = new Size(430, 285);
            dvgMedicines.TabIndex = 24;
            dvgMedicines.CellContentClick += dvgMedicines_CellContentClick;
            // 
            // TName
            // 
            TName.DataPropertyName = "TName";
            TName.HeaderText = "name";
            TName.MinimumWidth = 6;
            TName.Name = "TName";
            TName.Width = 125;
            // 
            // Cost
            // 
            Cost.DataPropertyName = "Cost";
            Cost.HeaderText = "cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__3_3;
            pictureBox2.Location = new Point(0, 357);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(244, 236);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // butAdd
            // 
            butAdd.CheckedState.ImageSize = new Size(64, 64);
            butAdd.Cursor = Cursors.Hand;
            butAdd.HoverState.ImageSize = new Size(64, 64);
            butAdd.Image = (Image)resources.GetObject("butAdd.Image");
            butAdd.ImageOffset = new Point(0, 0);
            butAdd.ImageRotate = 0F;
            butAdd.Location = new Point(343, 520);
            butAdd.Name = "butAdd";
            butAdd.PressedState.ImageSize = new Size(64, 64);
            butAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            butAdd.Size = new Size(62, 63);
            butAdd.TabIndex = 41;
            butAdd.Click += butAdd_Click;
            // 
            // butEdt
            // 
            butEdt.CheckedState.ImageSize = new Size(64, 64);
            butEdt.Cursor = Cursors.Hand;
            butEdt.HoverState.ImageSize = new Size(64, 64);
            butEdt.Image = (Image)resources.GetObject("butEdt.Image");
            butEdt.ImageOffset = new Point(0, 0);
            butEdt.ImageRotate = 0F;
            butEdt.Location = new Point(421, 520);
            butEdt.Name = "butEdt";
            butEdt.PressedState.ImageSize = new Size(64, 64);
            butEdt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            butEdt.Size = new Size(71, 63);
            butEdt.TabIndex = 42;
            butEdt.Click += butEdt_Click;
            // 
            // butClr
            // 
            butClr.CheckedState.ImageSize = new Size(64, 64);
            butClr.Cursor = Cursors.Hand;
            butClr.HoverState.ImageSize = new Size(64, 64);
            butClr.Image = (Image)resources.GetObject("butClr.Image");
            butClr.ImageOffset = new Point(0, 0);
            butClr.ImageRotate = 0F;
            butClr.Location = new Point(498, 520);
            butClr.Name = "butClr";
            butClr.PressedState.ImageSize = new Size(64, 64);
            butClr.ShadowDecoration.CustomizableEdges = customizableEdges5;
            butClr.Size = new Size(81, 63);
            butClr.TabIndex = 43;
            butClr.Click += butClr_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Cursor = Cursors.AppStarting;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(0, 192, 0);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(904, 526);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(110, 67);
            guna2CircleButton1.TabIndex = 44;
            guna2CircleButton1.Text = "End";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 42);
            panel1.TabIndex = 46;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 13);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 1;
            label8.Text = "Medication";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 13);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 0;
            // 
            // DtpExp
            // 
            DtpExp.Location = new Point(334, 321);
            DtpExp.Name = "DtpExp";
            DtpExp.Size = new Size(196, 27);
            DtpExp.TabIndex = 47;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 595);
            Controls.Add(DtpExp);
            Controls.Add(panel1);
            Controls.Add(guna2CircleButton1);
            Controls.Add(butClr);
            Controls.Add(butEdt);
            Controls.Add(butAdd);
            Controls.Add(pictureBox2);
            Controls.Add(guna2ImageButton2);
            Controls.Add(butdel);
            Controls.Add(textcomp);
            Controls.Add(textcost);
            Controls.Add(textSname);
            Controls.Add(textTname);
            Controls.Add(textQty);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgMedicines);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgMedicines).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton butdel;
        private TextBox textcomp;
        private TextBox textcost;
        private TextBox textSname;
        private TextBox textTname;
        private TextBox textQty;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dvgMedicines;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton butAdd;
        private Guna.UI2.WinForms.Guna2ImageButton butEdt;
        private Guna.UI2.WinForms.Guna2ImageButton butClr;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private DateTimePicker DtpExp;
        private DataGridViewTextBoxColumn TName;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Quantity;
    }
}
