using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace CotizaYA_00.Business
{
    class PDFAdmin
    {
        public string WordFilter = "Word Files(.docx)|*.docx|All Files(*.*)|*.*";
        public string PDFFilter = "PDF Files(.pdf)|*.pdf|All Files(*.*)|*.*";
        public bool WordToPDF(string pathWord, string pathPDF, Microsoft.Office.Interop.Word.Document wordDocument, Microsoft.Office.Interop.Word.Application appWord)
        {
            try
            {
                wordDocument = appWord.Documents.Open(@pathWord);
                
                wordDocument.ExportAsFixedFormat(@pathPDF, WdExportFormat.wdExportFormatPDF);
                wordDocument.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

            //wordDocument = appWord.Documents.Open(@"F:\\BALRY.docx");
            //wordDocument.ExportAsFixedFormat(@"F:\DocTo.pdf", WdExportFormat.wdExportFormatPDF);
        }


    }
}
