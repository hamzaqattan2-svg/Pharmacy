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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        List<medicine> ExMed = new List<medicine>();


        public void isexmed()
        {
            for (int i = 0; i < datastore.medicines.Count; i++)
            {
                if (datastore.medicines[i].ExpDate <= DateTime.Today)
                    ExMed.Add(datastore.medicines[i]);
            }
        }


        private void butdel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه الأدوية", "تأكيد الحذف", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < ExMed.Count; i++)
                {
                    datastore.deleteMed(ExMed[i].Id);
                    ExMed.Remove(ExMed[i]);
                }
                MessageBox.Show("تم حذف الأدوية بنجاح");
            }


        }

        void RefreshGridEx()
        {


            dvgExMed.Columns.Clear();
            dvgExMed.AutoGenerateColumns = false;

            dvgExMed.Columns.Add(new DataGridViewTextBoxColumn { Name = "name", HeaderText = "name", DataPropertyName = "TName" });
            dvgExMed.Columns.Add(new DataGridViewTextBoxColumn { Name = "cost", HeaderText = "cost", DataPropertyName = "Cost" });
            dvgExMed.Columns.Add(new DataGridViewTextBoxColumn { Name = "quantity", HeaderText = "quantity", DataPropertyName = "Quantity" });
            dvgExMed.Columns.Add(new DataGridViewTextBoxColumn { Name = "expDate", HeaderText = "ExpDate", DataPropertyName = "ExpDate" });


            dvgExMed.DataSource = null;
            dvgExMed.DataSource = ExMed;


        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            datastore.LoadData();
            RefreshGridEx();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Disctop dis = new Disctop();
            dis.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void butreq_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ExMed.Count; i++)
            {
                ExMed[i].ExpDate = new DateTime(2027, 5, 1);
            }
        }
    }
}
