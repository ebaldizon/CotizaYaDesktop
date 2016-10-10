using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizaYA_00
{
    class Invoice
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double PercentageTax { get; set; }
        public double Total { get; set; }
        public string[,] QuotedList{ get; set; }

        public Invoice()
        {
            this.QuotedList = new string[23, 4];
        }

        public void updateQuoted(int column, int row, string field)
        {
            this.QuotedList[column, row] = field;
        }

        /*
        public bool calculateSubTotal()
        {
           int sum = 0;
            bool subEstate = false;

           for (int i = 0; i < 23; i++)
           {
                if (this.QuotedList[4, i] != null)
                {
                    sum += Int32.Parse(this.QuotedList[4, i]);
                    subEstate = true;
                }
           }
           this.SubTotal = sum;
            return subEstate;      
        }*/

        public bool calculateTax()
        {
            if(this.SubTotal != 0)
            {
                this.Tax = this.SubTotal * this.PercentageTax;
                return true;
            }
            return false;
        }

        public bool calculateTotal()
        {
            if(this.Tax != 0)
            {
                this.Total = this.SubTotal + this.Tax;
                return true;
            }
            return false;
        }

        public bool calculateAll()
        {
            if(this.SubTotal != 0)
            {
                if(calculateTax() != false)
                {
                    if(calculateTotal() != false)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
