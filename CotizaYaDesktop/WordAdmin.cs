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
        
        public WordAdmin(Invoice i)
        {
            this.invoice = i;
        }

        public void fillWord()
        {
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            //string ruta = Application.StartupPath + @"\documento.docx";
            string ruta = "F:\\documento.docx";

            object parametro = ruta;
            object nombre1 = "nombre";
            object telefono1 = "telefono";

            Word.Document ObjDoc = ObjWord.Documents.Open(parametro, ObjMiss);
            Word.Range nom = ObjDoc.Bookmarks.get_Item(ref nombre1).Range;
            //nom.Text = textBox1.Text;
            Word.Range tel = ObjDoc.Bookmarks.get_Item(ref telefono1).Range;
            //tel.Text = textBox2.Text;

            object rango1 = nom;
            object rango2 = tel;

            ObjDoc.Bookmarks.Add("nombre", ref rango1);
            ObjDoc.Bookmarks.Add("telefono", ref rango2);
            ObjWord.Visible = true;
        }
    }
}
