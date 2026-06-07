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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            datastore.LoadData();
            cmbSortBy.Items.Add("cost");
            cmbSortBy.Items.Add("company");
            cmbSortBy.Items.Add("date");
            cmbSortBy.SelectedIndex = 0;
            cmbSortDirection.Items.Add("upper");
            cmbSortDirection.Items.Add("lower");
            cmbSortDirection.SelectedIndex = 0;
            RefreshGrid(datastore.medicines);

        }

        void RefreshGrid(List<medicine> list)
        {
            dgvResults.Columns.Clear();
            dgvResults.AutoGenerateColumns = false;

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id"
            });

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TName",
                HeaderText = "TName",
                DataPropertyName = "Tname"
            }
                );

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sname",
                HeaderText = "Sname",
                DataPropertyName = "SName"
            }
                );

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cost",
                HeaderText = "Cost",
                DataPropertyName = "Cost"
            }
                );

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            }
                );

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Com",
                HeaderText = "Company",
                DataPropertyName = "Com"
            }
                );

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpDate",
                HeaderText = "ExpDate",
                DataPropertyName = "ExpDate"
            }
                );

            dgvResults.DataSource = null;
            dgvResults.DataSource = list;

            lblCount.Text = "عدد النتائج :" + list.Count.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butfltr_Click(object sender, EventArgs e)
        {

            decimal costFrom = 0;
            decimal costTo = 0;

            if (!string.IsNullOrWhiteSpace(textcostfrom.Text))
            {
                if (!decimal.TryParse(textcostfrom.Text, out costFrom))
                {
                    MessageBox.Show("يرجى إدخال سعر صحيح");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(textcostto.Text))
            {
                if (!decimal.TryParse(textcostto.Text, out costTo))
                {
                    MessageBox.Show("يرجى إدخال سعر صحيح");
                    return;
                }
            }

            if (costFrom > costTo)
            {
                MessageBox.Show("منطق خاطئ");
                return;
            }

            string sortBy = cmbSortBy.SelectedItem.ToString();
            bool ascending = cmbSortDirection.SelectedIndex == 0;

            List<medicine> results = datastore.FilterAndSort(
                textcomp.Text,
                costFrom,
                costTo,
                sortBy,
                ascending);

            if (results.Count == 0)
                MessageBox.Show("لا توجد نتائج...");

            RefreshGrid(results);

        }

        private void butclr_Click(object sender, EventArgs e)
        {
            textcostfrom.Text = "";
            textcomp.Text = "";
            textcostto.Text = "";
            textdate.Text = "";
            cmbSortBy.SelectedIndex = 0;
            cmbSortDirection.SelectedIndex = 0;
            RefreshGrid(datastore.medicines);
        }

        private void butend_click(object sender, EventArgs e)
        {
            Disctop dis = new Disctop();
            dis.Show();
            this.Close();
        }
    }
}
