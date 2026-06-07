namespace WinFormApp9Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            dgvInvoices = new DataGridView();
            dgvInvoiceDetails = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textid = new TextBox();
            texttotal = new TextBox();
            textdate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.download__9_;
            pictureBox1.Location = new Point(1, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 36);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 8);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "View invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 38);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 3;
            label2.Text = "View Ivoice📃📃📃📃📃";
            // 
            // guna2Button1
            // 
            guna2Button1.Cursor = Cursors.AppStarting;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(192, 255, 192);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(648, 406);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(151, 41);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "end";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // dgvInvoices
            // 
            dgvInvoices.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(349, 61);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(439, 194);
            dgvInvoices.TabIndex = 9;
            dgvInvoices.CellClick += dgvInvoices_CellClick;
            // 
            // dgvInvoiceDetails
            // 
            dgvInvoiceDetails.BackgroundColor = Color.PaleGreen;
            dgvInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceDetails.Location = new Point(349, 279);
            dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            dgvInvoiceDetails.RowHeadersWidth = 51;
            dgvInvoiceDetails.Size = new Size(119, 143);
            dgvInvoiceDetails.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 287);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 11;
            label3.Text = "id";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 329);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 12;
            label4.Text = "date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 370);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 13;
            label5.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 339);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 14;
            // 
            // textid
            // 
            textid.Location = new Point(556, 284);
            textid.Name = "textid";
            textid.Size = new Size(125, 27);
            textid.TabIndex = 15;
            // 
            // texttotal
            // 
            texttotal.Location = new Point(556, 367);
            texttotal.Name = "texttotal";
            texttotal.Size = new Size(125, 27);
            texttotal.TabIndex = 16;
            // 
            // textdate
            // 
            textdate.Location = new Point(556, 326);
            textdate.Name = "textdate";
            textdate.Size = new Size(125, 27);
            textdate.TabIndex = 17;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(textdate);
            Controls.Add(texttotal);
            Controls.Add(textid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvInvoiceDetails);
            Controls.Add(dgvInvoices);
            Controls.Add(guna2Button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridView dgvInvoices;
        private DataGridView dgvInvoiceDetails;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textid;
        private TextBox texttotal;
        private TextBox textdate;
    }
}