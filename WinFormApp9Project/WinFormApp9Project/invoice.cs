using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp9Project
{
    public class invoice
    {
        public int invoId;
        public List<invoiceItem> Items = new List<invoiceItem>();
        public decimal totalinv;
        public DateTime DateSell;
    }
}
