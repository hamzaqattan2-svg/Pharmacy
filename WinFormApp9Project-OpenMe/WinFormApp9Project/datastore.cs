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
    public static class datastore
    {
        public static List<medicine> medicines = new List<medicine>();
        public static int LastID = 0;
        public static List<invoice> Invoices = new List<invoice>();
        public static int LastInvoiceID = 0;

        public static void LoadData()
        {
            Addmed(new medicine
            {
                Quantity = 100,
                TName = " cetamol",
                SName = " paracetamol",
                Id = ++LastID,
                ExpDate = new DateTime(2027, 5, 1),
                Com = "comcom",
                Cost = 75
                });

            Addmed(new medicine
            {
                Quantity = 100,
                TName = " Panadol",
                SName = " paracetamol",
                Id = ++LastID,
                ExpDate = new DateTime(2027, 5, 1),
                Com = "comcom",
                Cost = 75
            });

            medicines.Add(new medicine
            {
                Quantity = 100,
                TName = " voltaren",
                SName = " Diclofenac",
                Id = ++LastID,
                ExpDate = new DateTime(2027, 2, 1),
                Com = "comcom",
                Cost = 100
            });

            medicines.Add(new medicine
            {
                Quantity = 100,
                TName = " vitamin D3",
                SName = " cholecalciferol",
                Id = ++LastID,
                ExpDate = new DateTime(2027, 1, 1),
                Com = "comcom",
                Cost = 85
            });

            medicines.Add(new medicine
            {
                Quantity = 76,
                TName = " Redoxon",
                SName = " vitamin C",
                Id = ++LastID,
                ExpDate = new DateTime(2026, 1, 1),
                Com = "comcom",
                Cost = 150
            });

            medicines.Add(new medicine
            {
                Quantity = 76,
                TName = " Zinc",
                SName = " Gluconate",
                Id = ++LastID,
                ExpDate = new DateTime(2026, 1, 1),
                Com = "comcom",
                Cost = 98
            });

            medicines.Add(new medicine
            {
                Quantity = 76,
                TName = " Claritin",
                SName = " Loratadine",
                Id = ++LastID,
                ExpDate = new DateTime(2026, 1, 1),
                Com = "comcom",
                Cost = 45
            });


            medicines.Add(new medicine
            {
                Quantity = 76,
                TName = " Fucidin",
                SName = " Fucidic Acid",
                Id = ++LastID,
                ExpDate = new DateTime(2022, 1, 1),
                Com = "comcom",
                Cost = 75
            });



        }

        public static void Addmed(medicine m)
        {
            medicines.Add(m);
        }

        public static void deleteMed(int id)
        {
            medicines.RemoveAll(m => m.Id == id);
        }

        public static void EditMed(medicine updated)
        {
            int index = medicines.FindIndex(m => m.Id == updated.Id);
            if (index >= 0)
                medicines[index] = updated;
        }

        public static medicine findById(int id)
        {
            return medicines.Find(m => m.Id == id);
        }

        public static medicine findByTName(string name)
        {
            return medicines.Find(m => m.TName.Contains(name));
        }

        public static List<medicine> findByName(string name)
        {
            return medicines.FindAll(m => m.TName.Contains(name.ToLower())
                || m.SName.Contains(name.ToLower())) ;
        }

        public static medicine findBySName(string name)
        {
            return medicines.Find(m => m.SName.Contains(name));
        }

        public static List<medicine> GetExpDate()
        {
            return medicines.FindAll(m => m.ExpDate <= DateTime.Today);
        }


        public static void AddInvoice(invoice invo)
        {
            invo.invoId = ++LastInvoiceID;
            invo.DateSell = DateTime.Today;
            Invoices.Add(invo);
        }


        public static List<medicine> FilterAndSort(
            string comp,
            decimal costFrom,
            decimal costTo,
            string sortBy,
            bool ascending)
        {
            List<medicine> result = new List<medicine>(medicines);

            

            if(!string.IsNullOrWhiteSpace(comp))
            {
                result = result.FindAll(m => m.Com.Contains(comp));
            }

            if (costFrom > 0)
                result = result.FindAll(m => m.Cost >= costFrom);


            if (costTo > 0)
                result = result.FindAll(m => m.Cost <= costTo);

            if (sortBy == "cost")
            {
                result.Sort((a, b) => ascending ? 
                a.Cost.CompareTo(b.Cost) :
                b.Cost.CompareTo(a.Cost));
            }

            else if (sortBy == "company")
            {
                result.Sort((a, b) => ascending ? 
                string.Compare(a.Com, b.Com):
                string.Compare(b.Com, a.Com));
            }

            else if(sortBy == "date")
            {
                result.Sort((a, b) => ascending ? 
                a.ExpDate.CompareTo(b.ExpDate):
                b.ExpDate.CompareTo(a.ExpDate));
            }

            return result;

        }











    }

}

