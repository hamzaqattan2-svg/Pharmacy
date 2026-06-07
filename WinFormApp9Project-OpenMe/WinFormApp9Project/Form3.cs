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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            datastore.LoadData();
            RefreshGridsell();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        medicine m;
        private void dvgsells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dvgsells.Rows[e.RowIndex].Cells["Id"].Value;

                m = datastore.findById(id);


                int amount = (int)numAmount.Value;

                totalcalc((int)m.Cost, amount);

            }
        }


        int total;


        public void totalcalc(int theMed, int amount)
        {
            if (theMed != null)
            {
                total += (theMed * amount);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Disctop dis = new Disctop();
            dis.Show();
            this.Close();
        }

        invoice inv = new invoice();

        void RefreshGridsell()
        {


            dvgsells.Columns.Clear();
            dvgsells.AutoGenerateColumns = false;

            dvgsells.Columns.Add(new DataGridViewTextBoxColumn { Name = "name", HeaderText = "name", DataPropertyName = "TName" });
            dvgsells.Columns.Add(new DataGridViewTextBoxColumn { Name = "cost", HeaderText = "cost", DataPropertyName = "Cost" });
            dvgsells.Columns.Add(new DataGridViewTextBoxColumn { Name = "quantity", HeaderText = "quantity", DataPropertyName = "Quantity" });
            dvgsells.Columns.Add(new DataGridViewTextBoxColumn { Name = "expDate", HeaderText = "ExpDate", DataPropertyName = "ExpDate" });


            var idColumn = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "Id" };
            idColumn.Visible = false;
            dvgsells.Columns.Add(idColumn);

            dvgsells.DataSource = null;
            dvgsells.DataSource = datastore.medicines;

            inv.Items = new List<invoiceItem>();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dvgsells.DataSource = null;
                dvgsells.DataSource = datastore.medicines;
            }
            else
            {
                var results = datastore.findByName(searchText);
                dvgsells.DataSource = null;
                dvgsells.DataSource = results;
            }

        }

        int amount;
        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            if (dvgsells.CurrentRow == null)
            {
                MessageBox.Show("يرجى الإختيار من الجدول");
                return;
            }
            else 
            {
                int id = (int)dvgsells.CurrentRow.Cells["Id"].Value;
                m = datastore.findById(id);

                if ((int)numAmount.Value < m.Quantity)
                {

                    amount = (int)numAmount.Value;
                    totalcalc((int)m.Cost, amount);

                }

                else
                {
                    totalcalc((int)m.Cost, amount);
                    amount = m.Quantity;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textTotal.Text = total.ToString();

            invoiceItem item = new invoiceItem();
            item.Medicine = m;
            item.Quantsell = amount;
            item.Subtotal = m.Cost * amount;
            inv.Items.Add(item);
            
        }


        private void sellbutton_Click(object sender, EventArgs e)
        {
            if(m == null) return;
            m.Quantity -= amount;
            RefreshGridsell();
            total = 0;
            inv.totalinv = total;
            MessageBox.Show("تم البيع بنجاح، رقم الفاتورة:" + inv.invoId);
            datastore.AddInvoice(inv);
        }
    }
}
