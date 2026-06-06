namespace WinFormApp9Project
{
    partial class Form5
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            butclr = new Guna.UI2.WinForms.Guna2CircleButton();
            butfltr = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            butend = new Guna.UI2.WinForms.Guna2Button();
            groupBox1 = new GroupBox();
            textcostto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textcomp = new TextBox();
            textdate = new TextBox();
            textcostfrom = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbSortDirection = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cmbSortBy = new ComboBox();
            label2 = new Label();
            dgvResults = new DataGridView();
            lblCount = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 8);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Pharmaceutical Filtration";
            // 
            // butclr
            // 
            butclr.DisabledState.BorderColor = Color.DarkGray;
            butclr.DisabledState.CustomBorderColor = Color.DarkGray;
            butclr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            butclr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            butclr.FillColor = Color.FromArgb(192, 255, 192);
            butclr.Font = new Font("Segoe UI", 9F);
            butclr.ForeColor = Color.Black;
            butclr.Location = new Point(30, 308);
            butclr.Name = "butclr";
            butclr.ShadowDecoration.CustomizableEdges = customizableEdges1;
            butclr.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            butclr.Size = new Size(94, 62);
            butclr.TabIndex = 14;
            butclr.Text = "Clear";
            butclr.Click += butclr_Click;
            // 
            // butfltr
            // 
            butfltr.DisabledState.BorderColor = Color.DarkGray;
            butfltr.DisabledState.CustomBorderColor = Color.DarkGray;
            butfltr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            butfltr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            butfltr.FillColor = Color.FromArgb(192, 255, 192);
            butfltr.Font = new Font("Segoe UI", 9F);
            butfltr.ForeColor = Color.Black;
            butfltr.Location = new Point(176, 308);
            butfltr.Name = "butfltr";
            butfltr.ShadowDecoration.CustomizableEdges = customizableEdges2;
            butfltr.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            butfltr.Size = new Size(88, 62);
            butfltr.TabIndex = 15;
            butfltr.Text = "Enter";
            butfltr.Click += butfltr_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(192, 255, 192);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(-2, 489);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(109, 43);
            guna2Button1.TabIndex = 17;
            guna2Button1.Text = "Close";
            // 
            // butend
            // 
            butend.CustomizableEdges = customizableEdges5;
            butend.DisabledState.BorderColor = Color.DarkGray;
            butend.DisabledState.CustomBorderColor = Color.DarkGray;
            butend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            butend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            butend.FillColor = Color.FromArgb(192, 255, 192);
            butend.Font = new Font("Segoe UI", 9F);
            butend.ForeColor = Color.Black;
            butend.Location = new Point(745, 489);
            butend.Name = "butend";
            butend.ShadowDecoration.CustomizableEdges = customizableEdges6;
            butend.Size = new Size(120, 43);
            butend.TabIndex = 18;
            butend.Text = "End";
            butend.Click += butend_click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textcostto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textcomp);
            groupBox1.Controls.Add(textdate);
            groupBox1.Controls.Add(textcostfrom);
            groupBox1.Controls.Add(butclr);
            groupBox1.Controls.Add(butfltr);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSortDirection);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbSortBy);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(73, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 397);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textcostto
            // 
            textcostto.Location = new Point(139, 182);
            textcostto.Name = "textcostto";
            textcostto.Size = new Size(125, 27);
            textcostto.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Location = new Point(73, 146);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 22;
            label7.Text = "from";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Location = new Point(73, 182);
            label8.Name = "label8";
            label8.Size = new Size(23, 20);
            label8.TabIndex = 23;
            label8.Text = "to";
            // 
            // textcomp
            // 
            textcomp.Location = new Point(139, 229);
            textcomp.Name = "textcomp";
            textcomp.Size = new Size(125, 27);
            textcomp.TabIndex = 24;
            // 
            // textdate
            // 
            textdate.Location = new Point(139, 266);
            textdate.Name = "textdate";
            textdate.Size = new Size(125, 27);
            textdate.TabIndex = 25;
            // 
            // textcostfrom
            // 
            textcostfrom.Location = new Point(139, 146);
            textcostfrom.Name = "textcostfrom";
            textcostfrom.Size = new Size(125, 27);
            textcostfrom.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Location = new Point(13, 236);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 21;
            label5.Text = "by company";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Location = new Point(13, 273);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 22;
            label6.Text = "by date";
            label6.Click += label6_Click;
            // 
            // cmbSortDirection
            // 
            cmbSortDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortDirection.FormattingEnabled = true;
            cmbSortDirection.Location = new Point(113, 76);
            cmbSortDirection.Name = "cmbSortDirection";
            cmbSortDirection.Size = new Size(151, 28);
            cmbSortDirection.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Location = new Point(13, 118);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 20;
            label4.Text = "by cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Location = new Point(13, 79);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "direction";
            label3.Click += label3_Click;
            // 
            // cmbSortBy
            // 
            cmbSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Location = new Point(113, 24);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(151, 28);
            cmbSortBy.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(13, 25);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "filter by";
            // 
            // dgvResults
            // 
            dgvResults.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(485, 68);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(300, 338);
            dgvResults.TabIndex = 20;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.BackColor = Color.FromArgb(192, 255, 192);
            lblCount.Location = new Point(604, 409);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(60, 20);
            lblCount.TabIndex = 21;
            lblCount.Text = "filter by";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(863, 534);
            Controls.Add(lblCount);
            Controls.Add(dgvResults);
            Controls.Add(groupBox1);
            Controls.Add(butend);
            Controls.Add(guna2Button1);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton butclr;
        private Guna.UI2.WinForms.Guna2CircleButton butfltr;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button butend;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private ComboBox cmbSortBy;
        private ComboBox cmbSortDirection;
        private Label label4;
        private Label label5;
        private TextBox textcomp;
        private TextBox textdate;
        private TextBox textcostfrom;
        private Label label6;
        private DataGridView dgvResults;
        private Label lblCount;
        private Label label7;
        private Label label8;
        private TextBox textcostto;
    }
}