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
        public WordAdmin wordAdmin { get; set; }

        public InvoiceAdmin(string name, string address, DateTime date, int number, DataGridView dgw)
        {
            invoice = new Invoice();
            wordAdmin = new WordAdmin();
            this.dataGW = dgw;
            this.invoice.Name = name;
            this.invoice.Address = address;
            this.invoice.Date = date;
            this.invoice.Number = number;
            this.DataGridViewToMatrix();
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

        public void fillWord()
        {
            wordAdmin.invoice = this.invoice;
            wordAdmin.fillWord();
        }

        public void DataGridViewToMatrix()
        {
            try
            {
                for(int r=0; r<23; r++)
                {
                    for (int c=0; c<4; c++)
                    {
                        if(this.dataGW.Rows[r].Cells[c].Value.ToString() != null)
                        {
                            this.invoice.QuotedList[r, c] = this.dataGW.Rows[r].Cells[c].Value.ToString();
                        }
                        else
                        {
                            this.invoice.QuotedList[r, c] = "";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /*
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
         
         */
    }
}
