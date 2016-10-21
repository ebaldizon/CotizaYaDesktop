using CotizaYA_00.Business;
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
        public bool WordEstate { get; set; }

        public PDFAdmin pdfAdmin { get; set; }

        public InvoiceAdmin(string name, string address, DateTime date, int number, DataGridView dgw)
        {
            invoice = new Invoice();
            wordAdmin = new WordAdmin();
            pdfAdmin = new PDFAdmin();
            this.dataGW = dgw;
            this.invoice.Name = name;
            this.invoice.Address = address;
            this.invoice.Date = date;
            this.invoice.Number = number;
            this.DataGridViewToMatrix();
            this.WordEstate = false;
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

        public bool fillWord()
        {
            this.wordAdmin.invoice = this.invoice;
            this.wordAdmin.fillWord();
            this.WordEstate = true;
            return true;
        }

        public bool wordToPDF()
        {
            if(this.WordEstate == false)
            {
                fillWord();
            }

            return this.pdfAdmin.WordToPDF("F:\\DOCUMENTBALRY.docx", "F:\\myDocument.pdf");
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
