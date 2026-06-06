using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp9Project
{
    public class invoiceItem
    {
        public medicine Medicine { get; set; }

        public int Quantsell { get; set; }

        public decimal Subtotal { get; set; }

        public string MedicineName {  get { return Medicine.TName; } }
    }
}
