﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using CotizaYA_00.Business;

namespace CotizaYA_00
{
    
    class WordAdmin
    {
        public Invoice invoice { get; set; }

        public string PathGlobal { get; set; }
        public string PathWord { get; set; }

        public bool WordCreated { get; set; }

        public WordAdmin()
        {
            this.PathGlobal = "F:\\";
            this.PathWord = "F:\\BALRY.docx";
            this.WordCreated = false;
        }

        public bool fillWord()
        {

            try
            {
                object ObjMiss = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Application ObjWord = new Microsoft.Office.Interop.Word.Application();
                
                //string ruta = Application.StartupPath + @"\documento.docx";

                object parametro = this.PathWord;
                Microsoft.Office.Interop.Word.Document ObjDoc = ObjWord.Documents.Open(parametro, ObjMiss);

                createRefObj("name", ObjMiss, ObjWord, parametro);
                createRefObj("address", ObjMiss, ObjWord, parametro);
                createRefObj("date", ObjMiss, ObjWord, parametro);
                createRefObj("number", ObjMiss, ObjWord, parametro);
                createRefObj("subtotal", ObjMiss, ObjWord, parametro);
                createRefObj("tax", ObjMiss, ObjWord, parametro);
                createRefObj("total", ObjMiss, ObjWord, parametro);
                fillTable(ObjMiss, ObjWord, parametro);
                
         
                ObjWord.Visible = false;
                this.WordCreated = true;
                ObjDoc.SaveAs2("F:\\DOCUMENTBALRY.docx");
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }

        }

        public void createRefObj(string name, object ObjMiss, Microsoft.Office.Interop.Word.Application ObjWord, object parameter)
        {
            try
            {
                object nameObj = name;
                Microsoft.Office.Interop.Word.Document ObjDoc = ObjWord.Documents.Open(parameter, ObjMiss);

                Microsoft.Office.Interop.Word.Range nameRange = ObjDoc.Bookmarks.get_Item(ref nameObj).Range;
                nameRange.Text = getInvoiceAttribute(name);

                object refObjName = nameRange;
                ObjDoc.Bookmarks.Add(name, ref refObjName);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void createRefObjMatrix(int i, int j, object ObjMiss, Microsoft.Office.Interop.Word.Application ObjWord, object parameter)
        {
            try
            {

                string name = getMatrixBookMark(i, j);
                object nameObj = name;
                Microsoft.Office.Interop.Word.Document ObjDoc = ObjWord.Documents.Open(parameter, ObjMiss);

                Microsoft.Office.Interop.Word.Range nameRange = ObjDoc.Bookmarks.get_Item(ref nameObj).Range;
                nameRange.Text = getField(i, j);

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
            if (this.invoice.QuotedList[i, j].ToString() != null)
                return this.invoice.QuotedList[i, j].ToString();
            else
                return "";
        }

        public void fillTable(object ObjMiss, Microsoft.Office.Interop.Word.Application ObjWord, object parameter)
        {
            for (int f = 0; f < 23; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    createRefObjMatrix(f, c, ObjMiss, ObjWord, parameter);
                }
            }
        }

        //Boomarks empleados en el word, en este caso total hay 4 columnas con 23 filas cada uno
        public string getMatrixBookMark(int i, int j)
        {
            if (j == 0)
                return "cod" + i;
            else if (j == 1)
                return "description" + i;
            else if (j == 2)
                return "q" + i;
            else if (j == 3)
                return "price" + i;
            return "";
        }

        public string getInvoiceAttribute(string attribute)
        {
            if (attribute == "name")
                return this.invoice.Name;
            else if (attribute == "address")
                return this.invoice.Address;
            else if (attribute == "date")
                return this.invoice.Date.ToString("dd/MM/yyyy");
            else if (attribute == "number")
                return this.invoice.Number.ToString();
            else if (attribute == "subtotal")
                return this.invoice.SubTotal.ToString();
            else if (attribute == "tax")
                return this.invoice.Tax.ToString();
            else if (attribute == "total")
                return this.invoice.Total.ToString();
            else
                return "";
        }

    }

}
