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
    public partial class Disctop : Form
    {

        public static string AppPath = Application.StartupPath;

        public Disctop()
        {
            InitializeComponent();
        }

        private void Disctop_Load(object sender, EventArgs e)
        {
            desctopStyle();
        }

        void desctopStyle()
        {


        }


        private void picprogram1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void picprogram2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void picprogram3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void picprogram4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void picprogram5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.ShowDialog();
        }
    }
}
