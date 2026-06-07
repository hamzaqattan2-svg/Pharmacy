using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp9Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        void RefreshInvoices()
        {
            dgvInvoices.Columns.Clear();
            dgvInvoices.AutoGenerateColumns = false;

            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "date",
                HeaderText = "date",
                DataPropertyName = "DateSell"

            });



            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total",
                HeaderText = "total",
                DataPropertyName = "totalinv"

            });



            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "id",
                DataPropertyName = "invoId"

            });

            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = datastore.Invoices;
        }


        void ShowInvoiceDetails(invoice inv)
        {
            textid.Text = inv.invoId.ToString();
            textdate.Text = inv.DateSell.ToString();
            texttotal.Text = inv.totalinv.ToString();

            dgvInvoiceDetails.Columns.Clear();
            dgvInvoiceDetails.AutoGenerateColumns = false;

            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "medicine",
                HeaderText = "medicine",
                DataPropertyName = "MedicineName"

            });


            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity",
                HeaderText = "quantity",
                DataPropertyName = "Quantsell"

            });


            dgvInvoiceDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "subtotal",
                HeaderText = "cost",
                DataPropertyName = "Subtotal"

            });

            dgvInvoiceDetails.DataSource = null;
            dgvInvoiceDetails.DataSource = inv.Items;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            datastore.LoadData();
            RefreshInvoices();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Disctop Dis = new Disctop();
            Dis.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dgvInvoices.Rows[e.RowIndex].Cells["invoId"].Value;
                invoice inv = datastore.Invoices.Find(i => i.invoId == id);
                if (inv != null)
                    ShowInvoiceDetails(inv);
            }
        }
    }
}
