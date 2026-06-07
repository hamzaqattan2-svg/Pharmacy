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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void RefreshGrid()
        {
            dvgMedicines.Columns.Clear();

            dvgMedicines.AutoGenerateColumns = false;


            dvgMedicines.Columns.Add(new DataGridViewTextBoxColumn { Name = "name",HeaderText = "name", DataPropertyName = "TName" });
            dvgMedicines.Columns.Add(new DataGridViewTextBoxColumn { Name = "cost", HeaderText = "cost", DataPropertyName = "Cost" });
            dvgMedicines.Columns.Add(new DataGridViewTextBoxColumn { Name = "quantity", HeaderText = "quantity", DataPropertyName = "Quantity" });



            var idColumn = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "Id" };
            idColumn.Visible = false;
            dvgMedicines.Columns.Add(idColumn);

            dvgMedicines.DataSource = null;
            dvgMedicines.DataSource = datastore.medicines;
        }

        void ClearFields()
        {
            textTname.Text = "";
            textSname.Text = "";
            textcost.Text = "";
            textQty.Text = "";
            textcomp.Text = "";
            DtpExp.Value = DateTime.Today;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            datastore.LoadData();
            RefreshGrid();
        }

        

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (textTname.Text == "" || textcost.Text == "" || textQty.Text == "")
            {
                MessageBox.Show("عليك ملء جميع الحقول");
                return;
            }

            medicine m = new medicine(
                int.Parse(textQty.Text),
                textTname.Text,
                textSname.Text,
                datastore.LastID + 1,
                DtpExp.Value,
                textcomp.Text,
                decimal.Parse(textcost.Text));

            datastore.Addmed(m);
            MessageBox.Show("تم اضافة الدواء بنجاح");
            ClearFields();
            RefreshGrid();

        }

        private void butdel_Click(object sender, EventArgs e)
        {

            if (dvgMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى الإختيار من الجدول");
                return;
            }
            int id = (int)dvgMedicines.SelectedRows[0].Cells["Id"].Value;

            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا الدواء", "تأكيد الحذف", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                datastore.deleteMed(id);
                MessageBox.Show("تم حذف الدواء بنجاح");
                RefreshGrid();
            }

        }

        private void butEdt_Click(object sender, EventArgs e)
        {
            if (dvgMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى الإختيار من الجدول");
                return;
            }
            int id = (int)dvgMedicines.SelectedRows[0].Cells["Id"].Value;

            medicine m = datastore.findById(id);
            if (textTname.Text != "")
                m.TName = textTname.Text;

            if (textSname.Text != "")
                m.SName = textSname.Text;

            if (textcost.Text != "")
                m.Cost = decimal.Parse(textcost.Text);
            
            if (textQty.Text != "")
                m.Quantity = int.Parse(textQty.Text);

                m.ExpDate = DtpExp.Value;

            if(textcomp.Text != "")
                m.Com = textcomp.Text;

            datastore.EditMed(m);
            MessageBox.Show("تم تعديل الدواء بنجاح");


            ClearFields();
            RefreshGrid();
        }


        private void butClr_Click(object sender, EventArgs e)
        {

            ClearFields();

        }
/*
        public void AddToTable()
        {
            foreach (var medicine in datastore.medicines)
            {
                dvgMedicines.Rows.Add(
                    medicine.TName,
                    medicine.Cost,
                    medicine.Quantity
                    );
            }
        }*/
        private void dvgMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dvgMedicines.Rows[e.RowIndex].Cells["Id"].Value;

                medicine m = datastore.findById(id);

                textTname.Text = m.TName;
                textcost.Text = m.Cost.ToString();
                textQty.Text = m.Quantity.ToString();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            Disctop dis = new Disctop();
            dis.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
