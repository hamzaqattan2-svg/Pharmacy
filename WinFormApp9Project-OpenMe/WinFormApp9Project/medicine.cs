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
    public class medicine
    {
        int quantity;
        string tName, sName;
        int id;
        decimal cost;
        DateTime expDate = new DateTime();
        string com;

        public medicine() { }

        public medicine(int n, string t, string s, int i, DateTime e, string c, decimal m)
        {
            this.quantity = n;
            this.tName = t;
            this.sName = s;
            this.id = i;
            this.expDate = e;
            this.com = c;
            this.cost = m;
        }


        public int Quantity
        { set { quantity = value; } get { return quantity; } }

        public string TName
        { set { tName = value; } get { return tName; } }

        public string SName
        { set { sName = value; } get { return sName; } }

        public int Id
        { get; set; }

        public DateTime ExpDate
        { set { expDate = value; } get { return expDate; } }

        public string Com
        { set { com = value; } get { return com; } }

        public decimal Cost
        { set { cost = value; } get { return cost; } }

    }

}

