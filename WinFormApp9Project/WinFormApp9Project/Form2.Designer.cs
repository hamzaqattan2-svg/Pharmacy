namespace WinFormApp9Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            butEnd = new Guna.UI2.WinForms.Guna2Button();
            butdel = new PictureBox();
            dvgExMed = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            butreq = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butdel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgExMed).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(855, 512);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges5;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FillColor = Color.OliveDrab;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.Black;
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(634, 51);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ComboBox1.Size = new Size(206, 36);
            guna2ComboBox1.TabIndex = 1;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // butEnd
            // 
            butEnd.Cursor = Cursors.AppStarting;
            butEnd.CustomizableEdges = customizableEdges7;
            butEnd.DisabledState.BorderColor = Color.DarkGray;
            butEnd.DisabledState.CustomBorderColor = Color.DarkGray;
            butEnd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            butEnd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            butEnd.FillColor = Color.YellowGreen;
            butEnd.Font = new Font("Segoe UI", 9F);
            butEnd.ForeColor = Color.Black;
            butEnd.Location = new Point(699, 487);
            butEnd.Name = "butEnd";
            butEnd.ShadowDecoration.CustomizableEdges = customizableEdges8;
            butEnd.Size = new Size(139, 44);
            butEnd.TabIndex = 3;
            butEnd.Text = "End";
            butEnd.Click += guna2Button1_Click;
            // 
            // butdel
            // 
            butdel.Image = Properties.Resources.images__1_;
            butdel.Location = new Point(21, 361);
            butdel.Name = "butdel";
            butdel.Size = new Size(115, 152);
            butdel.SizeMode = PictureBoxSizeMode.Zoom;
            butdel.TabIndex = 4;
            butdel.TabStop = false;
            butdel.Click += butdel_Click;
            // 
            // dvgExMed
            // 
            dvgExMed.BackgroundColor = Color.DarkOliveGreen;
            dvgExMed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgExMed.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dvgExMed.Location = new Point(194, 51);
            dvgExMed.Name = "dvgExMed";
            dvgExMed.RowHeadersWidth = 51;
            dvgExMed.Size = new Size(426, 285);
            dvgExMed.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 44);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 17);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Expired Medicines";
            // 
            // label2
            // 
            label2.BackColor = Color.OliveDrab;
            label2.Location = new Point(21, 487);
            label2.Name = "label2";
            label2.Size = new Size(115, 41);
            label2.TabIndex = 9;
            label2.Text = "Delete";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butreq
            // 
            butreq.BackColor = Color.OliveDrab;
            butreq.Location = new Point(344, 487);
            butreq.Name = "butreq";
            butreq.Size = new Size(130, 44);
            butreq.TabIndex = 10;
            butreq.Text = "request";
            butreq.UseVisualStyleBackColor = false;
            butreq.Click += butreq_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 543);
            Controls.Add(butreq);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dvgExMed);
            Controls.Add(butdel);
            Controls.Add(butEnd);
            Controls.Add(guna2ComboBox1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Expired Medicines";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)butdel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgExMed).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button butEnd;
        private PictureBox butdel;
        private DataGridView dvgExMed;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button butreq;
    }
}