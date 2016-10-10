using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizaYA_00
{
    class InvoiceAdmin
    {
        public Invoice invoice { get; set; }
        public DataGridView dataGW { get; set; }

        public InvoiceAdmin(string name, string address, DateTime date, int number, DataGridView dgw)
        {
            invoice = new Invoice();
            this.dataGW = dgw;
            this.invoice.Name = name;
            this.invoice.Address = address;
            this.invoice.Date = date;
            this.invoice.Number = number;
        }

        private double calculateSubTotal()
        {
            double subTotal = 0;

            try
            {
                for (int i = 0; i < 23; i++)
                {
                    double productPrice = double.Parse(this.dataGW.Rows[i].Cells["UnitPrice"].Value.ToString());
                    double productQuantity = double.Parse(this.dataGW.Rows[i].Cells["Quantity"].Value.ToString());
                    subTotal += productPrice * productQuantity;
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return subTotal;
        }

        public void calculateInvoice()
        {
            this.invoice.SubTotal = calculateSubTotal();
            this.invoice.PercentageTax = 0.13;
            this.invoice.calculateAll();
        }

    }
}
