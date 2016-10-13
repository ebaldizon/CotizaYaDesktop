using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace CotizaYA_00
{
    class WordAdmin
    {
        public Invoice invoice { get; set; }

        public void fillWord()
        {
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            //string ruta = Application.StartupPath + @"\documento.docx";
            string ruta = "F:\\BALRY.docx";
            object parametro = ruta;

            createRefObj("name", ObjMiss, ObjWord, parametro);
            createRefObj("address", ObjMiss, ObjWord, parametro);
            createRefObj("date", ObjMiss, ObjWord, parametro);
            createRefObj("number", ObjMiss, ObjWord, parametro);
            createRefObj("subtotal", ObjMiss, ObjWord, parametro);
            createRefObj("tax", ObjMiss, ObjWord, parametro);
            createRefObj("total", ObjMiss, ObjWord, parametro);
            fillTable(ObjMiss, ObjWord, parametro);

            try
            {
                ObjWord.Visible = true;
            }
            catch(Exception e)
            {
                e.ToString();
            }
            
        }

        public void createRefObj(string name, object ObjMiss, Word.Application ObjWord, object parameter)
        {
            try
            {
                object nameObj = name;
                Word.Document ObjDoc = ObjWord.Documents.Open(parameter, ObjMiss);

                Word.Range nameRange = ObjDoc.Bookmarks.get_Item(ref nameObj).Range;
                nameRange.Text = getInvoiceAttribute(name);

                object refObjName = nameRange;
                ObjDoc.Bookmarks.Add(name, ref refObjName);
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }

        public void createRefObjMatrix(int i, int j, object ObjMiss, Word.Application ObjWord, object parameter)
        {
            try { 
            
                string name = getMatrixBookMark(i, j);
                object nameObj = name;
                Word.Document ObjDoc = ObjWord.Documents.Open(parameter, ObjMiss);

                Word.Range nameRange = ObjDoc.Bookmarks.get_Item(ref nameObj).Range;
                nameRange.Text = getField(i,j);

                object refObjName = nameRange;
                ObjDoc.Bookmarks.Add(name, ref refObjName);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public string getField(int i, int j)
        {
            if(this.invoice.QuotedList[i, j].ToString() != null)
            {
                return this.invoice.QuotedList[i, j].ToString();
            }
            else if(this.invoice.QuotedList[i, j].ToString() == "")
            {
                return "---";
            }
            else
            {
                return "NR";
            }
        }

        public void fillTable(object ObjMiss, Word.Application ObjWord, object parameter)
        {
            for(int f=0; f<23; f++)
            {
                for(int c=0; c<4; c++)
                {
                    createRefObjMatrix(f , c, ObjMiss, ObjWord, parameter);
                }
            }
        }

        //Boomarks empleados en el word, en este caso total hay 4 columnas con 23 filas cada uno
        public string getMatrixBookMark(int i, int j)
        {
            if(j == 0)
            {
                return "cod" + i;
            }
            else if(j == 1)
            {
                return "description" + i;
            }
            else if(j == 2)
            {
                return "q" + i;
            }
            else if(j == 3)
            {
                return "price" + i;
            }
            return "";
        }
        
        public string getInvoiceAttribute(string attribute)
        {
            if(attribute == "name")
            {
                return this.invoice.Name;
            }
            else if(attribute == "address")
            {
                return this.invoice.Address;
            }
            else if(attribute == "date")
            {
                return this.invoice.Date.ToString();
            }
            else if (attribute == "number")
            {
                return this.invoice.Number.ToString();
            }
            else if(attribute == "subtotal")
            {
                return this.invoice.SubTotal.ToString();
            }
            else if(attribute == "tax")
            {
                return this.invoice.Tax.ToString();
            }
            else if(attribute == "total")
            {
                return this.invoice.Total.ToString();
            }
            else
            {
                return "";
            }
        }


    }
}
