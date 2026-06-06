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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textemail.Text == "person@gmail.com" && textpass.Text == "moon" && chkrebot.Checked)
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح");
                this.Close();
                Disctop dis = new Disctop();
                dis.ShowDialog();
            }
            else if (textemail.Text == "person@gmail.com" && textpass.Text == "moon")
            {
                MessageBox.Show("أكد أنك لست روبوت رجاء");
                chkrebot.ForeColor = Color.Red;
            }
            else if (textemail.Text == "person@gmail.com" && chkrebot.Checked)
            {
                MessageBox.Show("تأكد من كلمة المرور رجاء");
                lblpass.BackColor = Color.Red;
            }
            else if (textpass.Text == "moon" && chkrebot.Checked)
            {
                MessageBox.Show("تأكد من البريد الإلكتروني رجاء");
                lblemail.BackColor = Color.Red;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
